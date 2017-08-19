Imports System.Runtime.InteropServices
''' <summary>
''' Global Keyboard Hook
''' </summary>
''' <remarks>This is the keyboard hook class which will carry out the process to identify which keystroke is pressed. </remarks>
Public Class GlobalKeyboardHook
    Private Const HC_ACTION As Integer = 0
    Private Const WH_KEYBOARD_LL As Integer = 13
    Private Const WM_KEYDOWN As Integer = &H100
    Private Const WM_KEYUP As Integer = &H101
    Private Const WM_SYSKEYDOWN As Integer = &H104
    Private Const WM_SYSKEYUP As Integer = &H105
    Private Structure Hook_Structure
        Public VK_Code As Integer
        Public Scan_Code As Integer
        Public _Flags As Integer
        Public _Time As Integer
        Public DW_Extra_Info As Integer
    End Structure
    Private Declare Function SetWindowsHookEx Lib "user32" Alias "SetWindowsHookExA" (ByVal ID_Hook As Integer, ByVal LP_FN As Key_ProcessDelegate, ByVal H_Mod As Integer, ByVal DW_Thread_ID As Integer) As Integer
    Private Declare Function CallNextHookEx Lib "user32" (ByVal H_Hook As Integer, ByVal N_Code As Integer, ByVal W_Param As Integer, ByVal L_Param As Hook_Structure) As Integer
    Private Declare Function UnhookWindowsHookEx Lib "user32" (ByVal H_Hook As Integer) As Integer
    Private Delegate Function Key_ProcessDelegate(ByVal N_Code As Integer, ByVal W_Param As Integer, ByRef L_Param As Hook_Structure) As Integer
    Public Shared Event KeyDown(ByVal Key As Keys)
    Public Shared Event KeyUp(ByVal Key As Keys)
    Private Shared KeyHook As Integer
    Private Shared KeyHookDelegate As Key_ProcessDelegate
    Public Sub Hook()
        KeyHookDelegate = New Key_ProcessDelegate(AddressOf Key_Process)
        KeyHook = SetWindowsHookEx(WH_KEYBOARD_LL, KeyHookDelegate, System.Runtime.InteropServices.Marshal.GetHINSTANCE(System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0)).ToInt32, 0)
    End Sub
    Private Function Key_Process(ByVal N_Code As Integer, ByVal W_Param As Integer, ByRef L_Param As Hook_Structure) As Integer
        If (N_Code = HC_ACTION) Then
            Select Case W_Param
                Case WM_KEYDOWN, WM_SYSKEYDOWN
                    RaiseEvent KeyDown(CType(L_Param.VK_Code, Keys))
                Case WM_KEYUP, WM_SYSKEYUP
                    RaiseEvent KeyUp(CType(L_Param.VK_Code, Keys))
            End Select
        End If
        Return CallNextHookEx(KeyHook, N_Code, W_Param, L_Param)
    End Function
    Public Sub Unhook()
        UnhookWindowsHookEx(KeyHook)
        MyBase.Finalize()
    End Sub
    Public Function Feed(ByVal e As Keys) As String
        Select Case e
            Case 65 To 90
                Return e.ToString
            Case Else
                Return Nothing
        End Select
    End Function
End Class
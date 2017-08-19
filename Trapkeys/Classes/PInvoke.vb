Imports System.Runtime.InteropServices
Imports System.Text

Public Class PInvoke

    Private Declare Function GetForegroundWindow Lib "user32.dll" () As IntPtr
    <DllImport("user32.dll")> _
    Private Shared Function SetForegroundWindow(ByVal hWnd As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function
    <DllImport("user32.dll", SetLastError:=True)> _
    Private Shared Function SetActiveWindow(ByVal hWnd As IntPtr) As IntPtr
    End Function
    <DllImport("user32.dll", SetLastError:=True)> _
    Private Shared Function GetActiveWindow() As IntPtr
    End Function

    Private Declare Function SetFocus Lib "user32.dll" (ByVal hwnd As IntPtr) As IntPtr

    Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    Declare Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As IntPtr, ByRef lParam As StringBuilder) As IntPtr

    Const WM_SETTEXT As Integer = &HC
    Public Const WM_KEYDOWN = &H100
    Public Const WM_KEYUP = &H101
    Const GW_CHILD As Long = 5
    Public Function GetFocusedWindow() As IntPtr
        Dim hWnd As IntPtr = GetForegroundWindow()
        If hWnd <> Nothing Then
            Return hWnd
        End If
        Return Nothing
    End Function
    Public Sub SetFocusedWindow(ByVal hWnd As IntPtr)
        SetForegroundWindow(hWnd)
    End Sub
    Public Sub SendText(ByVal WindowHandle As IntPtr, ByVal Message As StringBuilder)
        SendMessage(WindowHandle, WM_KEYDOWN, 0, Message)
    End Sub

    <System.Runtime.InteropServices.StructLayout(Runtime.InteropServices.LayoutKind.Sequential)> _
    Public Structure POINT
        Public X As Integer
        Public Y As Integer

        Public Sub New(ByVal X As Integer, ByVal Y As Integer)
            Me.X = X
            Me.Y = Y
        End Sub
    End Structure
    <DllImport("user32.dll", ExactSpelling:=True, SetLastError:=True)> _
    Public Shared Function GetCursorPos(ByRef lpPoint As POINT) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function
    Public Function GetCursorPosition() As System.Drawing.Point
        Dim p As POINT
        If GetCursorPos(p) Then
            Return New System.Drawing.Point(Convert.ToString(p.X), Convert.ToString(p.Y))
        End If
    End Function

End Class

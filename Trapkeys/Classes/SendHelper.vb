Imports System.Text
Imports WindowsInput.InputSimulator
Imports WindowsInput

Public Class SendHelper

    Private hWnd As IntPtr
    Private Message As String
    Private PInvokeHelper As PInvoke

    Public Sub New(ByVal hWnd As IntPtr, ByVal Message As String)
        Me.hWnd = hWnd
        Me.Message = Message
    End Sub

    Private Buffer As IDataObject

    Public Sub SendMessage()
        PInvokeHelper = New PInvoke
        PInvokeHelper.SetFocusedWindow(hWnd)
        If UseClipboard Then
            Buffer = Clipboard.GetDataObject()
            Clipboard.SetText(Message)
            SendKeys.SendWait("^(v)")
            'InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_V)
            Clipboard.SetDataObject(Buffer)
            Buffer = Nothing
        Else
            InputSimulator.SimulateTextEntry(Message)
        End If
        WindowHandle = Nothing
    End Sub
End Class

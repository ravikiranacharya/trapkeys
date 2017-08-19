Imports Microsoft.Win32

Module Functions
    Private RegKey As RegistryKey

    Public Sub AddToStartup(ByVal StartupName As String, ByVal Path As String)
        Try
            RegKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            RegKey.SetValue(StartupName, Path)
            RegKey.Close()
        Catch ex As Exception
            ExHandler.PostException(ex)
        End Try
    End Sub
    Public Sub RemoveFromStartup(ByVal StartupName As String)
        Try
            RegKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            RegKey.DeleteValue(StartupName)
            RegKey.Close()
        Catch ex As Exception
            ExHandler.PostException(ex)
        End Try
    End Sub

    Public Function ConfirmOperation() As Boolean
        Dim Selection As Integer = MessageBox.Show("Are you really sure about performing this operation? This is not reversible.", "Confirm Operation!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        Select Case Selection
            Case DialogResult.Yes
                Return True
            Case Else
                Return False
        End Select
        Return False
    End Function
End Module

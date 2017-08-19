Public Class ExceptionHandler

    Private RemoteMethods As RemoteMethods

    Public Sub New()
        RemoteMethods = New RemoteMethods(ServerLocation)
    End Sub

    Public Sub PostException(e As Exception)
        Try
            If ReportExceptions Then
                RemoteMethods.SendVariables(New String() {"calltype", "userid", "exception"}, New String() {"Exceptions", UserID, e.ToString})
            Else
                Throw New Exception("Web Exception")
            End If
        Catch ex As Exception
            IO.File.AppendAllText("Exceptions.txt", Environment.NewLine & "Time: " & Now.ToString & ex.ToString)
        End Try
    End Sub
End Class

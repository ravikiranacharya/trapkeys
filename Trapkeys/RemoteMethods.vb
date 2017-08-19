Imports System.Net
Imports System.Collections.Specialized
Imports System.Text.Encoding
Imports AutoUpdaterDotNET

Public Class RemoteMethods

    Private ServerLocation As String
    Private Client As WebClient
    Private ClientResponse As WebResponse
    Private Parameters As NameValueCollection

    Public Sub New(ByVal ServerLocation As String)
        Me.ServerLocation = ServerLocation
    End Sub

    Private EncryptionMethods As EncryptionMethods
    Public Function IsUpdateAvailable(ByVal ApplicationPath As String) As Boolean
        Try
            EncryptionMethods = New EncryptionMethods
            Dim SHA256Hash As String = EncryptionMethods.CalculateSHA256Hash(ApplicationPath)
            If GetRemoteValue("versionhash") <> SHA256Hash Then
                Return True
            End If
            Return False
        Catch ex As Exception
            ExHandler.PostException(ex)
            Return False
        End Try
    End Function

    Public Sub DownloadUpdate()
        Try
            AutoUpdater.Start(String.Concat(ServerLocation, "update.xml"))
        Catch ex As Exception
            ExHandler.PostException(ex)
        End Try
    End Sub

    Public Function GetRemoteValue(ByVal RequestKey As String) As String
        Parameters = New NameValueCollection
        Client = New WebClient
        Parameters.Add("requestkey", RequestKey)
        Dim ResponseBody As Byte() = Client.UploadValues(ServerLocation, Parameters)
        Return Unicode.GetString(ResponseBody)
    End Function

    Public Sub SendVariables(ByVal PostVariables As String(), ByVal Params As String())
        Client = New WebClient
        For i = 0 To PostVariables.Length - 1
            Parameters.Add(PostVariables(i), Params(i))
        Next
        Dim ResponseBody As Byte() = Client.UploadValues(ServerLocation, Parameters)
    End Sub
End Class

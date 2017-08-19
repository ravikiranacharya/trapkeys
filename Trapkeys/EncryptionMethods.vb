Imports System.IO
Imports System.Security
Imports System.Security.Cryptography

Public Class EncryptionMethods

    Public Function CalculateSHA256Hash(ByVal File As String) As String
        Using SHA256 As New SHA256CryptoServiceProvider
            Using Stream As New FileStream(File, FileMode.Open, FileAccess.Read)
                Return BitConverter.ToString(SHA256.ComputeHash(Stream)).Replace("-", String.Empty).ToLower
            End Using
        End Using
    End Function

    Public Function CalculateSHA1Hash(ByVal File As String) As String
        Using SHA1 As New SHA1CryptoServiceProvider
            Using Stream As New FileStream(File, FileMode.Open, FileAccess.Read)
                Return BitConverter.ToString(SHA1.ComputeHash(Stream)).Replace("-", String.Empty).ToLower
            End Using
        End Using
    End Function

    Public Function CalculateMD5Hash(ByVal File As String) As String
        Using MD5 As New MD5CryptoServiceProvider
            Using Stream As New FileStream(File, FileMode.Open, FileAccess.Read)
                Return BitConverter.ToString(MD5.ComputeHash(Stream)).Replace("-", String.Empty).ToLower
            End Using
        End Using
    End Function
End Class

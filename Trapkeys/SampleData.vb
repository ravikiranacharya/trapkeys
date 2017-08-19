Public Class SampleData

    Private SQLiteHelper As SQLiteManager
    Private SampleDataPath As String
    Private SampleData As String

    Public Sub New(ByVal SampleDataPath As String)
        Me.SampleDataPath = SampleDataPath
        SampleData = IO.File.ReadAllText(SampleDataPath)
        SQLiteHelper = New SQLiteManager("Trapkeys.sqlite", 3)
    End Sub

    Public Sub InsertSampleData()
        For i = 0 To SampleData.Length - 1
            SQLiteHelper.InsertRecord("H", "How are you today?", Now.ToString)
        Next
    End Sub
    Public Sub RemoveSampleData()

    End Sub
End Class

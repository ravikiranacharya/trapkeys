Public Class EditMessage
    Private SQLiteManager As SQLiteManager
    Public Shared ID As Integer
    Public Shared Shortcut As String
    Public Shared Message As String
    Private Sub SparkButton1_Click(sender As Object, e As EventArgs) Handles SparkButton1.Click
        'If SparkTextBox1.Text <> Nothing And SparkTextBox2.Text <> Nothing Then
        SQLiteManager.UpdateRecord(ID, SparkTextBox1.Text, SparkTextBox2.Text)
        SQLiteManager.FetchAllRecords(Form1.ListView1)
        'End If
        Me.Close()
    End Sub

    Private Sub EditMessage_Load(sender As Object, e As EventArgs) Handles Me.Load
        SparkTextBox1.Text = Shortcut
        SparkTextBox2.Text = Message
        SQLiteManager = New SQLiteManager("Trapkeys.sqlite", 3)
    End Sub

    Private Sub SparkButton2_Click(sender As Object, e As EventArgs) Handles SparkButton2.Click
        Me.Close()
    End Sub
End Class
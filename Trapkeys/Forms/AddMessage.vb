Public Class AddMessage
    Private SQLiteManager As SQLiteManager
    Public Shared Shortcut As String = "H"
    Public Shared Message As String = "Hi! How are you today?"

    Private Sub SparkButton1_Click(sender As Object, e As EventArgs) Handles SparkButton1.Click
        Try
            SQLiteManager = New SQLiteManager("Trapkeys.sqlite", 3)
            SQLiteManager.CreateTable()
            SQLiteManager.InsertRecord(SparkTextBox1.Text, SparkTextBox2.Text, Now.ToShortTimeString)
            SQLiteManager.FetchAllRecords(Form1.ListView1)
            Me.Close()
        Catch ex As Exception
            ExHandler.PostException(ex)
        End Try
    End Sub

    Private Sub SparkButton2_Click(sender As Object, e As EventArgs) Handles SparkButton2.Click
        Me.Close()
    End Sub

    Private Sub AddMessage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Form1.StopService()
        Form1.StartService()
        Form1.Show()
    End Sub

    Private Sub AddMessage_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.StartPosition = FormStartPosition.WindowsDefaultBounds
        SparkTextBox1.Text = Shortcut
        SparkTextBox2.Text = Message
    End Sub
End Class
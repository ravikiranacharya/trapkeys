Imports System.Data.SQLite

Public Class HistoryManager

    ''' <summary>
    ''' Name of the database you want to create. Include the .sqlite extension to the name.
    ''' </summary>
    ''' <remarks></remarks>
    Private DatabaseName As String
    Private Version As Integer
    Private Connection As SQLiteConnection
    Private SQLCommand As SQLiteCommand

    Public Sub New(DatabaseName As String, Version As Integer)
        Me.DatabaseName = DatabaseName
        Me.Version = Version
        Connection = New SQLiteConnection("Data Source=" & DatabaseName & ";Version=" & Version)
        Connection.Open()
        CreateTable()
    End Sub
    Private Query As String
    Public Sub CreateTable()
        Query = "CREATE TABLE IF NOT EXISTS HISTORY (ID INTEGER PRIMARY KEY AUTOINCREMENT, Shortcut TEXT, Message TEXT, UsageTime TEXT)"
        Using SQLCommand As New SQLiteCommand(Query, Connection)
            Try
                SQLCommand.ExecuteNonQuery()
            Catch ex As Exception
                ExHandler.PostException(ex)
            End Try
        End Using
    End Sub
    Public Sub InsertRecord(ByVal Shortcut As String, Message As String, UsageTime As String)
        Connection = New SQLiteConnection("Data Source=" & DatabaseName & ";Version=" & Version)
        Connection.Open()
        Query = "INSERT INTO HISTORY (ID, Shortcut, Message, UsageTime) VALUES (Null, @Shortcut, @Message, @UsageTime)"
        Using SQLCommand As New SQLiteCommand(Query, Connection)
            SQLCommand.Parameters.Add("@Shortcut", DbType.String).Value = Shortcut
            SQLCommand.Parameters.Add("@Message", DbType.String).Value = Message
            SQLCommand.Parameters.Add("@UsageTime", DbType.String).Value = UsageTime
            Try
                SQLCommand.ExecuteNonQuery()
            Catch ex As Exception
                ExHandler.PostException(ex)
            End Try
        End Using
    End Sub
    Private SQLReader As SQLiteDataReader

    Public Sub FetchAllRecords(ByVal DataGridView As DataGridView)
        Connection = New SQLiteConnection("Data Source=" & DatabaseName & ";Version=" & Version)
        Connection.Open()
        Query = "SELECT * FROM HISTORY"
        Using SQLCommand As New SQLiteCommand(Query, Connection)
            SQLCommand.CommandType = CommandType.Text
            Using SQLAdapter As New SQLiteDataAdapter(SQLCommand)
                Using DataTable As New DataTable()
                    SQLAdapter.Fill(DataTable)
                    DataGridView.DataSource = DataTable
                End Using
            End Using
        End Using
    End Sub
    Public Sub DropTable()
        Query = "DROP TABLE HISTORY"
        Using SQLCommand As New SQLiteCommand(Query, Connection)
            Try
                SQLCommand.ExecuteNonQuery()
            Catch ex As Exception
                ExHandler.PostException(ex)
            End Try
        End Using
    End Sub
    Public Function GetMostUsedKey() As String
        Query = "SELECT Shortcut FROM HISTORY GROUP BY Shortcut HAVING COUNT(*) = (SELECT MAX(Cnt) FROM ( SELECT COUNT(*) AS Cnt FROM HISTORY GROUP BY Shortcut) tmp )"
        Using SQLCommand As New SQLiteCommand(Query, Connection)
            Try
                Dim i As String = Convert.ToString(SQLCommand.ExecuteScalar)
                Return i
            Catch ex As Exception
                ExHandler.PostException(ex)
            End Try
        End Using
        Return Nothing
    End Function
End Class

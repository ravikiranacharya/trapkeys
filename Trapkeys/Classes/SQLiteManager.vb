Imports System.Data.SQLite

Public Class SQLiteManager
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
    End Sub
    Private Query As String
    Public Sub CreateTable()
        Query = "CREATE TABLE IF NOT EXISTS RESPONSES (ID INTEGER PRIMARY KEY AUTOINCREMENT, Shortcut TEXT, Message TEXT, CreationTime TEXT)"
        Using SQLCommand As New SQLiteCommand(Query, Connection)
            Try
                SQLCommand.ExecuteNonQuery()
            Catch ex As Exception
                ExHandler.PostException(ex)
            End Try
        End Using
    End Sub
    Public Sub InsertRecord(ByVal Shortcut As String, Message As String, CreationTime As String)
        Connection = New SQLiteConnection("Data Source=" & DatabaseName & ";Version=" & Version)
        Connection.Open()
        Query = "INSERT INTO RESPONSES (ID, Shortcut, Message, CreationTime) VALUES (Null, @Shortcut, @Message, @CreationTime)"
        Using SQLCommand As New SQLiteCommand(Query, Connection)
            SQLCommand.Parameters.Add("@Shortcut", DbType.String).Value = Shortcut
            SQLCommand.Parameters.Add("@Message", DbType.String).Value = Message
            SQLCommand.Parameters.Add("@CreationTime", DbType.String).Value = CreationTime
            Try
                SQLCommand.ExecuteNonQuery()
            Catch ex As Exception
                ExHandler.PostException(ex)
            End Try
        End Using
    End Sub
    Private SQLReader As SQLiteDataReader
    Private ListviewItem As ListViewItem
    Public Sub FetchMessages(ByVal HotKey As String, ByVal Listview As ListView)
        Connection = New SQLiteConnection("Data Source=" & DatabaseName & ";Version=" & Version)
        Connection.Open()
        Query = "SELECT Message FROM RESPONSES WHERE Shortcut=@HotKey"
        Using SQLCommand As New SQLiteCommand(Query, Connection)
            SQLCommand.Parameters.Add("@HotKey", DbType.String).Value = HotKey
            Try
                SQLReader = SQLCommand.ExecuteReader
                While SQLReader.Read()
                    Listview.Items.Add(SQLReader("Message"))
                End While
                SQLReader.Close()
            Catch ex As Exception
                ExHandler.PostException(ex)
            End Try
        End Using
    End Sub
    Public Sub FetchAllRecords(ByVal Listview As ListView)
        Connection = New SQLiteConnection("Data Source=" & DatabaseName & ";Version=" & Version)
        Connection.Open()
        Query = "SELECT * FROM RESPONSES ORDER BY ID DESC"
        Using SQLCommand As New SQLiteCommand(Query, Connection)
            Try
                SQLReader = SQLCommand.ExecuteReader
                SQLCommand.Dispose()
                Listview.Items.Clear()
                While SQLReader.Read()
                    ListviewItem = New ListViewItem(CType(SQLReader(("ID")), String))
                    ListviewItem.SubItems.Add(SQLReader("Shortcut"))
                    ListviewItem.SubItems.Add(SQLReader("Message"))
                    Listview.Items.Add(ListviewItem)
                End While
                SQLReader.Close()
            Catch ex As Exception
                ExHandler.PostException(ex)
            End Try
        End Using
    End Sub
    Public Sub DeleteRecord(ByVal ID As Integer)
        Connection = New SQLiteConnection("Data Source=" & DatabaseName & ";Version=" & Version)
        Connection.Open()
        Query = "DELETE FROM RESPONSES WHERE ID=@ID"
        Using SQLCommand As New SQLiteCommand(Query, Connection)
            SQLCommand.Parameters.Add("@ID", DbType.Int16).Value = ID
            Try
                SQLCommand.ExecuteNonQuery()
            Catch ex As Exception
                ExHandler.PostException(ex)
            End Try
        End Using
    End Sub
    Public Sub UpdateRecord(ByVal ID As Integer, ByVal Shortcut As String, ByVal Message As String)
        Connection = New SQLiteConnection("Data Source=" & DatabaseName & ";Version=" & Version)
        Connection.Open()
        Query = "UPDATE RESPONSES SET Shortcut=@Shortcut, Message=@Message WHERE ID=@ID"
        Using SQLCommand As New SQLiteCommand(Query, Connection)
            SQLCommand.Parameters.Add("@ID", DbType.Int16).Value = ID
            SQLCommand.Parameters.Add("@Shortcut", DbType.String).Value = Shortcut
            SQLCommand.Parameters.Add("@Message", DbType.String).Value = Message
            Try
                SQLCommand.ExecuteNonQuery()
            Catch ex As Exception
                ExHandler.PostException(ex)
            End Try
        End Using
    End Sub
    Public Function ContainsRecord(ByVal Shortcut As String) As Boolean
        Connection = New SQLiteConnection("Data Source=" & DatabaseName & ";Version=" & Version)
        Connection.Open()
        Query = "SELECT COUNT(*) FROM RESPONSES WHERE Shortcut=@Shortcut"
        Using SQLCommand As New SQLiteCommand(Query, Connection)
            SQLCommand.Parameters.Add("@Shortcut", DbType.String).Value = Shortcut
            Try
                SQLReader = SQLCommand.ExecuteReader
                SQLCommand.Dispose()
                If SQLReader.VisibleFieldCount > 0 Then
                    Return True
                Else : Return False
                End If
            Catch ex As Exception
                ExHandler.PostException(ex)
            End Try
        End Using
        Return False
    End Function
End Class

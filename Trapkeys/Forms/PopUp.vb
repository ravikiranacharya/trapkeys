Imports System.Threading
Imports System.Runtime.InteropServices

Public Class PopUp

    Private SQLiteManager As SQLiteManager
    Private HistoryManager As HistoryManager
    Private PInvokeHelper As PInvoke

    Public Declare Function BringWindowToTop Lib "user32" (ByVal HWnd As IntPtr) As Boolean
    Private Sub PopUp_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label2.Text = ShortcutKey
        Me.ShowInTaskbar = False
        Me.TopMost = True
        SQLiteManager = New SQLiteManager("Trapkeys.sqlite", 3)
        SQLiteManager.FetchMessages(ShortcutKey, ListView1)
        BringWindowToTop(Me.Handle)
    End Sub

    Private Sub SparkButton2_Click(sender As Object, e As EventArgs) Handles SparkButton2.Click
        Me.Close()
    End Sub

    Private Sub SparkButton1_Click(sender As Object, e As EventArgs) Handles SparkButton1.Click
        AddMessage.Shortcut = ShortcutKey
        AddMessage.Message = Nothing
        AddMessage.Show()
        Me.Close()
    End Sub

    Private SendMessageThread As Thread
    Private SendHelper As SendHelper

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        SendHelper = New SendHelper(WindowHandle, ListView1.SelectedItems(0).Text)
        SendHelper.SendMessage()
        If MaintainHistory Then
            HistoryManager = New HistoryManager("Trapkeys.sqlite", 3)
            HistoryManager.InsertRecord(ShortcutKey, ListView1.SelectedItems(0).Text, Now.ToString)
            HistoryManager.FetchAllRecords(Form1.DataGridView1)
            Invoke(New MethodInvoker(Sub()
                                         Form1.Label1.Text = HistoryManager.GetMostUsedKey()
                                     End Sub))

        End If
        Me.Close()
    End Sub
End Class
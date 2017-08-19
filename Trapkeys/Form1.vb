Imports System.Threading
Imports System.Data.Sql

Public Class Form1

    Private ServerLocation As String = "http://www.myraak.in/trapkeys/updatehandle.php"

    Private SQLiteManager As SQLiteManager
    Private HistoryManager As HistoryManager
    Private PInvokeHelper As PInvoke
    Private RemoteMethods As RemoteMethods

    Private WithEvents KeyHook As New GlobalKeyboardHook

    Private Sub KeyPress_Event(ByVal e As Keys) Handles KeyHook.KeyDown
        ''Do nothing
    End Sub
    Private Sub KeyRelease_Event(ByVal e As Keys) Handles KeyHook.KeyUp
        If My.Computer.Keyboard.AltKeyDown AndAlso My.Computer.Keyboard.CtrlKeyDown Then
            If KeyHook.Feed(e) <> Nothing Then
                Console.WriteLine("Key: " & KeyHook.Feed(e))
                HandleHotKey(KeyHook.Feed(e))
            End If
        End If
    End Sub

    Private Sub HandleHotKey(ByVal Key As String)
        SQLiteManager = New SQLiteManager("Trapkeys.sqlite", 3)
        If SQLiteManager.ContainsRecord(Key) Then
            PInvokeHelper = New PInvoke
            WindowHandle = PInvokeHelper.GetFocusedWindow()
            ShortcutKey = Key
            PopUp.StartPosition = Windows.Forms.ArrangeStartingPosition.BottomRight
            PopUp.AllowTransparency = True
            PopUp.Opacity = 50
            PopUp.Show()
        End If
    End Sub

    Private Sub SparkFloatingActionButton1_Click(sender As Object, e As EventArgs) Handles SparkFloatingActionButton1.Click
        AddMessage.Show()
    End Sub

    Public Sub StartService()
        If Not IsHooked Then
            KeyHook.Hook()
            IsHooked = True
        End If
        ChangeStatus("Service is running successfully!", SparkToast.PopupStyle.Information)
    End Sub
    Public Sub StopService()
        KeyHook.Unhook()
        IsHooked = False
        ChangeStatus("Service is not running!", SparkToast.PopupStyle.Warning)
    End Sub

    Public Sub RecordHistory()
        ListView2.Items(4).Checked = True
    End Sub
    Public Sub PauseHistory()
        ListView2.Items(4).Checked = False
    End Sub
    Public Sub ClearHistory()
        If ConfirmToDelete Then
            If Not ConfirmOperation() Then
                Exit Sub
            End If
        End If
        HistoryManager.DropTable()
        HistoryManager.CreateTable()
        HistoryManager.FetchAllRecords(DataGridView1)
    End Sub

    

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Activate()
        SQLiteManager = New SQLiteManager("Trapkeys.sqlite", 3)
        SQLiteManager.CreateTable()
        SQLiteManager.FetchAllRecords(ListView1)
        PInvokeHelper = New PInvoke
        HistoryManager = New HistoryManager("Trapkeys.sqlite", 3)
        HistoryManager.FetchAllRecords(DataGridView1)
        ExHandler = New ExceptionHandler()
        If StartWithWindows Then
            StartService()
        End If
        CheckUpdates()
    End Sub

    Private IsHooked As Boolean = False
    Private Sub SparkButton1_Click(sender As Object, e As EventArgs) Handles SparkButton1.Click
        StartService()
    End Sub

    Private Sub SparkButton2_Click(sender As Object, e As EventArgs) Handles SparkButton2.Click
        StopService()
    End Sub

    Private Sub SparkButton4_Click(sender As Object, e As EventArgs) Handles SparkButton4.Click
        ClearHistory()
    End Sub

    Public Sub ChangeStatus(ByVal Status As String, ByVal Style As SparkToast.PopupStyle)
        Invoke(New MethodInvoker(Sub()
                                     SparkToast1.Style = Style
                                     SparkToast1.Text = Status
                                     NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                                     NotifyIcon1.BalloonTipText = Status
                                 End Sub))
    End Sub

    Private Sub OpenTrapkeysToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenTrapkeysToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Normal
        Me.Show()
    End Sub


    Private ExitApplication As Boolean = False
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If AlwaysShowInTaskbar Then
            Me.WindowState = FormWindowState.Minimized
            e.Cancel = True
        Else
            If Not ExitApplication Then
                Me.ShowInTaskbar = False
                e.Cancel = True
            Else
                If StartWithWindows Then
                    AddToStartup(IO.Path.GetFileNameWithoutExtension(Application.ExecutablePath), Application.ExecutablePath)
                Else
                    RemoveFromStartup(IO.Path.GetFileNameWithoutExtension(Application.ExecutablePath))
                End If
            End If
        End If
        KeyHook.Unhook()
    End Sub

    Private Sub Form1_Move(sender As Object, e As EventArgs) Handles Me.Move
        If Me.WindowState = FormWindowState.Minimized Then
            Me.ShowInTaskbar = False
            NotifyIcon1.Visible = True
            NotifyIcon1.ShowBalloonTip(5000)
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
            NotifyIcon1.BalloonTipTitle = "Title of Balloon Tip"
            NotifyIcon1.BalloonTipText = "Trapkeys service is still running from System Tray"
        End If
    End Sub
    Private Sub ExitApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitApplicationToolStripMenuItem.Click
        ExitApplication = True
        ListView2.Items(2).Checked = False
        StopService()
        Application.Exit()
    End Sub

    Private Sub StartServiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartServiceToolStripMenuItem.Click
        StartService()
    End Sub

    Private Sub StopServiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopServiceToolStripMenuItem.Click
        StopService()
    End Sub

    Private Sub RecordHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecordHistoryToolStripMenuItem.Click
        RecordHistory()
    End Sub

    Private Sub PauseHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PauseHistoryToolStripMenuItem.Click
        PauseHistory()
    End Sub

    Private Sub ClearHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearHistoryToolStripMenuItem.Click
        ClearHistory()
    End Sub

    Private Sub SparkFloatingActionButton2_Click(sender As Object, e As EventArgs) Handles SparkFloatingActionButton2.Click
        
    End Sub

    Private UpdateThread As Thread

    Public Sub CheckUpdates()
        UpdateThread = New Thread(AddressOf CheckIfUpdateIsAvailable)
        UpdateThread.Start()
    End Sub
    Public Sub CheckIfUpdateIsAvailable()
        RemoteMethods = New RemoteMethods(ServerLocation)
        Do
            If CheckUpdate Then
                If RemoteMethods.IsUpdateAvailable(Application.ExecutablePath) Then
                    If Not DownloadUpdate Then
                        Dim Choice As Integer = MessageBox.Show("An update is available!", "Update!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If Not Choice = DialogResult.Yes Then
                            Exit Sub
                        End If
                    End If
                    RemoteMethods.DownloadUpdate()
                End If
            End If
            Thread.Sleep(10000)
        Loop
    End Sub

    
    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        ContextMenuStrip1.Hide()
    End Sub

    Private Sub EditMessageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditMessageToolStripMenuItem.Click
        If ListView1.SelectedItems.Count > 0 Then
            EditMessage.ID = ListView1.SelectedItems.Item(0).Text
            EditMessage.Shortcut = ListView1.SelectedItems.Item(0).SubItems.Item(1).Text
            EditMessage.Message = ListView1.SelectedItems.Item(0).SubItems.Item(2).Text
            EditMessage.Show()
        End If
    End Sub

    Private Sub DeleteMessageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteMessageToolStripMenuItem.Click
        If ConfirmToDelete Then
            If Not ConfirmOperation() Then
                Exit Sub
            End If
        End If
        If ListView1.SelectedItems.Count > 0 Then
            SQLiteManager.DeleteRecord(ListView1.SelectedItems.Item(0).Text)
            SQLiteManager.FetchAllRecords(ListView1)
        End If
    End Sub
End Class

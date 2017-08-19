<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "Synchronize data automatically"}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "Start automatically with Windows"}, -1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "Always show in Taskbar"}, -1)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "Ask for confirmation during Delete operations"}, -1)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "Maintain history of hotkey usage"}, -1)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "Always check if update is available"}, -1)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "Download update automatically"}, -1)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "Use clipboard for quicker input (Faster but inconsistent performance)"}, -1)
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "Report exceptions automatically"}, -1)
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "Notify about more products from developer"}, -1)
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "Install sample data"}, -1)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditMessageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteMessageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenTrapkeysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ServiceStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SyncDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SyncNowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HotkeyHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecordHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PauseHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SparkForm1 = New Trapkeys.SparkForm()
        Me.SparkControlBox1 = New Trapkeys.SparkControlBox()
        Me.SparkTabControl1 = New Trapkeys.SparkTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SparkToast1 = New Trapkeys.SparkToast()
        Me.SparkButton2 = New Trapkeys.SparkButton()
        Me.SparkButton1 = New Trapkeys.SparkButton()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SparkFloatingActionButton1 = New Trapkeys.SparkFloatingActionButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SparkToast2 = New Trapkeys.SparkToast()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SparkButton4 = New Trapkeys.SparkButton()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.SparkToast3 = New Trapkeys.SparkToast()
        Me.SparkFloatingActionButton2 = New Trapkeys.SparkFloatingActionButton()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.SparkForm1.SuspendLayout()
        Me.SparkTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditMessageToolStripMenuItem, Me.DeleteMessageToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(157, 48)
        '
        'EditMessageToolStripMenuItem
        '
        Me.EditMessageToolStripMenuItem.Name = "EditMessageToolStripMenuItem"
        Me.EditMessageToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.EditMessageToolStripMenuItem.Text = "Edit Message"
        '
        'DeleteMessageToolStripMenuItem
        '
        Me.DeleteMessageToolStripMenuItem.Name = "DeleteMessageToolStripMenuItem"
        Me.DeleteMessageToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.DeleteMessageToolStripMenuItem.Text = "Delete Message"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip2
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Trapkeys Response Assistance"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenTrapkeysToolStripMenuItem, Me.ToolStripSeparator1, Me.ServiceStatusToolStripMenuItem, Me.SyncDataToolStripMenuItem, Me.HotkeyHistoryToolStripMenuItem, Me.ToolStripSeparator2, Me.ExitApplicationToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(157, 126)
        '
        'OpenTrapkeysToolStripMenuItem
        '
        Me.OpenTrapkeysToolStripMenuItem.Name = "OpenTrapkeysToolStripMenuItem"
        Me.OpenTrapkeysToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.OpenTrapkeysToolStripMenuItem.Text = "Open Trapkeys"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(153, 6)
        '
        'ServiceStatusToolStripMenuItem
        '
        Me.ServiceStatusToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartServiceToolStripMenuItem, Me.StopServiceToolStripMenuItem})
        Me.ServiceStatusToolStripMenuItem.Name = "ServiceStatusToolStripMenuItem"
        Me.ServiceStatusToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ServiceStatusToolStripMenuItem.Text = "Service Status"
        '
        'StartServiceToolStripMenuItem
        '
        Me.StartServiceToolStripMenuItem.Name = "StartServiceToolStripMenuItem"
        Me.StartServiceToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.StartServiceToolStripMenuItem.Text = "Start Service"
        '
        'StopServiceToolStripMenuItem
        '
        Me.StopServiceToolStripMenuItem.Name = "StopServiceToolStripMenuItem"
        Me.StopServiceToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.StopServiceToolStripMenuItem.Text = "Stop Service"
        '
        'SyncDataToolStripMenuItem
        '
        Me.SyncDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SyncNowToolStripMenuItem})
        Me.SyncDataToolStripMenuItem.Name = "SyncDataToolStripMenuItem"
        Me.SyncDataToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.SyncDataToolStripMenuItem.Text = "Sync Data"
        '
        'SyncNowToolStripMenuItem
        '
        Me.SyncNowToolStripMenuItem.Name = "SyncNowToolStripMenuItem"
        Me.SyncNowToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.SyncNowToolStripMenuItem.Text = "Sync now"
        '
        'HotkeyHistoryToolStripMenuItem
        '
        Me.HotkeyHistoryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecordHistoryToolStripMenuItem, Me.PauseHistoryToolStripMenuItem, Me.ClearHistoryToolStripMenuItem})
        Me.HotkeyHistoryToolStripMenuItem.Name = "HotkeyHistoryToolStripMenuItem"
        Me.HotkeyHistoryToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.HotkeyHistoryToolStripMenuItem.Text = "Hotkey History"
        '
        'RecordHistoryToolStripMenuItem
        '
        Me.RecordHistoryToolStripMenuItem.Name = "RecordHistoryToolStripMenuItem"
        Me.RecordHistoryToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RecordHistoryToolStripMenuItem.Text = "Record History"
        '
        'PauseHistoryToolStripMenuItem
        '
        Me.PauseHistoryToolStripMenuItem.Name = "PauseHistoryToolStripMenuItem"
        Me.PauseHistoryToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PauseHistoryToolStripMenuItem.Text = "Pause History"
        '
        'ClearHistoryToolStripMenuItem
        '
        Me.ClearHistoryToolStripMenuItem.Name = "ClearHistoryToolStripMenuItem"
        Me.ClearHistoryToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClearHistoryToolStripMenuItem.Text = "Clear History"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(153, 6)
        '
        'ExitApplicationToolStripMenuItem
        '
        Me.ExitApplicationToolStripMenuItem.Name = "ExitApplicationToolStripMenuItem"
        Me.ExitApplicationToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ExitApplicationToolStripMenuItem.Text = "Exit Application"
        '
        'SparkForm1
        '
        Me.SparkForm1.BackColor = System.Drawing.SystemColors.Control
        Me.SparkForm1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SparkForm1.BorderRadius = 0
        Me.SparkForm1.Controls.Add(Me.SparkControlBox1)
        Me.SparkForm1.Controls.Add(Me.SparkTabControl1)
        Me.SparkForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SparkForm1.DrawSeparator = True
        Me.SparkForm1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SparkForm1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.SparkForm1.IconRectangle = New System.Drawing.Rectangle(15, 5, 32, 32)
        Me.SparkForm1.Location = New System.Drawing.Point(0, 0)
        Me.SparkForm1.Name = "SparkForm1"
        Me.SparkForm1.SeparatorColor = System.Drawing.Color.White
        Me.SparkForm1.Size = New System.Drawing.Size(306, 423)
        Me.SparkForm1.TabIndex = 0
        Me.SparkForm1.Text = "Trapkeys"
        Me.SparkForm1.TextLocation = New System.Drawing.Point(55, 12)
        Me.SparkForm1.TopLeftColor = System.Drawing.Color.SteelBlue
        Me.SparkForm1.TopLeftRectangle = New System.Drawing.Rectangle(0, 0, 340, 40)
        Me.SparkForm1.TopRightColor = System.Drawing.Color.White
        Me.SparkForm1.TopRightRectangle = New System.Drawing.Rectangle(0, 0, 0, 40)
        '
        'SparkControlBox1
        '
        Me.SparkControlBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.SparkControlBox1.CloseColor = System.Drawing.Color.SteelBlue
        Me.SparkControlBox1.IsClosable = True
        Me.SparkControlBox1.IsMaximizable = False
        Me.SparkControlBox1.IsMinimizable = True
        Me.SparkControlBox1.Location = New System.Drawing.Point(228, 8)
        Me.SparkControlBox1.MaximizeColor = System.Drawing.Color.SteelBlue
        Me.SparkControlBox1.MinimizeColor = System.Drawing.Color.SteelBlue
        Me.SparkControlBox1.Name = "SparkControlBox1"
        Me.SparkControlBox1.Size = New System.Drawing.Size(72, 24)
        Me.SparkControlBox1.TabIndex = 1
        Me.SparkControlBox1.Text = "SparkControlBox1"
        '
        'SparkTabControl1
        '
        Me.SparkTabControl1.Controls.Add(Me.TabPage1)
        Me.SparkTabControl1.Controls.Add(Me.TabPage2)
        Me.SparkTabControl1.Controls.Add(Me.TabPage3)
        Me.SparkTabControl1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SparkTabControl1.ItemSize = New System.Drawing.Size(100, 35)
        Me.SparkTabControl1.Location = New System.Drawing.Point(1, 47)
        Me.SparkTabControl1.Name = "SparkTabControl1"
        Me.SparkTabControl1.SelectedIndex = 0
        Me.SparkTabControl1.SelectedTabColor = System.Drawing.Color.SteelBlue
        Me.SparkTabControl1.Size = New System.Drawing.Size(303, 373)
        Me.SparkTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.SparkTabControl1.TabIndex = 0
        Me.SparkTabControl1.TabItemColor = System.Drawing.Color.SteelBlue
        Me.SparkTabControl1.TabPageColor = System.Drawing.SystemColors.Control
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.SparkToast1)
        Me.TabPage1.Controls.Add(Me.SparkButton2)
        Me.TabPage1.Controls.Add(Me.SparkButton1)
        Me.TabPage1.Controls.Add(Me.ListView1)
        Me.TabPage1.Controls.Add(Me.SparkFloatingActionButton1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 39)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(295, 330)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Home"
        '
        'SparkToast1
        '
        Me.SparkToast1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.SparkToast1.Location = New System.Drawing.Point(7, 262)
        Me.SparkToast1.Name = "SparkToast1"
        Me.SparkToast1.Size = New System.Drawing.Size(226, 17)
        Me.SparkToast1.Style = Trapkeys.SparkToast.PopupStyle.Information
        Me.SparkToast1.TabIndex = 6
        Me.SparkToast1.Text = "Application loaded"
        '
        'SparkButton2
        '
        Me.SparkButton2.BackColor = System.Drawing.Color.SteelBlue
        Me.SparkButton2.BaseColor = System.Drawing.Color.Empty
        Me.SparkButton2.BorderColor = System.Drawing.Color.DodgerBlue
        Me.SparkButton2.BorderRadius = 0
        Me.SparkButton2.ButtonClickColor = System.Drawing.Color.DarkSlateGray
        Me.SparkButton2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.SparkButton2.ForeColor = System.Drawing.Color.White
        Me.SparkButton2.HoverColor = System.Drawing.Color.Teal
        Me.SparkButton2.Location = New System.Drawing.Point(107, 285)
        Me.SparkButton2.Name = "SparkButton2"
        Me.SparkButton2.Size = New System.Drawing.Size(95, 31)
        Me.SparkButton2.TabIndex = 5
        Me.SparkButton2.Text = "Stop Service"
        '
        'SparkButton1
        '
        Me.SparkButton1.BackColor = System.Drawing.Color.SteelBlue
        Me.SparkButton1.BaseColor = System.Drawing.Color.Empty
        Me.SparkButton1.BorderColor = System.Drawing.Color.DodgerBlue
        Me.SparkButton1.BorderRadius = 0
        Me.SparkButton1.ButtonClickColor = System.Drawing.Color.DarkSlateGray
        Me.SparkButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.SparkButton1.ForeColor = System.Drawing.Color.White
        Me.SparkButton1.HoverColor = System.Drawing.Color.Teal
        Me.SparkButton1.Location = New System.Drawing.Point(7, 285)
        Me.SparkButton1.Name = "SparkButton1"
        Me.SparkButton1.Size = New System.Drawing.Size(94, 31)
        Me.SparkButton1.TabIndex = 4
        Me.SparkButton1.Text = "Start Service"
        '
        'ListView1
        '
        Me.ListView1.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.ListView1.AllowColumnReorder = True
        Me.ListView1.AllowDrop = True
        Me.ListView1.BackColor = System.Drawing.Color.SteelBlue
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView1.ForeColor = System.Drawing.SystemColors.Control
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(7, 6)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.ShowItemToolTips = True
        Me.ListView1.Size = New System.Drawing.Size(282, 250)
        Me.ListView1.Sorting = System.Windows.Forms.SortOrder.Descending
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 49
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Hotkey"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 55
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Message"
        Me.ColumnHeader3.Width = 173
        '
        'SparkFloatingActionButton1
        '
        Me.SparkFloatingActionButton1.BackColor = System.Drawing.SystemColors.Highlight
        Me.SparkFloatingActionButton1.BaseColor = System.Drawing.Color.Empty
        Me.SparkFloatingActionButton1.BorderColor = System.Drawing.Color.LightGray
        Me.SparkFloatingActionButton1.BorderRadius = 50
        Me.SparkFloatingActionButton1.ButtonClickColor = System.Drawing.Color.DarkSlateGray
        Me.SparkFloatingActionButton1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SparkFloatingActionButton1.ForeColor = System.Drawing.Color.White
        Me.SparkFloatingActionButton1.HoverColor = System.Drawing.Color.Salmon
        Me.SparkFloatingActionButton1.Location = New System.Drawing.Point(239, 272)
        Me.SparkFloatingActionButton1.Name = "SparkFloatingActionButton1"
        Me.SparkFloatingActionButton1.Size = New System.Drawing.Size(50, 50)
        Me.SparkFloatingActionButton1.TabIndex = 2
        Me.SparkFloatingActionButton1.Text = "+"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.SparkToast2)
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Controls.Add(Me.SparkButton4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 39)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(295, 330)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "History"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Location = New System.Drawing.Point(131, 300)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "-"
        '
        'SparkToast2
        '
        Me.SparkToast2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.SparkToast2.Location = New System.Drawing.Point(7, 300)
        Me.SparkToast2.Name = "SparkToast2"
        Me.SparkToast2.Size = New System.Drawing.Size(124, 17)
        Me.SparkToast2.Style = Trapkeys.SparkToast.PopupStyle.Information
        Me.SparkToast2.TabIndex = 10
        Me.SparkToast2.Text = "Most used Hotkey"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.GridColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(282, 281)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 9
        '
        'SparkButton4
        '
        Me.SparkButton4.BackColor = System.Drawing.Color.SteelBlue
        Me.SparkButton4.BaseColor = System.Drawing.Color.Empty
        Me.SparkButton4.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.SparkButton4.BorderRadius = 0
        Me.SparkButton4.ButtonClickColor = System.Drawing.Color.DarkSlateGray
        Me.SparkButton4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.SparkButton4.ForeColor = System.Drawing.Color.White
        Me.SparkButton4.HoverColor = System.Drawing.Color.Teal
        Me.SparkButton4.Location = New System.Drawing.Point(174, 293)
        Me.SparkButton4.Name = "SparkButton4"
        Me.SparkButton4.Size = New System.Drawing.Size(115, 31)
        Me.SparkButton4.TabIndex = 6
        Me.SparkButton4.Text = "Clear History"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.SparkToast3)
        Me.TabPage3.Controls.Add(Me.SparkFloatingActionButton2)
        Me.TabPage3.Controls.Add(Me.ListView2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 39)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(295, 330)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Settings"
        '
        'SparkToast3
        '
        Me.SparkToast3.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.SparkToast3.Location = New System.Drawing.Point(7, 276)
        Me.SparkToast3.Name = "SparkToast3"
        Me.SparkToast3.Size = New System.Drawing.Size(188, 17)
        Me.SparkToast3.Style = Trapkeys.SparkToast.PopupStyle.Information
        Me.SparkToast3.TabIndex = 7
        Me.SparkToast3.Text = "Press the button to sync data"
        '
        'SparkFloatingActionButton2
        '
        Me.SparkFloatingActionButton2.BackColor = System.Drawing.Color.SteelBlue
        Me.SparkFloatingActionButton2.BaseColor = System.Drawing.Color.Empty
        Me.SparkFloatingActionButton2.BorderColor = System.Drawing.Color.LightGray
        Me.SparkFloatingActionButton2.BorderRadius = 50
        Me.SparkFloatingActionButton2.ButtonClickColor = System.Drawing.Color.DarkSlateGray
        Me.SparkFloatingActionButton2.Font = New System.Drawing.Font("Wingdings", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.SparkFloatingActionButton2.ForeColor = System.Drawing.Color.White
        Me.SparkFloatingActionButton2.HoverColor = System.Drawing.Color.Salmon
        Me.SparkFloatingActionButton2.Location = New System.Drawing.Point(237, 271)
        Me.SparkFloatingActionButton2.Name = "SparkFloatingActionButton2"
        Me.SparkFloatingActionButton2.Size = New System.Drawing.Size(51, 51)
        Me.SparkFloatingActionButton2.TabIndex = 5
        Me.SparkFloatingActionButton2.Text = "h"
        '
        'ListView2
        '
        Me.ListView2.AllowColumnReorder = True
        Me.ListView2.AllowDrop = True
        Me.ListView2.BackColor = System.Drawing.Color.SteelBlue
        Me.ListView2.CheckBoxes = True
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListView2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView2.ForeColor = System.Drawing.SystemColors.Control
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        ListViewItem1.StateImageIndex = 0
        ListViewItem2.Checked = True
        ListViewItem2.StateImageIndex = 1
        ListViewItem3.StateImageIndex = 0
        ListViewItem4.Checked = True
        ListViewItem4.StateImageIndex = 1
        ListViewItem5.Checked = True
        ListViewItem5.StateImageIndex = 1
        ListViewItem6.Checked = True
        ListViewItem6.StateImageIndex = 1
        ListViewItem7.StateImageIndex = 0
        ListViewItem8.StateImageIndex = 0
        ListViewItem9.Checked = True
        ListViewItem9.StateImageIndex = 1
        ListViewItem10.Checked = True
        ListViewItem10.StateImageIndex = 1
        ListViewItem11.Checked = True
        ListViewItem11.StateImageIndex = 1
        Me.ListView2.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10, ListViewItem11})
        Me.ListView2.Location = New System.Drawing.Point(6, 6)
        Me.ListView2.MultiSelect = False
        Me.ListView2.Name = "ListView2"
        Me.ListView2.ShowItemToolTips = True
        Me.ListView2.Size = New System.Drawing.Size(282, 259)
        Me.ListView2.Sorting = System.Windows.Forms.SortOrder.Descending
        Me.ListView2.TabIndex = 4
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Status"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Configuration description"
        Me.ColumnHeader8.Width = 217
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 423)
        Me.Controls.Add(Me.SparkForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = " Trapkeys"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.SparkForm1.ResumeLayout(False)
        Me.SparkTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SparkForm1 As Trapkeys.SparkForm
    Friend WithEvents SparkTabControl1 As Trapkeys.SparkTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents SparkFloatingActionButton1 As Trapkeys.SparkFloatingActionButton
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditMessageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteMessageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SparkButton2 As Trapkeys.SparkButton
    Friend WithEvents SparkButton1 As Trapkeys.SparkButton
    Friend WithEvents SparkControlBox1 As Trapkeys.SparkControlBox
    Friend WithEvents SparkButton4 As Trapkeys.SparkButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SparkToast1 As Trapkeys.SparkToast
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SparkToast2 As Trapkeys.SparkToast
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents SparkFloatingActionButton2 As Trapkeys.SparkFloatingActionButton
    Friend WithEvents SparkToast3 As Trapkeys.SparkToast
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpenTrapkeysToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServiceStatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartServiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopServiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SyncDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SyncNowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HotkeyHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecordHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PauseHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitApplicationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator

End Class

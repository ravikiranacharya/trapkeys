<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PopUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PopUp))
        Me.SparkForm1 = New Trapkeys.SparkForm()
        Me.SparkButton2 = New Trapkeys.SparkButton()
        Me.SparkButton1 = New Trapkeys.SparkButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SparkForm1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SparkForm1
        '
        Me.SparkForm1.BackColor = System.Drawing.SystemColors.Control
        Me.SparkForm1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SparkForm1.BorderRadius = 0
        Me.SparkForm1.Controls.Add(Me.SparkButton2)
        Me.SparkForm1.Controls.Add(Me.SparkButton1)
        Me.SparkForm1.Controls.Add(Me.Label2)
        Me.SparkForm1.Controls.Add(Me.Label1)
        Me.SparkForm1.Controls.Add(Me.ListView1)
        Me.SparkForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SparkForm1.DrawSeparator = True
        Me.SparkForm1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SparkForm1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.SparkForm1.IconRectangle = New System.Drawing.Rectangle(15, 3, 32, 32)
        Me.SparkForm1.Location = New System.Drawing.Point(0, 0)
        Me.SparkForm1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SparkForm1.Name = "SparkForm1"
        Me.SparkForm1.SeparatorColor = System.Drawing.Color.White
        Me.SparkForm1.Size = New System.Drawing.Size(266, 306)
        Me.SparkForm1.TabIndex = 0
        Me.SparkForm1.Text = "Trapkeys :: Assistant"
        Me.SparkForm1.TextLocation = New System.Drawing.Point(55, 10)
        Me.SparkForm1.TopLeftColor = System.Drawing.Color.SteelBlue
        Me.SparkForm1.TopLeftRectangle = New System.Drawing.Rectangle(0, 0, 320, 40)
        Me.SparkForm1.TopRightColor = System.Drawing.Color.White
        Me.SparkForm1.TopRightRectangle = New System.Drawing.Rectangle(0, 0, 0, 40)
        '
        'SparkButton2
        '
        Me.SparkButton2.BackColor = System.Drawing.Color.Coral
        Me.SparkButton2.BaseColor = System.Drawing.Color.Empty
        Me.SparkButton2.BorderColor = System.Drawing.Color.Salmon
        Me.SparkButton2.BorderRadius = 0
        Me.SparkButton2.ButtonClickColor = System.Drawing.Color.DarkSlateGray
        Me.SparkButton2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.SparkButton2.ForeColor = System.Drawing.Color.White
        Me.SparkButton2.HoverColor = System.Drawing.Color.Teal
        Me.SparkButton2.Location = New System.Drawing.Point(168, 264)
        Me.SparkButton2.Name = "SparkButton2"
        Me.SparkButton2.Size = New System.Drawing.Size(86, 30)
        Me.SparkButton2.TabIndex = 4
        Me.SparkButton2.Text = "Cancel"
        '
        'SparkButton1
        '
        Me.SparkButton1.BackColor = System.Drawing.Color.SteelBlue
        Me.SparkButton1.BaseColor = System.Drawing.Color.Empty
        Me.SparkButton1.BorderColor = System.Drawing.Color.Turquoise
        Me.SparkButton1.BorderRadius = 0
        Me.SparkButton1.ButtonClickColor = System.Drawing.Color.DarkSlateGray
        Me.SparkButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.SparkButton1.ForeColor = System.Drawing.Color.White
        Me.SparkButton1.HoverColor = System.Drawing.Color.Teal
        Me.SparkButton1.Location = New System.Drawing.Point(12, 264)
        Me.SparkButton1.Name = "SparkButton1"
        Me.SparkButton1.Size = New System.Drawing.Size(150, 30)
        Me.SparkButton1.TabIndex = 3
        Me.SparkButton1.Text = "Add Message"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Coral
        Me.Label2.Location = New System.Drawing.Point(113, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "H"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(12, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Hotkey Pressed: "
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.SteelBlue
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.ListView1.ForeColor = System.Drawing.SystemColors.Control
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(12, 78)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(242, 180)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Suggestions"
        Me.ColumnHeader1.Width = 238
        '
        'PopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 306)
        Me.Controls.Add(Me.SparkForm1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "PopUp"
        Me.Text = "Trapkeys :: Assistant"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.SparkForm1.ResumeLayout(False)
        Me.SparkForm1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SparkForm1 As Trapkeys.SparkForm
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents SparkButton2 As Trapkeys.SparkButton
    Friend WithEvents SparkButton1 As Trapkeys.SparkButton
End Class

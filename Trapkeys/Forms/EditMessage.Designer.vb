<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditMessage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditMessage))
        Me.SparkForm1 = New Trapkeys.SparkForm()
        Me.SparkButton2 = New Trapkeys.SparkButton()
        Me.SparkButton1 = New Trapkeys.SparkButton()
        Me.SparkGroupBox1 = New Trapkeys.SparkGroupBox()
        Me.SparkTextBox2 = New Trapkeys.SparkTextBox()
        Me.SparkTextBox1 = New Trapkeys.SparkTextBox()
        Me.SparkForm1.SuspendLayout()
        Me.SparkGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SparkForm1
        '
        Me.SparkForm1.AutoScroll = True
        Me.SparkForm1.BackColor = System.Drawing.SystemColors.Control
        Me.SparkForm1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SparkForm1.BorderRadius = 0
        Me.SparkForm1.Controls.Add(Me.SparkButton2)
        Me.SparkForm1.Controls.Add(Me.SparkButton1)
        Me.SparkForm1.Controls.Add(Me.SparkGroupBox1)
        Me.SparkForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SparkForm1.DrawSeparator = True
        Me.SparkForm1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SparkForm1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.SparkForm1.IconRectangle = New System.Drawing.Rectangle(15, 3, 32, 32)
        Me.SparkForm1.Location = New System.Drawing.Point(0, 0)
        Me.SparkForm1.Name = "SparkForm1"
        Me.SparkForm1.SeparatorColor = System.Drawing.Color.White
        Me.SparkForm1.Size = New System.Drawing.Size(258, 365)
        Me.SparkForm1.TabIndex = 1
        Me.SparkForm1.Text = "Trapkeys :: Edit Message"
        Me.SparkForm1.TextLocation = New System.Drawing.Point(55, 10)
        Me.SparkForm1.TopLeftColor = System.Drawing.Color.SteelBlue
        Me.SparkForm1.TopLeftRectangle = New System.Drawing.Rectangle(0, 0, 300, 40)
        Me.SparkForm1.TopRightColor = System.Drawing.Color.White
        Me.SparkForm1.TopRightRectangle = New System.Drawing.Rectangle(0, 0, 0, 40)
        '
        'SparkButton2
        '
        Me.SparkButton2.BackColor = System.Drawing.Color.SteelBlue
        Me.SparkButton2.BaseColor = System.Drawing.Color.Empty
        Me.SparkButton2.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.SparkButton2.BorderRadius = 0
        Me.SparkButton2.ButtonClickColor = System.Drawing.Color.DarkSlateGray
        Me.SparkButton2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.SparkButton2.ForeColor = System.Drawing.Color.White
        Me.SparkButton2.HoverColor = System.Drawing.Color.OrangeRed
        Me.SparkButton2.Location = New System.Drawing.Point(151, 327)
        Me.SparkButton2.Name = "SparkButton2"
        Me.SparkButton2.Size = New System.Drawing.Size(103, 26)
        Me.SparkButton2.TabIndex = 2
        Me.SparkButton2.Text = "Cancel"
        '
        'SparkButton1
        '
        Me.SparkButton1.BackColor = System.Drawing.Color.SteelBlue
        Me.SparkButton1.BaseColor = System.Drawing.Color.Empty
        Me.SparkButton1.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.SparkButton1.BorderRadius = 0
        Me.SparkButton1.ButtonClickColor = System.Drawing.Color.DarkSlateGray
        Me.SparkButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.SparkButton1.ForeColor = System.Drawing.Color.White
        Me.SparkButton1.HoverColor = System.Drawing.Color.OrangeRed
        Me.SparkButton1.Location = New System.Drawing.Point(3, 327)
        Me.SparkButton1.Name = "SparkButton1"
        Me.SparkButton1.Size = New System.Drawing.Size(135, 26)
        Me.SparkButton1.TabIndex = 1
        Me.SparkButton1.Text = "Edit Message"
        '
        'SparkGroupBox1
        '
        Me.SparkGroupBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.SparkGroupBox1.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.SparkGroupBox1.Controls.Add(Me.SparkTextBox2)
        Me.SparkGroupBox1.Controls.Add(Me.SparkTextBox1)
        Me.SparkGroupBox1.Font = New System.Drawing.Font("Candara", 10.0!)
        Me.SparkGroupBox1.ForeColor = System.Drawing.Color.White
        Me.SparkGroupBox1.Location = New System.Drawing.Point(3, 49)
        Me.SparkGroupBox1.Name = "SparkGroupBox1"
        Me.SparkGroupBox1.Size = New System.Drawing.Size(251, 271)
        Me.SparkGroupBox1.TabIndex = 0
        Me.SparkGroupBox1.TabStop = False
        '
        'SparkTextBox2
        '
        Me.SparkTextBox2.BackColor = System.Drawing.Color.White
        Me.SparkTextBox2.BaseColor = System.Drawing.Color.White
        Me.SparkTextBox2.BorderColor = System.Drawing.Color.DarkGray
        Me.SparkTextBox2.BorderRadius = 0
        Me.SparkTextBox2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
        Me.SparkTextBox2.ForeColor = System.Drawing.Color.DimGray
        Me.SparkTextBox2.Location = New System.Drawing.Point(6, 42)
        Me.SparkTextBox2.Multiline = True
        Me.SparkTextBox2.Name = "SparkTextBox2"
        Me.SparkTextBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.SparkTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.SparkTextBox2.Size = New System.Drawing.Size(239, 223)
        Me.SparkTextBox2.TabIndex = 1
        Me.SparkTextBox2.Text = "Hi! How are you today?"
        '
        'SparkTextBox1
        '
        Me.SparkTextBox1.BackColor = System.Drawing.Color.White
        Me.SparkTextBox1.BaseColor = System.Drawing.Color.White
        Me.SparkTextBox1.BorderColor = System.Drawing.Color.DarkGray
        Me.SparkTextBox1.BorderRadius = 0
        Me.SparkTextBox1.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
        Me.SparkTextBox1.ForeColor = System.Drawing.Color.DimGray
        Me.SparkTextBox1.Location = New System.Drawing.Point(6, 9)
        Me.SparkTextBox1.Name = "SparkTextBox1"
        Me.SparkTextBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.SparkTextBox1.Size = New System.Drawing.Size(239, 27)
        Me.SparkTextBox1.TabIndex = 0
        Me.SparkTextBox1.Text = "H"
        '
        'EditMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 365)
        Me.Controls.Add(Me.SparkForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditMessage"
        Me.Text = "EditMessage"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.SparkForm1.ResumeLayout(False)
        Me.SparkGroupBox1.ResumeLayout(False)
        Me.SparkGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SparkForm1 As Trapkeys.SparkForm
    Friend WithEvents SparkButton2 As Trapkeys.SparkButton
    Friend WithEvents SparkButton1 As Trapkeys.SparkButton
    Friend WithEvents SparkGroupBox1 As Trapkeys.SparkGroupBox
    Friend WithEvents SparkTextBox2 As Trapkeys.SparkTextBox
    Friend WithEvents SparkTextBox1 As Trapkeys.SparkTextBox
End Class

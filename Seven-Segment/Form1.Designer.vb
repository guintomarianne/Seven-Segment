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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.a = New System.Windows.Forms.Label()
        Me.b = New System.Windows.Forms.Label()
        Me.f = New System.Windows.Forms.Label()
        Me.g = New System.Windows.Forms.Label()
        Me.c = New System.Windows.Forms.Label()
        Me.e = New System.Windows.Forms.Label()
        Me.d = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.t = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Location = New System.Drawing.Point(24, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(258, 373)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'a
        '
        Me.a.BackColor = System.Drawing.Color.DarkRed
        Me.a.Location = New System.Drawing.Point(96, 58)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(115, 25)
        Me.a.TabIndex = 1
        '
        'b
        '
        Me.b.BackColor = System.Drawing.Color.DarkRed
        Me.b.Location = New System.Drawing.Point(217, 82)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(25, 115)
        Me.b.TabIndex = 2
        '
        'f
        '
        Me.f.BackColor = System.Drawing.Color.DarkRed
        Me.f.Location = New System.Drawing.Point(65, 82)
        Me.f.Name = "f"
        Me.f.Size = New System.Drawing.Size(25, 115)
        Me.f.TabIndex = 3
        '
        'g
        '
        Me.g.BackColor = System.Drawing.Color.DarkRed
        Me.g.Location = New System.Drawing.Point(96, 196)
        Me.g.Name = "g"
        Me.g.Size = New System.Drawing.Size(115, 25)
        Me.g.TabIndex = 4
        '
        'c
        '
        Me.c.BackColor = System.Drawing.Color.DarkRed
        Me.c.Location = New System.Drawing.Point(217, 221)
        Me.c.Name = "c"
        Me.c.Size = New System.Drawing.Size(25, 115)
        Me.c.TabIndex = 5
        '
        'e
        '
        Me.e.BackColor = System.Drawing.Color.DarkRed
        Me.e.Location = New System.Drawing.Point(65, 221)
        Me.e.Name = "e"
        Me.e.Size = New System.Drawing.Size(25, 115)
        Me.e.TabIndex = 6
        '
        'd
        '
        Me.d.BackColor = System.Drawing.Color.DarkRed
        Me.d.Location = New System.Drawing.Point(96, 336)
        Me.d.Name = "d"
        Me.d.Size = New System.Drawing.Size(115, 25)
        Me.d.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(319, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 80)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "START"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Firebrick
        Me.Button2.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(319, 221)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 80)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "STOP"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        't
        '
        Me.t.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t.Location = New System.Drawing.Point(242, 420)
        Me.t.Name = "t"
        Me.t.Size = New System.Drawing.Size(1, 1)
        Me.t.TabIndex = 10
        Me.t.Text = "0"
        '
        'Form1
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(481, 494)
        Me.Controls.Add(Me.t)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.d)
        Me.Controls.Add(Me.e)
        Me.Controls.Add(Me.c)
        Me.Controls.Add(Me.g)
        Me.Controls.Add(Me.f)
        Me.Controls.Add(Me.b)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Form1"
        Me.Text = "Seven Segment Display"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents a As Label
    Friend WithEvents b As Label
    Friend WithEvents f As Label
    Friend WithEvents g As Label
    Friend WithEvents c As Label
    Friend WithEvents e As Label
    Friend WithEvents d As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents t As Label
End Class

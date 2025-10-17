<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mail1 = New System.Windows.Forms.TextBox()
        Me.psw1 = New System.Windows.Forms.TextBox()
        Me.Go1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Vladimir Script", 19.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label1.Location = New System.Drawing.Point(209, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 65)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome back"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label2.Location = New System.Drawing.Point(44, 346)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(600, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "_________________________________________________"
        '
        'mail1
        '
        Me.mail1.Location = New System.Drawing.Point(134, 480)
        Me.mail1.Name = "mail1"
        Me.mail1.Size = New System.Drawing.Size(432, 31)
        Me.mail1.TabIndex = 3
        '
        'psw1
        '
        Me.psw1.Location = New System.Drawing.Point(134, 602)
        Me.psw1.Name = "psw1"
        Me.psw1.Size = New System.Drawing.Size(432, 31)
        Me.psw1.TabIndex = 4
        Me.psw1.UseSystemPasswordChar = True
        '
        'Go1
        '
        Me.Go1.BackColor = System.Drawing.Color.MediumPurple
        Me.Go1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Go1.Font = New System.Drawing.Font("Stencil", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Go1.ForeColor = System.Drawing.Color.GhostWhite
        Me.Go1.Location = New System.Drawing.Point(178, 731)
        Me.Go1.Name = "Go1"
        Me.Go1.Size = New System.Drawing.Size(337, 72)
        Me.Go1.TabIndex = 5
        Me.Go1.Text = "Go"
        Me.Go1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label3.Location = New System.Drawing.Point(44, 670)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(600, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "_________________________________________________"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Script", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(280, 435)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 42)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "E- mail"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe Script", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(280, 557)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 42)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Password "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe Script", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(12, 891)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(425, 42)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "You don't have account ?   |"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.MediumSlateBlue
        Me.LinkLabel1.Location = New System.Drawing.Point(443, 894)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(221, 31)
        Me.LinkLabel1.TabIndex = 10
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = " Create account !"
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.Gestion_Personnel.My.Resources.Resources.close
        Me.PictureBox2.Location = New System.Drawing.Point(653, 13)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(39, 38)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Gestion_Personnel.My.Resources.Resources.photo_2025_10_17_10_27_581
        Me.PictureBox1.Location = New System.Drawing.Point(178, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(337, 295)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(704, 966)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Go1)
        Me.Controls.Add(Me.psw1)
        Me.Controls.Add(Me.mail1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connection"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents mail1 As TextBox
    Friend WithEvents psw1 As TextBox
    Friend WithEvents Go1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PictureBox2 As PictureBox
End Class

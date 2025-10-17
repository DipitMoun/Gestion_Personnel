<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Nom2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pre2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tel2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mail3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ADelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Go3 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nom2, Me.Pre2, Me.Tel2, Me.mail3, Me.AEdit, Me.ADelete})
        Me.DataGridView1.Location = New System.Drawing.Point(440, 31)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(831, 622)
        Me.DataGridView1.TabIndex = 1
        '
        'Nom2
        '
        Me.Nom2.HeaderText = "Nom"
        Me.Nom2.Name = "Nom2"
        '
        'Pre2
        '
        Me.Pre2.HeaderText = "Prenom"
        Me.Pre2.Name = "Pre2"
        '
        'Tel2
        '
        Me.Tel2.HeaderText = "Telephone"
        Me.Tel2.Name = "Tel2"
        '
        'mail3
        '
        Me.mail3.HeaderText = "E-mail"
        Me.mail3.Name = "mail3"
        '
        'AEdit
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.GreenYellow
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.GreenYellow
        DataGridViewCellStyle11.NullValue = "EDIT"
        Me.AEdit.DefaultCellStyle = DataGridViewCellStyle11
        Me.AEdit.HeaderText = "Edit"
        Me.AEdit.Name = "AEdit"
        '
        'ADelete
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.DeepPink
        DataGridViewCellStyle12.NullValue = "DELETE"
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DeepPink
        Me.ADelete.DefaultCellStyle = DataGridViewCellStyle12
        Me.ADelete.HeaderText = "Delete"
        Me.ADelete.Name = "ADelete"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Gestion_Personnel.My.Resources.Resources.photo_2025_10_17_10_27_52
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(440, 653)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Go3
        '
        Me.Go3.BackColor = System.Drawing.Color.MediumPurple
        Me.Go3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Go3.Font = New System.Drawing.Font("Segoe Script", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Go3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Go3.Location = New System.Drawing.Point(47, 570)
        Me.Go3.Name = "Go3"
        Me.Go3.Size = New System.Drawing.Size(337, 72)
        Me.Go3.TabIndex = 15
        Me.Go3.Text = "Add user"
        Me.Go3.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.Gestion_Personnel.My.Resources.Resources.close
        Me.PictureBox2.Location = New System.Drawing.Point(1277, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(39, 38)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1328, 654)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Go3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Go3 As Button
    Friend WithEvents Nom2 As DataGridViewTextBoxColumn
    Friend WithEvents Pre2 As DataGridViewTextBoxColumn
    Friend WithEvents Tel2 As DataGridViewTextBoxColumn
    Friend WithEvents mail3 As DataGridViewTextBoxColumn
    Friend WithEvents AEdit As DataGridViewButtonColumn
    Friend WithEvents ADelete As DataGridViewButtonColumn
    Friend WithEvents PictureBox2 As PictureBox
End Class

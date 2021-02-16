<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmhora
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmhora))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.labelhora1 = New System.Windows.Forms.Label()
        Me.labelfecha = New System.Windows.Forms.Label()
        Me.timerhora = New System.Windows.Forms.Timer(Me.components)
        Me.timerfecha = New System.Windows.Forms.Timer(Me.components)
        Me.DateTimePicker12 = New System.Windows.Forms.DateTimePicker()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(522, 79)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(346, 384)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.labelhora1)
        Me.Panel1.Controls.Add(Me.labelfecha)
        Me.Panel1.Location = New System.Drawing.Point(70, 222)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(435, 150)
        Me.Panel1.TabIndex = 4
        '
        'labelhora1
        '
        Me.labelhora1.AutoSize = True
        Me.labelhora1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelhora1.ForeColor = System.Drawing.Color.White
        Me.labelhora1.Location = New System.Drawing.Point(59, 4)
        Me.labelhora1.Name = "labelhora1"
        Me.labelhora1.Size = New System.Drawing.Size(226, 73)
        Me.labelhora1.TabIndex = 2
        Me.labelhora1.Text = "Label1"
        '
        'labelfecha
        '
        Me.labelfecha.AutoSize = True
        Me.labelfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelfecha.Location = New System.Drawing.Point(39, 86)
        Me.labelfecha.Name = "labelfecha"
        Me.labelfecha.Size = New System.Drawing.Size(95, 31)
        Me.labelfecha.TabIndex = 1
        Me.labelfecha.Text = "Label1"
        '
        'timerhora
        '
        Me.timerhora.Enabled = True
        '
        'timerfecha
        '
        '
        'DateTimePicker12
        '
        Me.DateTimePicker12.Location = New System.Drawing.Point(110, 466)
        Me.DateTimePicker12.Name = "DateTimePicker12"
        Me.DateTimePicker12.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker12.TabIndex = 6
        '
        'frmhora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(820, 576)
        Me.Controls.Add(Me.DateTimePicker12)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmhora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmhora"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents labelfecha As Label
    Friend WithEvents timerhora As Timer
    Friend WithEvents timerfecha As Timer
    Friend WithEvents DateTimePicker12 As DateTimePicker
    Friend WithEvents labelhora1 As Label
End Class

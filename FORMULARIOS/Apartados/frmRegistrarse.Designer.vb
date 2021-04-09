<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistrarse
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistrarse))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPuesto = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbRol = New System.Windows.Forms.ComboBox()
        Me.Check = New System.Windows.Forms.CheckBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtfechaN = New System.Windows.Forms.DateTimePicker()
        Me.cmbSexo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcontra = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtapellidos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidempleado = New System.Windows.Forms.TextBox()
        Me.ErrorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnPuesto)
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.btnnuevo)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cmbRol)
        Me.GroupBox1.Controls.Add(Me.Check)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnguardar)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtfechaN)
        Me.GroupBox1.Controls.Add(Me.cmbSexo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtcontra)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txttelefono)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtapellidos)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtidempleado)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Location = New System.Drawing.Point(32, 78)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(924, 251)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "REGISTRO"
        '
        'btnPuesto
        '
        Me.btnPuesto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPuesto.Image = CType(resources.GetObject("btnPuesto.Image"), System.Drawing.Image)
        Me.btnPuesto.Location = New System.Drawing.Point(718, 129)
        Me.btnPuesto.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnPuesto.Name = "btnPuesto"
        Me.btnPuesto.Size = New System.Drawing.Size(43, 40)
        Me.btnPuesto.TabIndex = 36
        Me.btnPuesto.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSalir.BackgroundImage = CType(resources.GetObject("btnSalir.BackgroundImage"), System.Drawing.Image)
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.Window
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(779, 171)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(126, 63)
        Me.btnSalir.TabIndex = 35
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.SteelBlue
        Me.btnnuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnuevo.Image = CType(resources.GetObject("btnnuevo.Image"), System.Drawing.Image)
        Me.btnnuevo.Location = New System.Drawing.Point(779, 103)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(126, 64)
        Me.btnnuevo.TabIndex = 27
        Me.btnnuevo.Text = "NUEVO"
        Me.btnnuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(448, 143)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 20)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "PUESTO"
        '
        'cmbRol
        '
        Me.cmbRol.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRol.FormattingEnabled = True
        Me.cmbRol.Location = New System.Drawing.Point(585, 134)
        Me.cmbRol.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbRol.Name = "cmbRol"
        Me.cmbRol.Size = New System.Drawing.Size(129, 28)
        Me.cmbRol.TabIndex = 25
        '
        'Check
        '
        Me.Check.AutoSize = True
        Me.Check.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check.Location = New System.Drawing.Point(585, 214)
        Me.Check.Name = "Check"
        Me.Check.Size = New System.Drawing.Size(166, 20)
        Me.Check.TabIndex = 24
        Me.Check.Text = "VER CONTRASEÑA"
        Me.Check.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.txtCodigo.Location = New System.Drawing.Point(168, 22)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(70, 19)
        Me.txtCodigo.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(448, 92)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 20)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "SEXO"
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnguardar.Image = CType(resources.GetObject("btnguardar.Image"), System.Drawing.Image)
        Me.btnguardar.Location = New System.Drawing.Point(779, 34)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(126, 65)
        Me.btnguardar.TabIndex = 16
        Me.btnguardar.Text = "REGISTRAR"
        Me.btnguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(53, 188)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 20)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "FECHA N"
        '
        'txtfechaN
        '
        Me.txtfechaN.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfechaN.Location = New System.Drawing.Point(168, 182)
        Me.txtfechaN.Margin = New System.Windows.Forms.Padding(2)
        Me.txtfechaN.MaxDate = New Date(2002, 12, 31, 0, 0, 0, 0)
        Me.txtfechaN.MinDate = New Date(1950, 1, 1, 0, 0, 0, 0)
        Me.txtfechaN.Name = "txtfechaN"
        Me.txtfechaN.Size = New System.Drawing.Size(154, 26)
        Me.txtfechaN.TabIndex = 20
        Me.txtfechaN.Value = New Date(2002, 12, 31, 0, 0, 0, 0)
        '
        'cmbSexo
        '
        Me.cmbSexo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSexo.FormattingEnabled = True
        Me.cmbSexo.Items.AddRange(New Object() {"M", "F"})
        Me.cmbSexo.Location = New System.Drawing.Point(585, 88)
        Me.cmbSexo.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbSexo.Name = "cmbSexo"
        Me.cmbSexo.Size = New System.Drawing.Size(64, 28)
        Me.cmbSexo.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(448, 190)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "CONTRASEÑA"
        '
        'txtcontra
        '
        Me.txtcontra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcontra.Location = New System.Drawing.Point(585, 187)
        Me.txtcontra.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcontra.MaxLength = 8
        Me.txtcontra.Name = "txtcontra"
        Me.txtcontra.Size = New System.Drawing.Size(154, 19)
        Me.txtcontra.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(449, 50)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "TELEFONO"
        '
        'txttelefono
        '
        Me.txttelefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txttelefono.Location = New System.Drawing.Point(585, 46)
        Me.txttelefono.Margin = New System.Windows.Forms.Padding(2)
        Me.txttelefono.MaxLength = 8
        Me.txttelefono.Multiline = True
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(154, 23)
        Me.txttelefono.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 143)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "APELLIDOS"
        '
        'txtapellidos
        '
        Me.txtapellidos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtapellidos.Location = New System.Drawing.Point(168, 139)
        Me.txtapellidos.Margin = New System.Windows.Forms.Padding(2)
        Me.txtapellidos.Multiline = True
        Me.txtapellidos.Name = "txtapellidos"
        Me.txtapellidos.Size = New System.Drawing.Size(154, 23)
        Me.txtapellidos.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 96)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "NOMBRES"
        '
        'txtnombre
        '
        Me.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnombre.Location = New System.Drawing.Point(168, 93)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnombre.Multiline = True
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(154, 23)
        Me.txtnombre.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "IDENTIDAD"
        '
        'txtidempleado
        '
        Me.txtidempleado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtidempleado.Location = New System.Drawing.Point(168, 46)
        Me.txtidempleado.Margin = New System.Windows.Forms.Padding(2)
        Me.txtidempleado.MaxLength = 13
        Me.txtidempleado.Multiline = True
        Me.txtidempleado.Name = "txtidempleado"
        Me.txtidempleado.Size = New System.Drawing.Size(154, 23)
        Me.txtidempleado.TabIndex = 0
        '
        'ErrorValidacion
        '
        Me.ErrorValidacion.ContainerControl = Me
        '
        'frmRegistrarse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 421)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegistrarse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRegistrarse"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbRol As ComboBox
    Friend WithEvents Check As CheckBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnguardar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtfechaN As DateTimePicker
    Friend WithEvents cmbSexo As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtcontra As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtapellidos As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtidempleado As TextBox
    Friend WithEvents btnnuevo As Button
    Friend WithEvents ErrorValidacion As ErrorProvider
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnPuesto As Button
    Friend WithEvents ToolTip As ToolTip
End Class

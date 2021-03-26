<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menuu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menuu))
        Me.BarraTitulo = New System.Windows.Forms.Panel()
        Me.txtflag = New System.Windows.Forms.TextBox()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.MenuVertical = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btncompras = New System.Windows.Forms.Button()
        Me.btnproveedor = New System.Windows.Forms.Button()
        Me.btnclientes = New System.Windows.Forms.Button()
        Me.btnempleados = New System.Windows.Forms.Button()
        Me.btncategoria = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnproductos = New System.Windows.Forms.Button()
        Me.lproveedor = New System.Windows.Forms.Panel()
        Me.lempleado = New System.Windows.Forms.Panel()
        Me.lcompras = New System.Windows.Forms.Panel()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.btnventas = New System.Windows.Forms.Button()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.panel4 = New System.Windows.Forms.Panel()
        Me.panel7 = New System.Windows.Forms.Panel()
        Me.PanelForms = New System.Windows.Forms.Panel()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.BarraTitulo.SuspendLayout()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuVertical.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarraTitulo
        '
        Me.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BarraTitulo.Controls.Add(Me.txtflag)
        Me.BarraTitulo.Controls.Add(Me.btnMinimizar)
        Me.BarraTitulo.Controls.Add(Me.btnCerrar)
        Me.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.BarraTitulo.Margin = New System.Windows.Forms.Padding(4)
        Me.BarraTitulo.Name = "BarraTitulo"
        Me.BarraTitulo.Size = New System.Drawing.Size(1387, 46)
        Me.BarraTitulo.TabIndex = 7
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(1596, 26)
        Me.txtflag.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(20, 22)
        Me.txtflag.TabIndex = 31
        Me.txtflag.Text = "0"
        Me.txtflag.Visible = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(1295, 7)
        Me.btnMinimizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(35, 30)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMinimizar.TabIndex = 2
        Me.btnMinimizar.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(1336, 7)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(35, 30)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.TabStop = False
        '
        'MenuVertical
        '
        Me.MenuVertical.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.MenuVertical.Controls.Add(Me.Panel3)
        Me.MenuVertical.Controls.Add(Me.btncompras)
        Me.MenuVertical.Controls.Add(Me.btnproveedor)
        Me.MenuVertical.Controls.Add(Me.btnclientes)
        Me.MenuVertical.Controls.Add(Me.btnempleados)
        Me.MenuVertical.Controls.Add(Me.btncategoria)
        Me.MenuVertical.Controls.Add(Me.Button1)
        Me.MenuVertical.Controls.Add(Me.PictureBox1)
        Me.MenuVertical.Controls.Add(Me.Panel9)
        Me.MenuVertical.Controls.Add(Me.btnproductos)
        Me.MenuVertical.Controls.Add(Me.lproveedor)
        Me.MenuVertical.Controls.Add(Me.lempleado)
        Me.MenuVertical.Controls.Add(Me.lcompras)
        Me.MenuVertical.Controls.Add(Me.panel2)
        Me.MenuVertical.Controls.Add(Me.btnventas)
        Me.MenuVertical.Controls.Add(Me.panel1)
        Me.MenuVertical.Controls.Add(Me.panel4)
        Me.MenuVertical.Controls.Add(Me.panel7)
        Me.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuVertical.Location = New System.Drawing.Point(0, 46)
        Me.MenuVertical.Margin = New System.Windows.Forms.Padding(4)
        Me.MenuVertical.Name = "MenuVertical"
        Me.MenuVertical.Size = New System.Drawing.Size(285, 708)
        Me.MenuVertical.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblApellidos)
        Me.Panel3.Controls.Add(Me.lblNombres)
        Me.Panel3.Controls.Add(Me.lblCargo)
        Me.Panel3.Controls.Add(Me.lbl2)
        Me.Panel3.Controls.Add(Me.lbl1)
        Me.Panel3.Controls.Add(Me.lbl)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Location = New System.Drawing.Point(0, 106)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(285, 108)
        Me.Panel3.TabIndex = 17
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl2.Location = New System.Drawing.Point(107, 69)
        Me.lbl2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(69, 17)
        Me.lbl2.TabIndex = 3
        Me.lbl2.Text = "Apellidos:"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl1.Location = New System.Drawing.Point(107, 47)
        Me.lbl1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(69, 17)
        Me.lbl1.TabIndex = 2
        Me.lbl1.Text = "Nombres:"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl.Location = New System.Drawing.Point(107, 26)
        Me.lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(50, 17)
        Me.lbl.TabIndex = 1
        Me.lbl.Text = "Cargo:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Proyecto.My.Resources.Resources.user__1_
        Me.PictureBox2.Location = New System.Drawing.Point(12, 20)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(84, 65)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'btncompras
        '
        Me.btncompras.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btncompras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncompras.FlatAppearance.BorderSize = 0
        Me.btncompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btncompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncompras.ForeColor = System.Drawing.Color.White
        Me.btncompras.Image = CType(resources.GetObject("btncompras.Image"), System.Drawing.Image)
        Me.btncompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncompras.Location = New System.Drawing.Point(8, 607)
        Me.btncompras.Margin = New System.Windows.Forms.Padding(4)
        Me.btncompras.Name = "btncompras"
        Me.btncompras.Size = New System.Drawing.Size(285, 66)
        Me.btncompras.TabIndex = 7
        Me.btncompras.Text = "Compras"
        Me.btncompras.UseVisualStyleBackColor = False
        '
        'btnproveedor
        '
        Me.btnproveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnproveedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnproveedor.FlatAppearance.BorderSize = 0
        Me.btnproveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnproveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnproveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnproveedor.ForeColor = System.Drawing.Color.White
        Me.btnproveedor.Image = CType(resources.GetObject("btnproveedor.Image"), System.Drawing.Image)
        Me.btnproveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnproveedor.Location = New System.Drawing.Point(8, 540)
        Me.btnproveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.btnproveedor.Name = "btnproveedor"
        Me.btnproveedor.Size = New System.Drawing.Size(285, 66)
        Me.btnproveedor.TabIndex = 15
        Me.btnproveedor.Text = "Proveedor"
        Me.btnproveedor.UseVisualStyleBackColor = False
        '
        'btnclientes
        '
        Me.btnclientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnclientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclientes.FlatAppearance.BorderSize = 0
        Me.btnclientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclientes.ForeColor = System.Drawing.Color.White
        Me.btnclientes.Image = CType(resources.GetObject("btnclientes.Image"), System.Drawing.Image)
        Me.btnclientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclientes.Location = New System.Drawing.Point(8, 474)
        Me.btnclientes.Margin = New System.Windows.Forms.Padding(4)
        Me.btnclientes.Name = "btnclientes"
        Me.btnclientes.Size = New System.Drawing.Size(285, 66)
        Me.btnclientes.TabIndex = 5
        Me.btnclientes.Text = "Clientes"
        Me.btnclientes.UseVisualStyleBackColor = False
        '
        'btnempleados
        '
        Me.btnempleados.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnempleados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnempleados.FlatAppearance.BorderSize = 0
        Me.btnempleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnempleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnempleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnempleados.ForeColor = System.Drawing.Color.White
        Me.btnempleados.Image = CType(resources.GetObject("btnempleados.Image"), System.Drawing.Image)
        Me.btnempleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnempleados.Location = New System.Drawing.Point(8, 407)
        Me.btnempleados.Margin = New System.Windows.Forms.Padding(4)
        Me.btnempleados.Name = "btnempleados"
        Me.btnempleados.Size = New System.Drawing.Size(285, 66)
        Me.btnempleados.TabIndex = 9
        Me.btnempleados.Text = "Empleados"
        Me.btnempleados.UseVisualStyleBackColor = False
        '
        'btncategoria
        '
        Me.btncategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btncategoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncategoria.FlatAppearance.BorderSize = 0
        Me.btncategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btncategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncategoria.ForeColor = System.Drawing.Color.White
        Me.btncategoria.Image = CType(resources.GetObject("btncategoria.Image"), System.Drawing.Image)
        Me.btncategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncategoria.Location = New System.Drawing.Point(8, 343)
        Me.btncategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.btncategoria.Name = "btncategoria"
        Me.btncategoria.Size = New System.Drawing.Size(291, 66)
        Me.btncategoria.TabIndex = 11
        Me.btncategoria.Text = "Categoría"
        Me.btncategoria.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(8, 677)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(291, 53)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Cerrar Sesion"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(63, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel9.Location = New System.Drawing.Point(0, 677)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(52, 53)
        Me.Panel9.TabIndex = 11
        '
        'btnproductos
        '
        Me.btnproductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnproductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnproductos.FlatAppearance.BorderSize = 0
        Me.btnproductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnproductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnproductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnproductos.ForeColor = System.Drawing.Color.White
        Me.btnproductos.Image = CType(resources.GetObject("btnproductos.Image"), System.Drawing.Image)
        Me.btnproductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnproductos.Location = New System.Drawing.Point(8, 281)
        Me.btnproductos.Margin = New System.Windows.Forms.Padding(4)
        Me.btnproductos.Name = "btnproductos"
        Me.btnproductos.Size = New System.Drawing.Size(285, 66)
        Me.btnproductos.TabIndex = 1
        Me.btnproductos.Text = "Productos"
        Me.btnproductos.UseVisualStyleBackColor = False
        '
        'lproveedor
        '
        Me.lproveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.lproveedor.Location = New System.Drawing.Point(-5, 540)
        Me.lproveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.lproveedor.Name = "lproveedor"
        Me.lproveedor.Size = New System.Drawing.Size(20, 66)
        Me.lproveedor.TabIndex = 11
        '
        'lempleado
        '
        Me.lempleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.lempleado.Location = New System.Drawing.Point(-1, 474)
        Me.lempleado.Margin = New System.Windows.Forms.Padding(4)
        Me.lempleado.Name = "lempleado"
        Me.lempleado.Size = New System.Drawing.Size(29, 66)
        Me.lempleado.TabIndex = 12
        '
        'lcompras
        '
        Me.lcompras.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.lcompras.Location = New System.Drawing.Point(-4, 607)
        Me.lcompras.Margin = New System.Windows.Forms.Padding(4)
        Me.lcompras.Name = "lcompras"
        Me.lcompras.Size = New System.Drawing.Size(19, 66)
        Me.lcompras.TabIndex = 10
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.panel2.Location = New System.Drawing.Point(-5, 281)
        Me.panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(33, 66)
        Me.panel2.TabIndex = 4
        '
        'btnventas
        '
        Me.btnventas.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnventas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnventas.FlatAppearance.BorderSize = 0
        Me.btnventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnventas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnventas.ForeColor = System.Drawing.Color.White
        Me.btnventas.Image = CType(resources.GetObject("btnventas.Image"), System.Drawing.Image)
        Me.btnventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnventas.Location = New System.Drawing.Point(8, 213)
        Me.btnventas.Margin = New System.Windows.Forms.Padding(4)
        Me.btnventas.Name = "btnventas"
        Me.btnventas.Size = New System.Drawing.Size(291, 66)
        Me.btnventas.TabIndex = 3
        Me.btnventas.Text = "     Ventas"
        Me.btnventas.UseVisualStyleBackColor = False
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.panel1.Location = New System.Drawing.Point(0, 214)
        Me.panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(13, 66)
        Me.panel1.TabIndex = 2
        '
        'panel4
        '
        Me.panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.panel4.Location = New System.Drawing.Point(0, 347)
        Me.panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.panel4.Name = "panel4"
        Me.panel4.Size = New System.Drawing.Size(15, 60)
        Me.panel4.TabIndex = 8
        '
        'panel7
        '
        Me.panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.panel7.Location = New System.Drawing.Point(0, 407)
        Me.panel7.Margin = New System.Windows.Forms.Padding(4)
        Me.panel7.Name = "panel7"
        Me.panel7.Size = New System.Drawing.Size(15, 66)
        Me.panel7.TabIndex = 14
        '
        'PanelForms
        '
        Me.PanelForms.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.PanelForms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelForms.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.PanelForms.Location = New System.Drawing.Point(285, 46)
        Me.PanelForms.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelForms.Name = "PanelForms"
        Me.PanelForms.Size = New System.Drawing.Size(1102, 708)
        Me.PanelForms.TabIndex = 9
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCargo.Location = New System.Drawing.Point(155, 26)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(12, 17)
        Me.lblCargo.TabIndex = 0
        Me.lblCargo.Text = "."
        '
        'lblNombres
        '
        Me.lblNombres.AutoSize = True
        Me.lblNombres.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNombres.Location = New System.Drawing.Point(174, 47)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(12, 17)
        Me.lblNombres.TabIndex = 4
        Me.lblNombres.Text = "."
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblApellidos.Location = New System.Drawing.Point(174, 69)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(12, 17)
        Me.lblApellidos.TabIndex = 5
        Me.lblApellidos.Text = "."
        '
        'Menuu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1387, 754)
        Me.Controls.Add(Me.PanelForms)
        Me.Controls.Add(Me.MenuVertical)
        Me.Controls.Add(Me.BarraTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Menuu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.BarraTitulo.ResumeLayout(False)
        Me.BarraTitulo.PerformLayout()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuVertical.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents btnMinimizar As PictureBox
    Private WithEvents btnCerrar As PictureBox
    Private WithEvents BarraTitulo As Panel
    Friend WithEvents txtflag As TextBox
    Private WithEvents MenuVertical As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Private WithEvents Panel9 As Panel
    Private WithEvents Button1 As Button
    Private WithEvents btnproveedor As Button
    Private WithEvents btnproductos As Button
    Private WithEvents lempleado As Panel
    Private WithEvents btncategoria As Button
    Private WithEvents lcompras As Panel
    Private WithEvents btnempleados As Button
    Private WithEvents btncompras As Button
    Private WithEvents btnclientes As Button
    Private WithEvents panel2 As Panel
    Private WithEvents btnventas As Button
    Private WithEvents panel1 As Panel
    Private WithEvents panel4 As Panel
    Private WithEvents panel7 As Panel
    Friend WithEvents PanelForms As Panel
    Private WithEvents lproveedor As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl As Label
    Friend WithEvents lblCargo As Label
    Friend WithEvents lblApellidos As Label
    Friend WithEvents lblNombres As Label
End Class

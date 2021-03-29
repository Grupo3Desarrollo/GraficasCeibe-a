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
        Me.btnclientes = New System.Windows.Forms.Button()
        Me.lemCliente = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btncompras = New System.Windows.Forms.Button()
        Me.btnproveedor = New System.Windows.Forms.Button()
        Me.btnempleados = New System.Windows.Forms.Button()
        Me.btncategoria = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnproductos = New System.Windows.Forms.Button()
        Me.lproveedor = New System.Windows.Forms.Panel()
        Me.lcompras = New System.Windows.Forms.Panel()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.btnventas = New System.Windows.Forms.Button()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.panel4 = New System.Windows.Forms.Panel()
        Me.lempleado = New System.Windows.Forms.Panel()
        Me.PanelForms = New System.Windows.Forms.Panel()
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
        Me.BarraTitulo.Name = "BarraTitulo"
        Me.BarraTitulo.Size = New System.Drawing.Size(1040, 37)
        Me.BarraTitulo.TabIndex = 7
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(1197, 21)
        Me.txtflag.Margin = New System.Windows.Forms.Padding(2)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(16, 20)
        Me.txtflag.TabIndex = 31
        Me.txtflag.Text = "0"
        Me.txtflag.Visible = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(971, 6)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(26, 24)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMinimizar.TabIndex = 2
        Me.btnMinimizar.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(1002, 6)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(26, 24)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.TabStop = False
        '
        'MenuVertical
        '
        Me.MenuVertical.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.MenuVertical.Controls.Add(Me.btnclientes)
        Me.MenuVertical.Controls.Add(Me.lemCliente)
        Me.MenuVertical.Controls.Add(Me.Panel3)
        Me.MenuVertical.Controls.Add(Me.btncompras)
        Me.MenuVertical.Controls.Add(Me.btnproveedor)
        Me.MenuVertical.Controls.Add(Me.btnempleados)
        Me.MenuVertical.Controls.Add(Me.btncategoria)
        Me.MenuVertical.Controls.Add(Me.Button1)
        Me.MenuVertical.Controls.Add(Me.PictureBox1)
        Me.MenuVertical.Controls.Add(Me.Panel9)
        Me.MenuVertical.Controls.Add(Me.btnproductos)
        Me.MenuVertical.Controls.Add(Me.lproveedor)
        Me.MenuVertical.Controls.Add(Me.lcompras)
        Me.MenuVertical.Controls.Add(Me.panel2)
        Me.MenuVertical.Controls.Add(Me.btnventas)
        Me.MenuVertical.Controls.Add(Me.panel1)
        Me.MenuVertical.Controls.Add(Me.panel4)
        Me.MenuVertical.Controls.Add(Me.lempleado)
        Me.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuVertical.Location = New System.Drawing.Point(0, 37)
        Me.MenuVertical.Name = "MenuVertical"
        Me.MenuVertical.Size = New System.Drawing.Size(214, 576)
        Me.MenuVertical.TabIndex = 8
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
        Me.btnclientes.Location = New System.Drawing.Point(7, 330)
        Me.btnclientes.Name = "btnclientes"
        Me.btnclientes.Size = New System.Drawing.Size(214, 54)
        Me.btnclientes.TabIndex = 5
        Me.btnclientes.Text = "Clientes"
        Me.btnclientes.UseVisualStyleBackColor = False
        '
        'lemCliente
        '
        Me.lemCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.lemCliente.Location = New System.Drawing.Point(-3, 331)
        Me.lemCliente.Name = "lemCliente"
        Me.lemCliente.Size = New System.Drawing.Size(11, 54)
        Me.lemCliente.TabIndex = 12
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
        Me.Panel3.Location = New System.Drawing.Point(0, 86)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(214, 88)
        Me.Panel3.TabIndex = 17
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblApellidos.Location = New System.Drawing.Point(130, 56)
        Me.lblApellidos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(10, 13)
        Me.lblApellidos.TabIndex = 5
        Me.lblApellidos.Text = "."
        '
        'lblNombres
        '
        Me.lblNombres.AutoSize = True
        Me.lblNombres.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNombres.Location = New System.Drawing.Point(130, 38)
        Me.lblNombres.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(10, 13)
        Me.lblNombres.TabIndex = 4
        Me.lblNombres.Text = "."
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCargo.Location = New System.Drawing.Point(116, 21)
        Me.lblCargo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(10, 13)
        Me.lblCargo.TabIndex = 0
        Me.lblCargo.Text = "."
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl2.Location = New System.Drawing.Point(80, 56)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(52, 13)
        Me.lbl2.TabIndex = 3
        Me.lbl2.Text = "Apellidos:"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl1.Location = New System.Drawing.Point(80, 38)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(52, 13)
        Me.lbl1.TabIndex = 2
        Me.lbl1.Text = "Nombres:"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl.Location = New System.Drawing.Point(80, 21)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(38, 13)
        Me.lbl.TabIndex = 1
        Me.lbl.Text = "Cargo:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Proyecto.My.Resources.Resources.user__1_
        Me.PictureBox2.Location = New System.Drawing.Point(9, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(63, 53)
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
        Me.btncompras.Location = New System.Drawing.Point(6, 493)
        Me.btncompras.Name = "btncompras"
        Me.btncompras.Size = New System.Drawing.Size(214, 54)
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
        Me.btnproveedor.Location = New System.Drawing.Point(6, 439)
        Me.btnproveedor.Name = "btnproveedor"
        Me.btnproveedor.Size = New System.Drawing.Size(214, 54)
        Me.btnproveedor.TabIndex = 15
        Me.btnproveedor.Text = "Proveedor"
        Me.btnproveedor.UseVisualStyleBackColor = False
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
        Me.btnempleados.Location = New System.Drawing.Point(7, 385)
        Me.btnempleados.Name = "btnempleados"
        Me.btnempleados.Size = New System.Drawing.Size(214, 54)
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
        Me.btncategoria.Location = New System.Drawing.Point(6, 279)
        Me.btncategoria.Name = "btncategoria"
        Me.btncategoria.Size = New System.Drawing.Size(218, 54)
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
        Me.Button1.Location = New System.Drawing.Point(6, 550)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(218, 43)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Cerrar Sesion"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(47, 8)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel9.Location = New System.Drawing.Point(0, 550)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(39, 43)
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
        Me.btnproductos.Location = New System.Drawing.Point(6, 228)
        Me.btnproductos.Name = "btnproductos"
        Me.btnproductos.Size = New System.Drawing.Size(214, 54)
        Me.btnproductos.TabIndex = 1
        Me.btnproductos.Text = "Productos"
        Me.btnproductos.UseVisualStyleBackColor = False
        '
        'lproveedor
        '
        Me.lproveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.lproveedor.Location = New System.Drawing.Point(-4, 439)
        Me.lproveedor.Name = "lproveedor"
        Me.lproveedor.Size = New System.Drawing.Size(15, 54)
        Me.lproveedor.TabIndex = 11
        '
        'lcompras
        '
        Me.lcompras.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.lcompras.Location = New System.Drawing.Point(-3, 493)
        Me.lcompras.Name = "lcompras"
        Me.lcompras.Size = New System.Drawing.Size(14, 54)
        Me.lcompras.TabIndex = 10
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.panel2.Location = New System.Drawing.Point(-4, 228)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(25, 54)
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
        Me.btnventas.Location = New System.Drawing.Point(6, 173)
        Me.btnventas.Name = "btnventas"
        Me.btnventas.Size = New System.Drawing.Size(218, 55)
        Me.btnventas.TabIndex = 3
        Me.btnventas.Text = "     Ventas"
        Me.btnventas.UseVisualStyleBackColor = False
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.panel1.Location = New System.Drawing.Point(0, 174)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(10, 54)
        Me.panel1.TabIndex = 2
        '
        'panel4
        '
        Me.panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.panel4.Location = New System.Drawing.Point(0, 282)
        Me.panel4.Name = "panel4"
        Me.panel4.Size = New System.Drawing.Size(11, 49)
        Me.panel4.TabIndex = 8
        '
        'lempleado
        '
        Me.lempleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.lempleado.Location = New System.Drawing.Point(0, 385)
        Me.lempleado.Name = "lempleado"
        Me.lempleado.Size = New System.Drawing.Size(11, 54)
        Me.lempleado.TabIndex = 14
        '
        'PanelForms
        '
        Me.PanelForms.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.PanelForms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelForms.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.PanelForms.Location = New System.Drawing.Point(214, 37)
        Me.PanelForms.Name = "PanelForms"
        Me.PanelForms.Size = New System.Drawing.Size(826, 576)
        Me.PanelForms.TabIndex = 9
        '
        'Menuu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 613)
        Me.Controls.Add(Me.PanelForms)
        Me.Controls.Add(Me.MenuVertical)
        Me.Controls.Add(Me.BarraTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Menuu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
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
    Private WithEvents lemCliente As Panel
    Private WithEvents btncategoria As Button
    Private WithEvents lcompras As Panel
    Private WithEvents btnempleados As Button
    Private WithEvents btncompras As Button
    Private WithEvents btnclientes As Button
    Private WithEvents panel2 As Panel
    Private WithEvents btnventas As Button
    Private WithEvents panel1 As Panel
    Private WithEvents panel4 As Panel
    Private WithEvents lempleado As Panel
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

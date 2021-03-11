<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompras))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnbuscarPro = New System.Windows.Forms.Button()
        Me.txtcantidad = New System.Windows.Forms.NumericUpDown()
        Me.txtprecio_compra = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnBuscarProducto = New System.Windows.Forms.Button()
        Me.txtnom_producto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtidproducto = New System.Windows.Forms.TextBox()
        Me.txtfechaCompra = New System.Windows.Forms.DateTimePicker()
        Me.txtnombre_proveedor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtidproveedor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidcompra = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtcantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnbuscarPro)
        Me.GroupBox1.Controls.Add(Me.txtcantidad)
        Me.GroupBox1.Controls.Add(Me.txtprecio_compra)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnBuscarProducto)
        Me.GroupBox1.Controls.Add(Me.txtnom_producto)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtidproducto)
        Me.GroupBox1.Controls.Add(Me.txtfechaCompra)
        Me.GroupBox1.Controls.Add(Me.txtnombre_proveedor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtidproveedor)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtidcompra)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Location = New System.Drawing.Point(29, 79)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(406, 422)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DE COMPRA"
        '
        'btnbuscarPro
        '
        Me.btnbuscarPro.Image = CType(resources.GetObject("btnbuscarPro.Image"), System.Drawing.Image)
        Me.btnbuscarPro.Location = New System.Drawing.Point(340, 114)
        Me.btnbuscarPro.Margin = New System.Windows.Forms.Padding(2)
        Me.btnbuscarPro.Name = "btnbuscarPro"
        Me.btnbuscarPro.Size = New System.Drawing.Size(40, 30)
        Me.btnbuscarPro.TabIndex = 31
        Me.btnbuscarPro.UseVisualStyleBackColor = True
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(141, 280)
        Me.txtcantidad.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcantidad.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.ReadOnly = True
        Me.txtcantidad.Size = New System.Drawing.Size(80, 26)
        Me.txtcantidad.TabIndex = 29
        '
        'txtprecio_compra
        '
        Me.txtprecio_compra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtprecio_compra.Location = New System.Drawing.Point(140, 343)
        Me.txtprecio_compra.Margin = New System.Windows.Forms.Padding(2)
        Me.txtprecio_compra.MaxLength = 9
        Me.txtprecio_compra.Name = "txtprecio_compra"
        Me.txtprecio_compra.ReadOnly = True
        Me.txtprecio_compra.Size = New System.Drawing.Size(81, 19)
        Me.txtprecio_compra.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 343)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 20)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "PRECIO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 284)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 20)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "CANTIDAD"
        '
        'btnBuscarProducto
        '
        Me.btnBuscarProducto.Image = CType(resources.GetObject("btnBuscarProducto.Image"), System.Drawing.Image)
        Me.btnBuscarProducto.Location = New System.Drawing.Point(340, 227)
        Me.btnBuscarProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscarProducto.Name = "btnBuscarProducto"
        Me.btnBuscarProducto.Size = New System.Drawing.Size(40, 30)
        Me.btnBuscarProducto.TabIndex = 24
        Me.btnBuscarProducto.UseVisualStyleBackColor = True
        '
        'txtnom_producto
        '
        Me.txtnom_producto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnom_producto.Location = New System.Drawing.Point(173, 233)
        Me.txtnom_producto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnom_producto.Name = "txtnom_producto"
        Me.txtnom_producto.ReadOnly = True
        Me.txtnom_producto.Size = New System.Drawing.Size(158, 19)
        Me.txtnom_producto.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 232)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 20)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "PRODUCTO"
        '
        'txtidproducto
        '
        Me.txtidproducto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtidproducto.Location = New System.Drawing.Point(141, 233)
        Me.txtidproducto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtidproducto.Name = "txtidproducto"
        Me.txtidproducto.ReadOnly = True
        Me.txtidproducto.Size = New System.Drawing.Size(28, 19)
        Me.txtidproducto.TabIndex = 21
        '
        'txtfechaCompra
        '
        Me.txtfechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfechaCompra.Location = New System.Drawing.Point(141, 176)
        Me.txtfechaCompra.Margin = New System.Windows.Forms.Padding(2)
        Me.txtfechaCompra.MaxDate = New Date(2020, 8, 4, 0, 0, 0, 0)
        Me.txtfechaCompra.MinDate = New Date(2020, 8, 4, 0, 0, 0, 0)
        Me.txtfechaCompra.Name = "txtfechaCompra"
        Me.txtfechaCompra.Size = New System.Drawing.Size(191, 26)
        Me.txtfechaCompra.TabIndex = 19
        Me.txtfechaCompra.TabStop = False
        Me.txtfechaCompra.Value = New Date(2020, 8, 4, 0, 0, 0, 0)
        '
        'txtnombre_proveedor
        '
        Me.txtnombre_proveedor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnombre_proveedor.Location = New System.Drawing.Point(173, 119)
        Me.txtnombre_proveedor.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnombre_proveedor.Name = "txtnombre_proveedor"
        Me.txtnombre_proveedor.ReadOnly = True
        Me.txtnombre_proveedor.Size = New System.Drawing.Size(158, 19)
        Me.txtnombre_proveedor.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 180)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "FECHA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 119)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "PROVEEDOR"
        '
        'txtidproveedor
        '
        Me.txtidproveedor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtidproveedor.Location = New System.Drawing.Point(141, 119)
        Me.txtidproveedor.Margin = New System.Windows.Forms.Padding(2)
        Me.txtidproveedor.Name = "txtidproveedor"
        Me.txtidproveedor.ReadOnly = True
        Me.txtidproveedor.Size = New System.Drawing.Size(28, 19)
        Me.txtidproveedor.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 57)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID COMPRA"
        '
        'txtidcompra
        '
        Me.txtidcompra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtidcompra.Location = New System.Drawing.Point(141, 57)
        Me.txtidcompra.Margin = New System.Windows.Forms.Padding(2)
        Me.txtidcompra.Name = "txtidcompra"
        Me.txtidcompra.ReadOnly = True
        Me.txtidcompra.Size = New System.Drawing.Size(189, 19)
        Me.txtidcompra.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnguardar)
        Me.GroupBox2.Controls.Add(Me.inexistente)
        Me.GroupBox2.Controls.Add(Me.btnnuevo)
        Me.GroupBox2.Controls.Add(Me.datalistado)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox2.Location = New System.Drawing.Point(461, 79)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(559, 422)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LISTA DE ARTICULOS"
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.SystemColors.Window
        Me.btnguardar.Image = CType(resources.GetObject("btnguardar.Image"), System.Drawing.Image)
        Me.btnguardar.Location = New System.Drawing.Point(440, 249)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(108, 67)
        Me.btnguardar.TabIndex = 28
        Me.btnguardar.Text = "GUARDAR"
        Me.btnguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(188, 119)
        Me.inexistente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(160, 20)
        Me.inexistente.TabIndex = 18
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "Datos Inexistentes"
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.SteelBlue
        Me.btnnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.ForeColor = System.Drawing.SystemColors.Window
        Me.btnnuevo.Image = CType(resources.GetObject("btnnuevo.Image"), System.Drawing.Image)
        Me.btnnuevo.Location = New System.Drawing.Point(300, 249)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(104, 67)
        Me.btnnuevo.TabIndex = 26
        Me.btnnuevo.Text = "NUEVO"
        Me.btnnuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.datalistado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.datalistado.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.datalistado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datalistado.ColumnHeadersHeight = 38
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datalistado.DefaultCellStyle = DataGridViewCellStyle2
        Me.datalistado.EnableHeadersVisualStyles = False
        Me.datalistado.GridColor = System.Drawing.SystemColors.Highlight
        Me.datalistado.Location = New System.Drawing.Point(19, 34)
        Me.datalistado.Margin = New System.Windows.Forms.Padding(2)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.RowHeadersVisible = False
        Me.datalistado.RowHeadersWidth = 51
        Me.datalistado.RowTemplate.Height = 28
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(529, 192)
        Me.datalistado.TabIndex = 1
        '
        'frmCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(963, 576)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCompras"
        Me.Text = "frmCompras"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtcantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnbuscarPro As Button
    Friend WithEvents txtcantidad As NumericUpDown
    Friend WithEvents txtprecio_compra As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnBuscarProducto As Button
    Friend WithEvents txtnom_producto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtidproducto As TextBox
    Friend WithEvents txtfechaCompra As DateTimePicker
    Friend WithEvents txtnombre_proveedor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtidproveedor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtidcompra As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnguardar As Button
    Friend WithEvents inexistente As LinkLabel
    Friend WithEvents btnnuevo As Button
    Friend WithEvents datalistado As DataGridView
End Class

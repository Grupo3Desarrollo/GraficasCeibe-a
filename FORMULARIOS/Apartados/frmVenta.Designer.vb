﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenta
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVenta))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtnum_documento = New System.Windows.Forms.TextBox()
        Me.btnLimCli = New System.Windows.Forms.Button()
        Me.txtbuscarempleado = New System.Windows.Forms.Button()
        Me.txtnomempleado = New System.Windows.Forms.TextBox()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.txtidempleado = New System.Windows.Forms.TextBox()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.txtfecha = New System.Windows.Forms.DateTimePicker()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.txtnombre_cliente = New System.Windows.Forms.TextBox()
        Me.rtn = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtidcliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidventa = New System.Windows.Forms.TextBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox2.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtbuscar)
        Me.GroupBox2.Controls.Add(Me.inexistente)
        Me.GroupBox2.Controls.Add(Me.datalistado)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox2.Location = New System.Drawing.Point(59, 361)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(1295, 308)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LISTA DE VENTAS"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(395, 30)
        Me.txtbuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(215, 30)
        Me.txtbuscar.TabIndex = 26
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(652, 178)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(190, 25)
        Me.inexistente.TabIndex = 21
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "Datos Inexistentes"
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
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.datalistado.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.datalistado.Location = New System.Drawing.Point(121, 69)
        Me.datalistado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.RowHeadersVisible = False
        Me.datalistado.RowHeadersWidth = 51
        Me.datalistado.RowTemplate.Height = 28
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(1112, 194)
        Me.datalistado.TabIndex = 19
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.MinimumWidth = 6
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Width = 93
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(116, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(254, 25)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Busqueda (codigo venta)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtnum_documento)
        Me.GroupBox1.Controls.Add(Me.btnLimCli)
        Me.GroupBox1.Controls.Add(Me.txtbuscarempleado)
        Me.GroupBox1.Controls.Add(Me.txtnomempleado)
        Me.GroupBox1.Controls.Add(Me.btnnuevo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnguardar)
        Me.GroupBox1.Controls.Add(Me.txtidempleado)
        Me.GroupBox1.Controls.Add(Me.btneditar)
        Me.GroupBox1.Controls.Add(Me.txtfecha)
        Me.GroupBox1.Controls.Add(Me.btnBuscarCliente)
        Me.GroupBox1.Controls.Add(Me.txtnombre_cliente)
        Me.GroupBox1.Controls.Add(Me.rtn)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtidcliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtidventa)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Location = New System.Drawing.Point(57, 37)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1295, 293)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DE VENTA"
        '
        'txtnum_documento
        '
        Me.txtnum_documento.Location = New System.Drawing.Point(871, 117)
        Me.txtnum_documento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtnum_documento.MaxLength = 13
        Me.txtnum_documento.Multiline = True
        Me.txtnum_documento.Name = "txtnum_documento"
        Me.txtnum_documento.ReadOnly = True
        Me.txtnum_documento.Size = New System.Drawing.Size(200, 31)
        Me.txtnum_documento.TabIndex = 27
        Me.txtnum_documento.Text = "01011958001101"
        '
        'btnLimCli
        '
        Me.btnLimCli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimCli.Image = CType(resources.GetObject("btnLimCli.Image"), System.Drawing.Image)
        Me.btnLimCli.Location = New System.Drawing.Point(608, 110)
        Me.btnLimCli.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLimCli.Name = "btnLimCli"
        Me.btnLimCli.Size = New System.Drawing.Size(60, 47)
        Me.btnLimCli.TabIndex = 26
        Me.btnLimCli.UseVisualStyleBackColor = True
        '
        'txtbuscarempleado
        '
        Me.txtbuscarempleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtbuscarempleado.Image = CType(resources.GetObject("txtbuscarempleado.Image"), System.Drawing.Image)
        Me.txtbuscarempleado.Location = New System.Drawing.Point(543, 186)
        Me.txtbuscarempleado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtbuscarempleado.Name = "txtbuscarempleado"
        Me.txtbuscarempleado.Size = New System.Drawing.Size(60, 47)
        Me.txtbuscarempleado.TabIndex = 24
        Me.txtbuscarempleado.UseVisualStyleBackColor = True
        '
        'txtnomempleado
        '
        Me.txtnomempleado.Location = New System.Drawing.Point(280, 193)
        Me.txtnomempleado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnomempleado.Multiline = True
        Me.txtnomempleado.Name = "txtnomempleado"
        Me.txtnomempleado.ReadOnly = True
        Me.txtnomempleado.Size = New System.Drawing.Size(247, 32)
        Me.txtnomempleado.TabIndex = 23
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.SteelBlue
        Me.btnnuevo.BackgroundImage = CType(resources.GetObject("btnnuevo.BackgroundImage"), System.Drawing.Image)
        Me.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnnuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.Location = New System.Drawing.Point(1112, 57)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(121, 74)
        Me.btnnuevo.TabIndex = 12
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(75, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 25)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "EMPLEADO"
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnguardar.BackgroundImage = CType(resources.GetObject("btnguardar.BackgroundImage"), System.Drawing.Image)
        Me.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.Location = New System.Drawing.Point(1112, 182)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(121, 76)
        Me.btnguardar.TabIndex = 16
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'txtidempleado
        '
        Me.txtidempleado.Location = New System.Drawing.Point(281, 244)
        Me.txtidempleado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtidempleado.MaxLength = 13
        Me.txtidempleado.Multiline = True
        Me.txtidempleado.Name = "txtidempleado"
        Me.txtidempleado.ReadOnly = True
        Me.txtidempleado.Size = New System.Drawing.Size(35, 31)
        Me.txtidempleado.TabIndex = 21
        '
        'btneditar
        '
        Me.btneditar.BackColor = System.Drawing.Color.SteelBlue
        Me.btneditar.BackgroundImage = CType(resources.GetObject("btneditar.BackgroundImage"), System.Drawing.Image)
        Me.btneditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btneditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btneditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditar.Location = New System.Drawing.Point(1112, 181)
        Me.btneditar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(121, 76)
        Me.btneditar.TabIndex = 13
        Me.btneditar.Text = "Editar"
        Me.btneditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btneditar.UseVisualStyleBackColor = False
        '
        'txtfecha
        '
        Me.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha.Location = New System.Drawing.Point(871, 57)
        Me.txtfecha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtfecha.MaxDate = New Date(2022, 3, 24, 0, 0, 0, 0)
        Me.txtfecha.MinDate = New Date(2021, 3, 12, 0, 0, 0, 0)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(200, 30)
        Me.txtfecha.TabIndex = 19
        Me.txtfecha.Value = New Date(2021, 4, 7, 0, 0, 0, 0)
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarCliente.Image = CType(resources.GetObject("btnBuscarCliente.Image"), System.Drawing.Image)
        Me.btnBuscarCliente.Location = New System.Drawing.Point(543, 110)
        Me.btnBuscarCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(60, 47)
        Me.btnBuscarCliente.TabIndex = 18
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'txtnombre_cliente
        '
        Me.txtnombre_cliente.Location = New System.Drawing.Point(281, 117)
        Me.txtnombre_cliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnombre_cliente.Multiline = True
        Me.txtnombre_cliente.Name = "txtnombre_cliente"
        Me.txtnombre_cliente.Size = New System.Drawing.Size(245, 31)
        Me.txtnombre_cliente.TabIndex = 17
        '
        'rtn
        '
        Me.rtn.AutoSize = True
        Me.rtn.Location = New System.Drawing.Point(737, 121)
        Me.rtn.Name = "rtn"
        Me.rtn.Size = New System.Drawing.Size(73, 25)
        Me.rtn.TabIndex = 9
        Me.rtn.Text = "R.T.N."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(676, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "FECHA VENTA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "CLIENTE"
        '
        'txtidcliente
        '
        Me.txtidcliente.Location = New System.Drawing.Point(281, 156)
        Me.txtidcliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtidcliente.Multiline = True
        Me.txtidcliente.Name = "txtidcliente"
        Me.txtidcliente.Size = New System.Drawing.Size(36, 31)
        Me.txtidcliente.TabIndex = 2
        Me.txtidcliente.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID VENTA"
        '
        'txtidventa
        '
        Me.txtidventa.Location = New System.Drawing.Point(280, 60)
        Me.txtidventa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtidventa.Multiline = True
        Me.txtidventa.Name = "txtidventa"
        Me.txtidventa.ReadOnly = True
        Me.txtidventa.Size = New System.Drawing.Size(247, 31)
        Me.txtidventa.TabIndex = 0
        '
        'ErrorValidacion
        '
        Me.ErrorValidacion.ContainerControl = Me
        '
        'frmVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1440, 722)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmVenta"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents inexistente As LinkLabel
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtbuscarempleado As Button
    Friend WithEvents txtnomempleado As TextBox
    Friend WithEvents btnnuevo As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents btnguardar As Button
    Friend WithEvents txtidempleado As TextBox
    Friend WithEvents btneditar As Button
    Friend WithEvents txtfecha As DateTimePicker
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents txtnombre_cliente As TextBox
    Friend WithEvents rtn As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtidcliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtidventa As TextBox
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents ErrorValidacion As ErrorProvider
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents btnLimCli As Button
    Friend WithEvents txtnum_documento As TextBox
End Class

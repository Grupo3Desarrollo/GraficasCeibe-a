Imports System.ComponentModel
Public Class frmProducto
    Dim conexion As New Conexion()
    Dim dt As New DataTable()

    Private Sub frmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarProducto()
        txtstock.Text = "0"
        txtprecio_compra.Text = "0"
        txtprecio_venta.Text = "0"
        txtidcategoria.Visible = False
    End Sub

    Public Sub mostrarProducto()
        Try
            Dim func As New Conexion
            dt = func.mostrarProducto
            datalistado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                txtbuscar.Enabled = True
                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False
                ocultar_columnas()
            Else
                datalistado.DataSource = Nothing
                txtbuscar.Enabled = False
                datalistado.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        btnnuevo.Visible = True
        btneditar.Visible = False

    End Sub

    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        txtnombre.Text = ""
        txtidcategoria.Text = ""
        txtdescripcion.Text = ""
        txtnom_categoria.Text = ""
        txtbuscar.Text = ""
        txtstock.Text = "0"
        txtprecio_compra.Text = "0"
        txtprecio_venta.Text = "0"
        txtidproducto.Text = ""

        imagen.Image = My.Resources.transparente
        imagen.BackgroundImage = My.Resources.transparente
        imagen.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub buscar()
        Dim nombre As String
        Try
            nombre = txtbuscar.Text
            dt = conexion.buscarProducto(nombre)

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                conexion.conexion.Close()
                ocultar_columnas()
            Else
                datalistado.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub ocultar_columnas()
        datalistado.Columns(1).Visible = False
        datalistado.Columns(2).Visible = False
        datalistado.Columns(10).Visible = False
    End Sub

    Private Sub insertarProducto()
        Dim idcategoria As Integer
        Dim descripcion As String
        Dim stock, precio_compra, precio_venta As Double
        Dim fecha_vencimiento As Date
        Dim imagenD() As Byte
        Dim mayus As String

        idcategoria = txtidcategoria.Text
        mayus = txtnombre.Text
        Dim nombre As String = StrConv(mayus, VbStrConv.ProperCase)

        txtnombre.Text = nombre
        descripcion = txtdescripcion.Text
        stock = txtstock.Text
        precio_compra = txtprecio_compra.Text
        precio_venta = txtprecio_venta.Text
        fecha_vencimiento = txtfecha_vencimiento.Text

        Dim ms As New IO.MemoryStream()
        If Not imagen.Image Is Nothing Then
            imagen.Image.Save(ms, imagen.Image.RawFormat)
        Else
            imagen.Image.Save(ms, imagen.Image.RawFormat)
        End If
        imagenD = ms.GetBuffer

        Try
            If conexion.insertarProducto(idcategoria, nombre, descripcion, stock, precio_compra, precio_venta, fecha_vencimiento, imagenD) Then
                MessageBox.Show("Producto almacenado con Exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub editarProducto()

        Dim idcategoria, idproducto As Integer
        Dim descripcion, mayus As String
        Dim stock, precio_compra, precio_venta As Double
        Dim fecha_vencimiento As Date
        Dim imagenD() As Byte
        idproducto = txtidproducto.Text
        idcategoria = txtidcategoria.Text
        mayus = txtnombre.Text
        Dim nombre As String = StrConv(mayus, VbStrConv.ProperCase)

        txtnombre.Text = nombre
        descripcion = txtdescripcion.Text
        stock = txtstock.Text
        precio_compra = txtprecio_compra.Text
        precio_venta = txtprecio_venta.Text
        fecha_vencimiento = txtfecha_vencimiento.Text

        Dim ms As New IO.MemoryStream()
        If Not imagen.Image Is Nothing Then
            imagen.Image.Save(ms, imagen.Image.RawFormat)
        Else
            imagen.Image.Save(ms, imagen.Image.RawFormat)
        End If
        imagenD = ms.GetBuffer

        Try
            If conexion.editarproducto(idproducto, idcategoria, nombre, descripcion, stock, precio_compra, precio_venta, fecha_vencimiento, imagenD) Then
                MessageBox.Show("Producto modificado con Exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al modificar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btncargar_Click(sender As Object, e As EventArgs) Handles btncargar.Click
        If DLG.ShowDialog = DialogResult.OK Then
            imagen.BackgroundImage = Nothing
            imagen.Image = New Bitmap(DLG.FileName)
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
            btnguardar.Enabled = True
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles eliminarImg.Click
        imagen.Image = My.Resources.transparente
        btnguardar.Enabled = False
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        mostrarProducto()
        eliminarImg.Visible = True
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtnombre.Text <> "" And txtdescripcion.Text <> "" And txtstock.Text <> "" And txtprecio_compra.Text <> "" And txtprecio_venta.Text <> "" Then

            Try
                insertarProducto()
                mostrarProducto()
                limpiar()
                conexion.conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Revise los datos Ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea editar os datos del Producto?", "Modifiar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtnombre.Text <> "" And txtdescripcion.Text <> "" And txtstock.Text <> "" And txtprecio_compra.Text <> "" And txtprecio_venta.Text <> "" Then
                Try
                    editarProducto()
                    mostrarProducto()
                    limpiar()
                    conexion.conexion.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Revise los datos Ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            limpiar()
        End If
    End Sub

    Private Sub btnbuscarcategoria_Click(sender As Object, e As EventArgs) Handles btnbuscarcategoria.Click
        mostrarCategoria.txtflag.Text = "1"
        mostrarCategoria.ShowDialog()
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        Dim FilaActual As Integer
        FilaActual = datalistado.CurrentRow.Index
        txtidproducto.Text = datalistado.Rows(FilaActual).Cells(1).Value
        txtidcategoria.Text = datalistado.Rows(FilaActual).Cells(2).Value
        txtnom_categoria.Text = datalistado.Rows(FilaActual).Cells(3).Value
        txtnombre.Text = datalistado.Rows(FilaActual).Cells(4).Value
        txtdescripcion.Text = datalistado.Rows(FilaActual).Cells(5).Value
        txtstock.Text = datalistado.Rows(FilaActual).Cells(6).Value
        txtprecio_compra.Text = datalistado.Rows(FilaActual).Cells(7).Value
        txtprecio_venta.Text = datalistado.Rows(FilaActual).Cells(8).Value
        txtfecha_vencimiento.Text = datalistado.Rows(FilaActual).Cells(9).Value

        imagen.BackgroundImage = Nothing
        Dim b() As Byte = datalistado.Rows(FilaActual).Cells(10).Value
        Dim ms As New IO.MemoryStream(b)
        imagen.Image = Image.FromStream(ms)
        imagen.SizeMode = PictureBoxSizeMode.StretchImage

        eliminarImg.Visible = False
        btnguardar.Visible = False
        btneditar.Visible = True
    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
    Private Sub txtidproducto_TextChanged(sender As Object, e As EventArgs) Handles txtidproducto.TextChanged

    End Sub

    Private Sub txtidproducto_Validating(sender As Object, e As CancelEventArgs) Handles txtidproducto.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged

    End Sub

    Private Sub txtnombre_Validating(sender As Object, e As CancelEventArgs) Handles txtnombre.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtnom_categoria_TextChanged(sender As Object, e As EventArgs) Handles txtnom_categoria.TextChanged

    End Sub

    Private Sub txtnom_categoria_Validating(sender As Object, e As CancelEventArgs) Handles txtnom_categoria.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub txtstock_Validating(sender As Object, e As CancelEventArgs) Handles txtstock.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtprecio_compra_TextChanged(sender As Object, e As EventArgs) Handles txtprecio_compra.TextChanged

    End Sub

    Private Sub txtprecio_compra_Validating(sender As Object, e As CancelEventArgs) Handles txtprecio_compra.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtprecio_venta_TextChanged(sender As Object, e As EventArgs) Handles txtprecio_venta.TextChanged

    End Sub

    Private Sub txtprecio_venta_Validating(sender As Object, e As CancelEventArgs) Handles txtprecio_venta.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtidproducto_MouseHover(sender As Object, e As EventArgs) Handles txtidproducto.MouseHover
        ToolTip.SetToolTip(txtidproducto, "Ingrese el id del producto")
        ToolTip.ToolTipTitle = "Producto"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtnombre_MouseHover(sender As Object, e As EventArgs) Handles txtnombre.MouseHover
        ToolTip.SetToolTip(txtnombre, "Ingrese el nombre")
        ToolTip.ToolTipTitle = "Nombre"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtnom_categoria_MouseHover(sender As Object, e As EventArgs) Handles txtnom_categoria.MouseHover
        ToolTip.SetToolTip(txtnom_categoria, "Ingrese la categoria")
        ToolTip.ToolTipTitle = "Categoria"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtdescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtdescripcion.TextChanged

    End Sub

    Private Sub txtdescripcion_MouseHover(sender As Object, e As EventArgs) Handles txtdescripcion.MouseHover
        ToolTip.SetToolTip(txtdescripcion, "Ingrese la descriripcion")
        ToolTip.ToolTipTitle = "Descripcion"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtstock_TextChanged(sender As Object, e As EventArgs) Handles txtstock.TextChanged

    End Sub

    Private Sub txtstock_MouseHover(sender As Object, e As EventArgs) Handles txtstock.MouseHover
        ToolTip.SetToolTip(txtstock, "Ingrese el stock")
        ToolTip.ToolTipTitle = "Stock"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtprecio_compra_MouseHover(sender As Object, e As EventArgs) Handles txtprecio_compra.MouseHover
        ToolTip.SetToolTip(txtprecio_compra, "Ingrese el precio de compra")
        ToolTip.ToolTipTitle = "Precio compra"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtprecio_venta_MouseHover(sender As Object, e As EventArgs) Handles txtprecio_venta.MouseHover
        ToolTip.SetToolTip(txtprecio_venta, "Ingrese el precio de venta")
        ToolTip.ToolTipTitle = "Precio venta"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtbuscar_MouseHover(sender As Object, e As EventArgs) Handles txtbuscar.MouseHover
        ToolTip.SetToolTip(txtbuscar, "Ingrese dato a buscar")
        ToolTip.ToolTipTitle = "Buscar"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub imagen_MouseHover(sender As Object, e As EventArgs) Handles imagen.MouseHover
        ToolTip.SetToolTip(imagen, "Ingrese la imagen del Producto")
        ToolTip.ToolTipTitle = "Cargar imagen"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnbuscarcategoria_MouseHover(sender As Object, e As EventArgs) Handles btnbuscarcategoria.MouseHover
        ToolTip.SetToolTip(btnbuscarcategoria, "Buscar en tabla categorias")
        ToolTip.ToolTipTitle = "Buscar Categorias"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtdescripcion_Validating(sender As Object, e As CancelEventArgs) Handles txtdescripcion.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtstock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtstock.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub txtprecio_compra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecio_compra.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub txtprecio_venta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecio_venta.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class
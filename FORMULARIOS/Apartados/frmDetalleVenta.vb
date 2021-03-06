Public Class frmDetalleVenta
    Dim conexion As New Conexion()
    Dim dt As New DataTable()

    Private Sub frmDetalles_venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_Dventas()
    End Sub

    Public Sub mostrar_Dventas()
        Try
            Dim func As New Conexion
            dt = func.mostrarDetalleVenta
            'datalistado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False
                ocultar_columnas()
            Else
                datalistado.DataSource = Nothing

                datalistado.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'buscar()
    End Sub

    Public Sub limpiar()
        btnguardar.Visible = True
        txtidproducto.Text = ""
        txtnom_producto.Text = ""
        txtprecio_unitario.Text = ""
        txtcantidad.Value = 0
        txtstock.Value = 1
    End Sub

    Private Sub ocultar_columnas()
        datalistado.Columns(0).Visible = False
        datalistado.Columns(1).Visible = False
        datalistado.Columns(2).Visible = False
    End Sub

    Private Sub InsertarDetallesVenta()
        Dim idventa, idproducto As Integer
        Dim cantidad, precio_V As Double

        idventa = txtidventa.Text
        idproducto = txtidproducto.Text
        precio_V = txtprecio_unitario.Text
        cantidad = txtcantidad.Text

        If conexion.disminuir_stock(idproducto, cantidad) Then
        End If
        Try
            If conexion.insertarDetallesVenta(idventa, idproducto, precio_V, cantidad) Then
            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtidproducto.Text <> "" And txtcantidad.Text <> "" And txtprecio_unitario.Text <> "" Then
            Try
                InsertarDetallesVenta()
                mostrar_Dventas()
                limpiar()
                conexion.conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Revise los datos Ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        mostrar_Dventas()
    End Sub

    Private Sub btnBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click
        mostrarProductos.txtflag.Text = "1"
        mostrarProductos.ShowDialog()
    End Sub

    Private Sub txtcantidad_ValueChanged(sender As Object, e As EventArgs) Handles txtcantidad.ValueChanged
        Dim cant As Double
        cant = txtcantidad.Text
        If txtcantidad.Value > txtstock.Value Then
            MessageBox.Show("La cantidad de productos supera el Stock", "Error al vender", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnguardar.Visible = 0
            txtcantidad.Value = txtstock.Value
        Else
            btnguardar.Visible = 1
        End If

        If txtcantidad.Text = 0 Then
            btnguardar.Visible = 0
        Else
            btnguardar.Visible = 1
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub txtnum_documento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnum_documento.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtprecio_unitario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecio_unitario.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnBuscarProducto_MouseHover(sender As Object, e As EventArgs) Handles btnBuscarProducto.MouseHover
        ToolTip.SetToolTip(btnBuscarProducto, "Buscar en tabla productos")
        ToolTip.ToolTipTitle = "Buscar Productos"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtprecio_unitario_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtprecio_unitario.Validating
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

    Private Sub txtnum_documento_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtnum_documento.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
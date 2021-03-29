Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class frmDetalleCompras
    Dim conexion As New Conexion()
    Dim dt As New DataTable()
    Public comando As SqlCommand
    Public tabla As DataSet
    Public tablas As DataSet
    Public adaptador, adaptador1 As SqlDataAdapter

    Private Sub frmDetalleCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_Dcompras()
        txtidProv.Visible = False
        btneliminar.Visible = False
    End Sub

    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        btneliminar.Visible = False
        txtidproducto.Text = ""
        txtnom_producto.Text = ""
        txtprecio_unitario.Text = ""
        txtcantidad.Value = 0
    End Sub

    Private Sub ocultar_columnas()
        datalistado.Columns(0).Visible = False
        datalistado.Columns(1).Visible = False
    End Sub

    Public Sub mostrar_Dcompras()
        Dim IdCompra As Integer
        Try
            Dim func As New Conexion
            IdCompra = txtidcompra.Text
            dt = func.mostrarDetalleCompra(IdCompra)

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
    End Sub

    Private Sub InsertarDetallesCompra()
        Dim idCompra, idproducto As Integer
        Dim cantidad, precio_V As Double

        idCompra = txtidcompra.Text
        idproducto = txtidproducto.Text
        precio_V = txtprecio_unitario.Text
        cantidad = txtcantidad.Text

        Try
            If txtcantidad.Text = 0 Then
                MessageBox.Show("Ingrese una cantidad a su compra", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If conexion.insertarDetallesCompra(idCompra, idproducto, precio_V, cantidad) Then
                Else
                    MessageBox.Show("Error al guardar compra", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EditarDetallesCompra()
        Dim idCompra, idproducto As Integer
        Dim cantidad, precio_V As Double

        idCompra = txtidcompra.Text
        idproducto = txtidproducto.Text
        precio_V = txtprecio_unitario.Text
        cantidad = txtcantidad.Text

        Try
            If txtcantidad.Text = 0 Then
                MessageBox.Show("Ingrese una cantidad a su Compra", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If conexion.editarDetallesCompra(idCompra, idproducto, precio_V, cantidad) Then
                    MessageBox.Show("Compra editada con exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Error al Editar compra", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Esta seguro de eliminar este producto en la compra?", "Eliminar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtidproducto.Text <> "" And txtidcompra.Text <> "" Then
                Try
                    EliminarDetallesCompra()
                    mostrar_Dcompras()
                    'mostrarTotalC()
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

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtidproducto.Text <> "" And txtcantidad.Text <> "" And txtprecio_unitario.Text <> "" Then
            Try
                InsertarDetallesCompra()
                mostrar_Dcompras()
                'mostrarTotalV()
                limpiar()
                conexion.conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Revise los datos Ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick

    End Sub

    Private Sub EliminarDetallesCompra()
        Dim idCompra, idproducto As Integer

        idCompra = txtidcompra.Text
        idproducto = txtidproducto.Text

        Try
            If conexion.EliminarDetallesC(idCompra, idproducto) Then
                MessageBox.Show("Producto Descartado de la Compra", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Esta seguro de editar este producto en la compra?", "Modifiar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtidproducto.Text <> "" And txtcantidad.Text <> "" And txtprecio_unitario.Text <> "" Then
                Try
                    EditarDetallesCompra()
                    mostrar_Dcompras()
                    'mostrarTotalC()
                    limpiar()
                    conexion.conexion.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Revise los datos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            limpiar()
        End If
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        mostrar_Dcompras()
        'mostrarTotalC()
    End Sub

    Private Sub btnBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click
        mostrarProductos.txtflag.Text = "2"
        mostrarProductos.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub txtprecio_unitario_TextChanged(sender As Object, e As EventArgs) Handles txtprecio_unitario.TextChanged

    End Sub

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        Dim FilaActual As Integer
        FilaActual = datalistado.CurrentRow.Index
        btnguardar.Visible = False
        btneditar.Visible = True
        btneliminar.Visible = True
        txtidproducto.Text = datalistado.Rows(FilaActual).Cells(1).Value
        txtnom_producto.Text = datalistado.Rows(FilaActual).Cells(2).Value
        txtprecio_unitario.Text = datalistado.Rows(FilaActual).Cells(3).Value
        txtcantidad.Text = datalistado.Rows(FilaActual).Cells(4).Value
    End Sub

    Private Sub txtprecio_unitario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecio_unitario.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtprecio_unitario_Validating(sender As Object, e As CancelEventArgs) Handles txtprecio_unitario.Validating
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

    Private Sub btnBuscarProducto_MouseHover(sender As Object, e As EventArgs) Handles btnBuscarProducto.MouseHover
        ToolTip1.SetToolTip(btnBuscarProducto, "Buscar en tabla productos")
        ToolTip1.ToolTipTitle = "Buscar Productos"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class
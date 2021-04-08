Imports System.Data.SqlClient

Public Class frmDetalleVenta
    Dim conexion As New Conexion()
    Dim dt As New DataTable()
    Public comando As SqlCommand
    Public tabla As DataSet
    Public tablas As DataSet
    Public adaptador, adaptador1 As SqlDataAdapter
    Dim IdVentaT As Integer

    Private Sub frmDetalles_venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_Dventas()
        txtidcliente.Visible = False
        txtCant2.Visible = False
        btneliminar.Visible = False
        'DataDos.Visible = False

        If IdVentaT <> txtidventa.Text Then
            IdVentaT = txtidventa.Text
        End If
    End Sub

    Public Sub mostrar_Dventas()
        Dim IdVenta As Integer
        Try
            Dim func As New Conexion
            IdVenta = txtidventa.Text
            dt = func.mostrarDetalleVenta(IdVenta)

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

    Public Sub mostrarTotalV()

        Try
            Dim func As New Conexion
            dt = func.mostrarTotalV(IdVentaT)
            If dt.Rows.Count <> 0 Then
                DataDos.DataSource = dt
                DataDos.ColumnHeadersVisible = True

                Dim FilaActual As Integer
                FilaActual = DataDos.CurrentRow.Index
                txtarticulos.Text = DataDos.Rows(FilaActual).Cells(0).Value
                txttotal.Text = DataDos.Rows(FilaActual).Cells(1).Value
            Else
                DataDos.DataSource = Nothing
                DataDos.ColumnHeadersVisible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        btneliminar.Visible = False
        txtidproducto.Text = ""
        txtnom_producto.Text = ""
        txtprecio_unitario.Text = ""
        txtCant2.Value = 0
        txtcantidad.Value = 0
        txtstock.Value = 0
    End Sub

    Private Sub ocultar_columnas()
        datalistado.Columns(0).Visible = False
        datalistado.Columns(1).Visible = False
        datalistado.Columns(5).Visible = False
    End Sub

    Private Sub InsertarDetallesVenta()
        Dim idventa, idproducto As Integer
        Dim cantidad, precio_V As Double

        'DataGrid
        'Dim FilaActual As Integer
        idventa = txtidventa.Text
        idproducto = txtidproducto.Text
        precio_V = txtprecio_unitario.Text
        cantidad = txtcantidad.Text

        Try
            'If datalistado.Rows.Count > 0 Then

            If conexion.insertarDetallesVenta(idventa, idproducto, precio_V, cantidad) Then
                If conexion.disminuir_stock(idproducto, cantidad) Then
                End If
            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EditarDetallesVenta()
        Dim idventa, idproducto As Integer
        Dim cantidad, precio_V As Double
        Dim Aumento As Double

        idventa = txtidventa.Text
        idproducto = txtidproducto.Text
        precio_V = txtprecio_unitario.Text
        cantidad = txtcantidad.Text

        Try
            If txtcantidad.Text = 0 Then
                MessageBox.Show("Ingrese una cantidad a su Venta", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If txtstock.Value = 0 Then
                    MessageBox.Show("Seleccione el producto nuevamente por favor", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    limpiar()
                Else
                    If conexion.editarDetallesVenta(idventa, idproducto, precio_V, cantidad) Then
                        MessageBox.Show("Venta editada con exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If txtcantidad.Value < txtCant2.Value Then
                            If conexion.disminuir_stock(idproducto, cantidad) Then
                                Aumento = txtCant2.Text
                                conexion.aumentar_stock(idproducto, Aumento)
                            End If
                        End If
                        If txtcantidad.Value > txtCant2.Value Then
                            If conexion.disminuir_stock(idproducto, cantidad) Then
                                Aumento = txtCant2.Text
                                conexion.aumentar_stock(idproducto, Aumento)
                            End If
                        End If
                    Else
                        MessageBox.Show("Error al Editar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EliminarDetallesVenta()
        Dim idventa, idproducto As Integer
        Dim Aumento As Double

        idventa = txtidventa.Text
        idproducto = txtidproducto.Text

        Try
            If conexion.EliminarDetallesV(idventa, idproducto) Then
                MessageBox.Show("Producto Descartado de la venta", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Aumento = txtCant2.Text
                conexion.aumentar_stock(idproducto, Aumento)
            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Esta seguro de eliminar este producto en la venta?", "Eliminar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtidproducto.Text <> "" And txtidventa.Text <> "" Then
                Try
                    EliminarDetallesVenta()
                    mostrar_Dventas()
                    mostrarTotalV()
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
                If txtcantidad.Text = 0 Then
                    MessageBox.Show("Ingrese una cantidad", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    InsertarDetallesVenta()
                    mostrar_Dventas()
                    mostrarTotalV()
                    limpiar()
                    conexion.conexion.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Revise los datos Ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
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
        txtCant2.Text = datalistado.Rows(FilaActual).Cells(4).Value
        txtstock.Value = datalistado.Rows(FilaActual).Cells(5).Value
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Esta seguro de editar este producto en la venta?", "Modifiar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtidproducto.Text <> "" And txtcantidad.Text <> "" And txtprecio_unitario.Text <> "" Then
                Try
                    EditarDetallesVenta()
                    mostrar_Dventas()
                    mostrarTotalV()
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
            ' btnguardar.Visible = 0
            txtcantidad.Value = txtstock.Value
        Else
            'btnguardar.Visible = 1
        End If

        If txtcantidad.Text = 0 Then
            'btnguardar.Visible = 0
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtarticulos.Text = ""
        txttotal.Text = ""
        Me.Close()
    End Sub

    Private Sub txtnum_documento_KeyPress(sender As Object, e As KeyPressEventArgs)
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

    Private Sub txtnum_documento_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
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

    'Buscar Registros para Factura
    Function buscarRegistros(ByVal consulta As String)
        Try
            adaptador = New SqlDataAdapter(consulta, conexion.conexion)
            adaptador.TableMappings.Add("ventas1", "detalle")
            tablas = New DataSet("tablas1")
            adaptador.Fill(tablas, "ventas")
            conexion.conexion.Close()
            Return True
        Catch ex As Exception
            MsgBox("Error en consulta. Los datos seleccionados son" + Chr(13) + "incorrectos")
            Return False
        End Try

    End Function

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        If datalistado.Rows.Count <> 0 Then
            mostrarTotalV()
        Else
            MessageBox.Show("No cuenta con productos en la venta", "Venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        End If
    End Sub

    Private Sub btnimprimir_Click(sender As Object, e As EventArgs) Handles btnimprimir.Click
        Dim result As DialogResult
        Dim sql As String

        result = MessageBox.Show("Esta seguro que la venta esta completa?", "Venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            sql = "Select * from vistaventas where idventa =" & txtidventa.Text & ";" & "Select * from vistacalculo where idventa =" & txtidventa.Text & ";"

            If buscarRegistros(sql) = True Then
                If tablas.Tables("ventas").Rows.Count = 0 Then
                    MsgBox("No se ha encontrado ningun registro que cumpla con los requisitos o la base de datos" + Chr(13) + " se encuentra vacia. El listado se mostrara vacio.", MsgBoxStyle.Information, "Error al listar")
                Else
                    MsgBox("Generado Correctamente", MsgBoxStyle.Information, "Correcto")
                    My.Computer.FileSystem.CreateDirectory("C:\XML")
                    Dim url As String = "C:\XML\ventas.xml"
                    tablas.WriteXml(url, XmlWriteMode.WriteSchema)

                    frmVerReporte.ShowDialog()
                    My.Computer.FileSystem.DeleteFile("C:\XML\ventas.xml")

                End If
            End If
        Else

        End If

    End Sub

    Private Sub btnRefresh_MouseHover(sender As Object, e As EventArgs) Handles btnRefresh.MouseHover
        ToolTip.SetToolTip(btnRefresh, "Actualizar la cantidad y el total")
        ToolTip.ToolTipTitle = "Actualizar"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class
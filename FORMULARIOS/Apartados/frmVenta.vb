Imports System.ComponentModel
Public Class frmVenta
    Dim conexion As New Conexion()
    Dim dt As New DataTable()

    Private Sub frmVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_ventas()
        txtidcliente.Text = "1"
        txtidcliente.Visible = False
        txtidempleado.Visible = False
    End Sub

    Private Sub ocultar_columnas()
        datalistado.Columns(2).Visible = False
    End Sub

    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        txtidcliente.ReadOnly = False
        txtnombre_cliente.ReadOnly = False
        txtidcliente.Visible = False
        txtidcliente.Text = "1"
        'txtidcliente.Text = ""
        txtnombre_cliente.Text = ""
        txtidventa.Text = ""
        txtidempleado.Text = ""
        txtnomempleado.Text = ""
        txtbuscar.Text = ""
    End Sub

    Public Sub mostrar_ventas()
        Try
            Dim func As New Conexion
            dt = func.mostrarVenta
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

    Private Sub buscar()
        Dim num_documento As String
        Try
            num_documento = txtbuscar.Text
            dt = conexion.buscarVenta(num_documento)

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

    Private Sub insertarventa()
        Dim idcliente, idEmpleado As Integer
        Dim fecha_venta As Date
        Dim num_documento, nombresClientes As String
        idcliente = txtidcliente.Text
        fecha_venta = txtfecha.Text
        num_documento = txtnum_documento.Text
        idEmpleado = txtidempleado.Text
        nombresClientes = txtnombre_cliente.Text

        Try
            If conexion.insertarVenta(fecha_venta, num_documento, idEmpleado, idcliente, nombresClientes) Then
            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub editarVenta()
        Dim idventa, idcliente, idEmpleado As Integer
        Dim fecha_venta As Date
        Dim num_documento, nombresCliente As String
        idventa = txtidventa.Text
        idcliente = txtidcliente.Text
        fecha_venta = txtfecha.Text
        num_documento = txtnum_documento.Text
        idEmpleado = txtidempleado.Text
        nombresCliente = txtnombre_cliente.Text

        Try
            If conexion.editarVenta(idventa, fecha_venta, num_documento, idEmpleado, idcliente, nombresCliente) Then
                MessageBox.Show("Venta modificada con Exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al modificar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtidempleado.Text <> "" And txtnomempleado.Text <> "" And txtnum_documento.Text <> "" Then
            Try
                insertarventa()
                mostrar_ventas()
                limpiar()
                cargar_detalle()
                conexion.conexion.Close()
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
        txtidventa.Text = Convert.ToString(datalistado.Rows(FilaActual).Cells(1).Value)
        txtidcliente.Text = Convert.ToString(datalistado.Rows(FilaActual).Cells(2).Value)
        txtnombre_cliente.Text = Convert.ToString(datalistado.Rows(FilaActual).Cells(3).Value)
        txtfecha.Text = Convert.ToString(datalistado.Rows(FilaActual).Cells(4).Value)
        txtnomempleado.Text = Convert.ToString(datalistado.Rows(FilaActual).Cells(5).Value)
        btnguardar.Visible = False
        btneditar.Visible = True
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea editar los datos de la venta?", "Modifiar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtidventa.Text <> "" And txtidempleado.Text <> "" And txtnomempleado.Text <> "" And txtnum_documento.Text <> "" Then
                Try
                    editarVenta()
                    mostrar_ventas()
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


    Private Sub cargar_detalle()
        frmDetalleVenta.txtidventa.Text = Convert.ToString(datalistado.SelectedCells.Item(1).Value)
        frmDetalleVenta.txtidcliente.Text = Convert.ToString(datalistado.SelectedCells.Item(2).Value)
        frmDetalleVenta.txtnombre_cliente.Text = Convert.ToString(datalistado.SelectedCells.Item(3).Value)
        frmDetalleVenta.txtfecha.Text = Convert.ToString(datalistado.SelectedCells.Item(4).Value)

        frmDetalleVenta.ShowDialog()
    End Sub

    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        cargar_detalle()
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs)
        buscar()
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        mostrar_ventas()
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        MostrarClientes.txtflag.Text = "1"
        MostrarClientes.ShowDialog()
        txtidcliente.ReadOnly = True
        txtnombre_cliente.ReadOnly = True
        txtidcliente.Visible = False
    End Sub

    Private Sub txtbuscarempleado_Click(sender As Object, e As EventArgs) Handles txtbuscarempleado.Click
        mostrarEmpleados.txtflag.Text = "1"
        mostrarEmpleados.ShowDialog()
    End Sub

    Private Sub btnBuscarCliente_MouseHover(sender As Object, e As EventArgs) Handles btnBuscarCliente.MouseHover

        ToolTip.SetToolTip(btnBuscarCliente, "Buscar en tabla Cliente")
        ToolTip.ToolTipTitle = "Buscar Cliente"
        ToolTip.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub txtbuscarempleado_MouseHover(sender As Object, e As EventArgs) Handles txtbuscarempleado.MouseHover
        ToolTip.SetToolTip(txtbuscarempleado, "Buscar en tabla Empleado")
        ToolTip.ToolTipTitle = "Buscar Empleado"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtnum_documento_Validating(sender As Object, e As CancelEventArgs) Handles txtnum_documento.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then    'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtnum_documento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnum_documento.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtidempleado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtidempleado.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnLimCli_Click(sender As Object, e As EventArgs) Handles btnLimCli.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea limpiar los datos del cliente?", "Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            txtidcliente.ReadOnly = False
            txtnombre_cliente.ReadOnly = False
            txtidcliente.Text = "1"
            txtidcliente.Visible = False
            'txtidcliente.Text = ""
            txtnombre_cliente.Text = ""
        Else

        End If
    End Sub

    Private Sub txtbuscar_TextChanged_1(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub

End Class
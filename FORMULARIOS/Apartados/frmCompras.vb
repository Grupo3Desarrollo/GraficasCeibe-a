Imports System.ComponentModel
Public Class frmCompras
    Dim conexion As New Conexion()
    Dim dt As New DataTable()
    Private Sub frmCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_compras()
        txtidproveedor.Visible = False
        txtidproveedor.ReadOnly = True
        txtproveedor.ReadOnly = True
    End Sub

    Private Sub ocultar_columnas()
        datalistado.Columns(2).Visible = False
        'datalistado.Columns(5).Visible = False
    End Sub

    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        txtidproveedor.ReadOnly = False
        txtproveedor.ReadOnly = False
        txtidproveedor.Visible = False
        txtproveedor.Text = ""
        txtidcompra.Text = ""
        txtbuscar.Text = ""
        txtdescrpcompra.Text = ""
    End Sub

    Public Sub mostrar_compras()
        Try
            Dim func As New Conexion
            dt = func.mostrarCompra
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
            dt = conexion.buscarCompra(num_documento)

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

    Private Sub cargar_detalle()
        frmDetalleCompras.txtidcompra.Text = Convert.ToString(datalistado.SelectedCells.Item(1).Value)
        frmDetalleCompras.txtidProv.Text = Convert.ToString(datalistado.SelectedCells.Item(2).Value)
        frmDetalleCompras.txtProv.Text = Convert.ToString(datalistado.SelectedCells.Item(3).Value)
        frmDetalleCompras.txtfecha.Text = Convert.ToString(datalistado.SelectedCells.Item(4).Value)

        frmDetalleCompras.ShowDialog()
    End Sub

    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        cargar_detalle()
    End Sub

    Private Sub insertarcompras()
        Dim idproveedor As Integer
        Dim fecha_compra As Date
        Dim Descripcion_compra As String
        fecha_compra = txtfecha.Text
        idproveedor = txtidproveedor.Text
        Descripcion_compra = txtdescrpcompra.Text

        Try
            If conexion.insertarCompra(fecha_compra, Descripcion_compra, idproveedor) Then
            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub editarCompra()
        Dim idcompra, idproveedor As Integer
        Dim fecha_compra As Date
        Dim Descripcion_compra As String
        idcompra = txtidcompra.Text
        fecha_compra = txtfecha.Text
        idproveedor = txtidproveedor.Text
        Descripcion_compra = txtdescrpcompra.Text

        Try
            If conexion.editarCompra(idcompra, fecha_compra, Descripcion_compra, idproveedor) Then
                MessageBox.Show("Compra modificada con Exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al modificar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtidproveedor.Text <> "" And txtidproveedor.Text <> "" And txtdescrpcompra.Text <> "" Then
            Try
                insertarcompras()
                mostrar_compras()
                limpiar()
                'cargar_detalle()
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

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        Dim FilaActual As Integer
        FilaActual = datalistado.CurrentRow.Index
        txtidcompra.Text = Convert.ToString(datalistado.Rows(FilaActual).Cells(1).Value)
        txtidproveedor.Text = Convert.ToString(datalistado.Rows(FilaActual).Cells(2).Value)
        txtproveedor.Text = Convert.ToString(datalistado.Rows(FilaActual).Cells(3).Value)
        txtfecha.Text = Convert.ToString(datalistado.Rows(FilaActual).Cells(4).Value)
        txtdescrpcompra.Text = Convert.ToString(datalistado.Rows(FilaActual).Cells(5).Value)
        btnguardar.Visible = False
        btneditar.Visible = True
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs)
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea editar los datos de la compra?", "Modifiar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtidcompra.Text <> "" And txtidproveedor.Text <> "" And txtidproveedor.Text <> "" And txtdescrpcompra.Text <> "" Then
                Try
                    editarCompra()
                    mostrar_compras()
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

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        mostrar_compras()
    End Sub

    Private Sub btnBuscarProve_Click(sender As Object, e As EventArgs) Handles btnBuscarProve.Click
        mostrarProveedor.txtflag.Text = "1"
        mostrarProveedor.ShowDialog()
        txtidproveedor.ReadOnly = True
        txtproveedor.ReadOnly = True
        txtidproveedor.Visible = False
    End Sub

    Private Sub btnLimPro_Click(sender As Object, e As EventArgs) Handles btnLimPro.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea limpiar los datos del Proveedor?", "Proveedor", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            txtidproveedor.ReadOnly = True
            txtproveedor.ReadOnly = True
            txtidproveedor.Visible = False
            txtidproveedor.Text = ""
            txtproveedor.Text = ""
        Else

        End If
    End Sub

    Private Sub btneditar_Click_1(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea editar los datos de la compra?", "Modifiar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtidcompra.Text <> "" And txtidproveedor.Text <> "" And txtidproveedor.Text <> "" And txtdescrpcompra.Text <> "" Then
                Try
                    editarCompra()
                    mostrar_compras()
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

    Private Sub btnBuscarProve_MouseHover(sender As Object, e As EventArgs) Handles btnBuscarProve.MouseHover
        ToolTip.SetToolTip(btnBuscarProve, "Buscar en tabla Proveedores")
        ToolTip.ToolTipTitle = "Buscar Proveedor"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub GroupBox2_MouseHover(sender As Object, e As EventArgs) Handles GroupBox2.MouseHover
        ToolTip.SetToolTip(GroupBox2, "Un click para editar, doble click para detalle")
        ToolTip.ToolTipTitle = "Seleccione una Compra"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class
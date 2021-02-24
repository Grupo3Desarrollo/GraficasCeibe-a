
Imports System.ComponentModel

Public Class frmClientes
    Dim conexion As New Conexion()
    Dim dt As New DataTable()

    Private Sub FrmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Public Sub mostrar()
        Try
            Dim func As New Conexion
            dt = func.mostrar
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

        buscar()
    End Sub
    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        txtnombre.Text = ""
        txtapellidos.Text = ""
        txtdireccion.Text = ""
        txttelefono.Text = ""
        txtdni.Text = ""
        txtbuscar.Text = ""
        txtidcliente.Text = ""
    End Sub
    Private Sub buscar()
        Try
            dt = conexion.busqueda(" cliente ", " dni like '%" + txtbuscar.Text + "%'")

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
    End Sub

    Private Sub insertarCliente()
        'Dim idcliente As Integer
        Dim direccion, telefono, dni As String
        Dim mayus, mayus1 As String

        mayus = txtnombre.Text
        Dim nombre As String = StrConv(mayus, VbStrConv.ProperCase)

        txtnombre.Text = nombre
        'nombre = txtNombre.Text
        mayus1 = txtapellidos.Text
        Dim apellidos As String = StrConv(mayus1, VbStrConv.ProperCase)
        direccion = txtdireccion.Text
        telefono = txttelefono.Text
        dni = txtdni.Text

        Try
            If conexion.insertarCliente(nombre, apellidos, direccion, telefono, dni) Then

            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub editarCliente()
        Dim idcliente As Integer
        Dim direccion, telefono, dni As String
        Dim mayus, mayus1 As String

        mayus = txtnombre.Text
        Dim nombre As String = StrConv(mayus, VbStrConv.ProperCase)

        txtnombre.Text = nombre

        mayus1 = txtapellidos.Text
        Dim apellidos As String = StrConv(mayus1, VbStrConv.ProperCase)
        idcliente = txtidcliente.Text
        direccion = txtdireccion.Text
        telefono = txttelefono.Text
        dni = txtdni.Text

        Try
            If conexion.editarCliente(idcliente, nombre, apellidos, direccion, telefono, dni) Then
                MessageBox.Show("Cliente modificado con Exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al modificar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtnombre.Text <> "" And txtapellidos.Text <> "" And txtdireccion.Text <> "" And txttelefono.Text <> "" And txtdni.Text <> "" Then
            Try
                insertarCliente()
                mostrar()
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
        mostrar()
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        Dim FilaActual As Integer
        FilaActual = datalistado.CurrentRow.Index
        txtidcliente.Text = datalistado.Rows(FilaActual).Cells(1).Value
        txtnombre.Text = datalistado.Rows(FilaActual).Cells(2).Value
        txtapellidos.Text = datalistado.Rows(FilaActual).Cells(3).Value
        txtdireccion.Text = datalistado.Rows(FilaActual).Cells(4).Value
        txttelefono.Text = datalistado.Rows(FilaActual).Cells(5).Value
        txtdni.Text = datalistado.Rows(FilaActual).Cells(6).Value
        btnguardar.Visible = False
        btneditar.Visible = True

    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea editar los datos del cliente?", "Modifiar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtnombre.Text <> "" And txtapellidos.Text <> "" And txtdireccion.Text <> "" And txttelefono.Text <> "" And txtdni.Text <> "" Then
                Try
                    editarCliente()
                    mostrar()
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

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub txttelefono_TextChanged(sender As Object, e As EventArgs) Handles txttelefono.TextChanged

    End Sub

    Private Sub txttelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelefono.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtdni_TextChanged(sender As Object, e As EventArgs) Handles txtdni.TextChanged

    End Sub

    Private Sub txtdni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdni.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged

    End Sub



End Class
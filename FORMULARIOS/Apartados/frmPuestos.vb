Imports System.ComponentModel
Public Class frmPuestos
    Dim conexion As New Conexion()
    Dim dt As New DataTable()
    Private Sub frmPuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_rol()
    End Sub

    Public Sub mostrar_rol()
        Try
            Dim func As New Conexion
            dt = func.mostrar_rol
            datalistado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                txtbuscar.Enabled = True
                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                datalistado.DataSource = Nothing
                txtbuscar.Enabled = False
                datalistado.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        buscar()
    End Sub

    Public Sub limpiar()
        btnguardar.Visible = True
        txtpuesto.Text = ""
        txtbuscar.Text = ""
    End Sub

    Private Sub buscar()
        Dim rol As String
        Try
            rol = txtbuscar.Text
            dt = conexion.buscarRol(rol)

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                conexion.conexion.Close()
            Else
                datalistado.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub insertarrol()
        Dim mayus As String

        mayus = txtpuesto.Text
        Dim rol As String = StrConv(mayus, VbStrConv.ProperCase)
        txtpuesto.Text = rol
        Try
            If conexion.insertarRol(rol) Then
                MessageBox.Show("Puesto ingresada con Exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtpuesto.Text <> "" Then
            Try
                insertarrol()
                mostrar_rol()
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
        mostrar_rol()
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub

    Private Sub txtpuesto_TextChanged(sender As Object, e As EventArgs) Handles txtpuesto.TextChanged

    End Sub

    Private Sub txtpuesto_Validating(sender As Object, e As CancelEventArgs) Handles txtpuesto.Validating
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
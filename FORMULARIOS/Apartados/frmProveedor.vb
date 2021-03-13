Imports System.ComponentModel
Public Class frmProveedor
    Dim conexion As New Conexion()
    Dim dt As New DataTable()


    Private Sub frmProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private Sub ocultar_columnas()
        datalistado.Columns(0).Visible = False
    End Sub

    Public Sub mostrar()
        Try
            Dim func As New Conexion
            dt = func.mostrarProveedor

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
        txtdescripProv.Text = ""
        txtciudad.Text = ""
        txttelefono.Text = ""
        txtbuscar.Text = ""
        txtidproveedor.Text = ""
    End Sub

    Private Sub buscar()
        Dim P_descripProv As String
        Try
            P_descripProv = txtbuscar.Text
            dt = conexion.buscarProveedor(P_descripProv)

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

    Private Sub insertarProv()
        Dim P_descripProv, P_ciudad As String
        Dim P_Tel As Integer
        P_descripProv = txtdescripProv.Text
        P_ciudad = txtciudad.Text
        P_Tel = txttelefono.Text

        Try
            If conexion.insertarProveedor(P_descripProv, P_ciudad, P_Tel) Then

            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub editarProveedor()
        Dim P_descripProv, P_ciudad As String
        Dim idProveedor, P_Tel As Integer
        idProveedor = txtidproveedor.Text
        P_descripProv = txtdescripProv.Text
        P_ciudad = txtciudad.Text
        P_Tel = txttelefono.Text

        Try
            If conexion.editarProveedor(idProveedor, P_descripProv, P_ciudad, P_Tel) Then
                MessageBox.Show("Proveedor modificado con Exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al modificar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtdescripProv.Text <> "" And txtciudad.Text <> "" And txttelefono.Text <> "" Then
            Try
                insertarProv()
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

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea editar los datos del Proveedor?", "Modifiar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtdescripProv.Text <> "" And txtciudad.Text <> "" And txttelefono.Text <> "" Then
                Try
                    editarProveedor()
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
        txtidproveedor.Text = datalistado.Rows(FilaActual).Cells(0).Value
        txtdescripProv.Text = datalistado.Rows(FilaActual).Cells(1).Value
        txtciudad.Text = datalistado.Rows(FilaActual).Cells(2).Value
        txttelefono.Text = datalistado.Rows(FilaActual).Cells(3).Value
        btnguardar.Visible = False
        btneditar.Visible = True
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

    Private Sub txtdescripProv_TextChanged(sender As Object, e As EventArgs) Handles txtdescripProv.TextChanged

    End Sub

    Private Sub txtdescripProv_Validating(sender As Object, e As CancelEventArgs) Handles txtdescripProv.Validating
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

    Private Sub txtciudad_TextChanged(sender As Object, e As EventArgs) Handles txtciudad.TextChanged

    End Sub

    Private Sub txtciudad_Validating(sender As Object, e As CancelEventArgs) Handles txtciudad.Validating
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

    Private Sub txttelefono_Validating(sender As Object, e As CancelEventArgs) Handles txttelefono.Validating
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

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
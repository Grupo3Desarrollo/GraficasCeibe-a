Imports System.ComponentModel
Public Class frmEmpleados
    Dim conexion As New Conexion()
    Dim dt As New DataTable()

    Private Sub frmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        btndespedir.Enabled = False
    End Sub

    Private Sub ocultar_columnas()
        datalistado.Columns(9).Visible = False
    End Sub

    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        txtidempleado.Text = ""
        txttelefono.Text = ""
        txtapellidos.Text = ""
        cmbSexo.Text = ""
        txtnombre.Text = ""
        txtcontra.Text = ""
        txtbuscar.Text = ""
    End Sub

    Public Sub mostrar()
        Try
            Dim func As New Conexion
            dt = func.mostrarEmpleados
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

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        mostrar()
        btndespedir.Enabled = False
    End Sub

    Private Sub insertarEmpleado()
        Dim identidad As String
        Dim Tel, estado, contrasena, rol As String
        Dim sexo As Char
        Dim fechanacimiento As Date
        Dim mayus, mayus1 As String

        identidad = txtidempleado.Text
        mayus = txtnombre.Text
        Dim nombres As String = StrConv(mayus, VbStrConv.ProperCase)

        txtnombre.Text = nombres
        mayus1 = txtapellidos.Text
        Dim apellidos As String = StrConv(mayus1, VbStrConv.ProperCase)
        fechanacimiento = txtfechaN.Text
        Tel = txttelefono.Text
        sexo = cmbSexo.Text
        rol = "Dependiente"
        estado = "Activo"
        contrasena = txtcontra.Text

        Try
            If conexion.insertar_Empleado(nombres, apellidos, fechanacimiento, Tel, sexo, estado, contrasena, identidad, rol) Then

            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtidempleado.Text <> "" And txtnombre.Text <> "" And txtapellidos.Text <> "" And txtfechaN.Text <> "" And txttelefono.Text <> "" And cmbSexo.Text <> "" And txtcontra.Text <> "" Then
            Try
                insertarEmpleado()
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

    Private Sub editarEmpleado()
        Dim idEmpleado As String
        Dim Tel, estado, contrasena, rol As String
        Dim sexo As Char
        Dim fechanacimiento As Date
        Dim mayus, mayus1 As String
        idEmpleado = txtidempleado.Text
        mayus = txtnombre.Text
        Dim nombres As String = StrConv(mayus, VbStrConv.ProperCase)

        txtnombre.Text = nombres
        mayus1 = txtapellidos.Text
        Dim apellidos As String = StrConv(mayus1, VbStrConv.ProperCase)
        fechanacimiento = txtfechaN.Text
        Tel = txttelefono.Text
        sexo = cmbSexo.Text
        rol = "Dependiente"
        estado = "Activo"
        contrasena = txtcontra.Text

        Try
            If conexion.editarEmpleado(nombres, apellidos, fechanacimiento, Tel, sexo, estado, contrasena, idEmpleado, rol) Then
                MessageBox.Show("Empleado modificado con Exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al modificar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub buscar()
        Try
            Dim UserName As String
            UserName = txtbuscar.Text
            dt = conexion.buscarEmpleado(UserName)
            datalistado.DataSource = If(dt.Rows.Count <> 0, dt, Nothing)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea editar los datos del Empleado?", "Modifiar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtidempleado.Text <> "" And txtnombre.Text <> "" And txtapellidos.Text <> "" And txtfechaN.Text <> "" And txttelefono.Text <> "" And cmbSexo.Text <> "" And txtcontra.Text <> "" Then
                Try
                    editarEmpleado()
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


    Private Sub eliminarEmpleado()
        Dim DNIEmpleado As String
        Dim rol As String
        DNIEmpleado = txtidempleado.Text
        rol = "Dependiente"
        Try
            If (conexion.eliminarEmpleado(DNIEmpleado, rol)) Then
                MsgBox("Empleado dado de baja")
            Else
                MsgBox("Error al dar de baja al Empleado")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btndespedir_Click(sender As Object, e As EventArgs) Handles btndespedir.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea despedir a este Empleado?", "Despedir Empleado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            eliminarEmpleado()
        Else
            limpiar()
        End If
    End Sub

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        Dim FilaActual As Integer
        FilaActual = datalistado.CurrentRow.Index
        txtnombre.Text = datalistado.Rows(FilaActual).Cells(2).Value
        txtapellidos.Text = datalistado.Rows(FilaActual).Cells(3).Value
        txtfechaN.Text = datalistado.Rows(FilaActual).Cells(4).Value
        txttelefono.Text = datalistado.Rows(FilaActual).Cells(5).Value
        cmbSexo.Text = datalistado.Rows(FilaActual).Cells(6).Value
        txtidempleado.Text = datalistado.Rows(FilaActual).Cells(1).Value
        btneditar.Visible = True
        btnguardar.Visible = False
        btndespedir.Enabled = True
    End Sub
    Private Sub txtidempleado_Validating(sender As Object, e As CancelEventArgs) Handles txtidempleado.Validating
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

    Private Sub txtapellidos_Validating(sender As Object, e As CancelEventArgs) Handles txtapellidos.Validating
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

    Private Sub cmbSexo_Validating(sender As Object, e As CancelEventArgs) Handles cmbSexo.Validating
        Try
            If DirectCast(sender, ComboBox).Text.Length > 0 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtcontra_Validating(sender As Object, e As CancelEventArgs) Handles txtcontra.Validating
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
End Class
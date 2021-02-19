Imports System.ComponentModel
Public Class frmEmpleados

    Dim conexion As New Conexion()
    Dim dt As New DataTable()
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
        rol = "Auxiliar"
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
        rol = "Auxiliar"
        estado = "Activo"
        contrasena = txtcontra.Text

        Try
            If conexion.editarEmpleado(idEmpleado, nombres, apellidos, fechanacimiento, Tel, sexo, rol, estado, contrasena) Then
                MessageBox.Show("Empleado modificado con Exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al modificar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub frmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        btndespedir.Enabled = False
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
        Try
            Dim UserName As String
            UserName = txtbuscar.Text
            dt = conexion.buscarEmpleado(UserName)
            datalistado.DataSource = If(dt.Rows.Count <> 0, dt, Nothing)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ocultar_columnas()
        datalistado.Columns(1).Visible = False
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

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        Dim FilaActual As Integer
        FilaActual = datalistado.CurrentRow.Index
        txtidempleado.Text = datalistado.Rows(FilaActual).Cells(8).Value
        txtnombre.Text = datalistado.Rows(FilaActual).Cells(1).Value
        txtapellidos.Text = datalistado.Rows(FilaActual).Cells(2).Value
        txtfechaN.Text = datalistado.Rows(FilaActual).Cells(3).Value
        txttelefono.Text = datalistado.Rows(FilaActual).Cells(4).Value
        cmbSexo.Text = datalistado.Rows(FilaActual).Cells(5).Value

        txtcontra.Text = datalistado.Rows(FilaActual).Cells(7).Value


        btnguardar.Visible = False
        btneditar.Visible = True
        btndespedir.Enabled = True
    End Sub

    Private Sub eliminarEmpleado()
        Dim DNIEmpleado As String
        Dim rol As String
        DNIEmpleado = txtidempleado.Text
        rol = "Auxiliar"
        Try
            If (conexion.eliminarUsuario(DNIEmpleado, rol)) Then
                MsgBox("Empleado dado de baja")
                'conexion.conexion.Close()
            Else
                MsgBox("Error al dar de baja al Empleado")
                'conexion.conexion.Close()
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
End Class
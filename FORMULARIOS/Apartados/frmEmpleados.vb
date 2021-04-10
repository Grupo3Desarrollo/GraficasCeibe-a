Imports System.ComponentModel
Public Class frmEmpleados
    Dim conexion As New Conexion()
    Dim dt As New DataTable()

    Private Sub frmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtcontra.UseSystemPasswordChar = True
        mostrar()
        llenarRol()
        txtestado.Visible = False
        btnDarBaja.Enabled = False
        btnActivar.Enabled = False
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
        txtestado.Text = ""
        Check.Checked = False
    End Sub

    Public Sub llenarRol()
        conexion.llenarRol()
        cmbRol.DataSource = conexion.datos.Tables("rol")
        cmbRol.DisplayMember = "rol"
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
        btnDarBaja.Enabled = False
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
        rol = cmbRol.Text
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
        rol = cmbRol.Text
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
        result = MessageBox.Show("Realmente desea editar los datos del Empleado(a)?", "Modifiar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

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
        rol = cmbRol.Text

        Try
            If (conexion.eliminarEmpleado(DNIEmpleado, rol)) Then
                MsgBox("Empleado dado de baja")
            Else
                MsgBox("Error al dar de baja al Empleado(a)")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub activarEmpleado()
        Dim DNIEmpleado As String
        Dim rol As String
        DNIEmpleado = txtidempleado.Text
        rol = cmbRol.Text
        Try
            If (conexion.activarEmpleado(DNIEmpleado, rol)) Then
                MsgBox("Empleado(a) restaurado en el sistema")
            Else
                MsgBox("Error al restaurar al Empleado(a)")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnActivar_Click(sender As Object, e As EventArgs) Handles btnActivar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea activar este empleado(a)?", "Activar Empleados", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            If txtestado.Text = "Activo" Then
                MessageBox.Show("Empleado(a) ya esta activo", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If cmbRol.Text = "Gerente" Then
                    MessageBox.Show("No se puede activar un Gerente", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    activarEmpleado()
                    mostrar()
                End If
            End If
        Else
                limpiar()
        End If
    End Sub

    Private Sub btnDarBaja_Click(sender As Object, e As EventArgs) Handles btnDarBaja.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea dar de baja a este Empleado(a)?", "Dar de Baja a Empleados", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            If txtestado.Text = "Inactivo" Then
                MessageBox.Show("El Empleado(a) ya esta dado de baja", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If cmbRol.Text = "Gerente" Then
                    MessageBox.Show("No se puede dar de baja al gerente", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    eliminarEmpleado()
                    mostrar()
                End If
            End If
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
        txtestado.Text = datalistado.Rows(FilaActual).Cells(7).Value
        cmbRol.Text = datalistado.Rows(FilaActual).Cells(8).Value
        txtidempleado.Text = datalistado.Rows(FilaActual).Cells(1).Value
        btneditar.Visible = True
        btnguardar.Visible = False
        btnDarBaja.Enabled = True
        btnActivar.Enabled = True
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

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged

    End Sub

    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre.KeyPress
        If Not Char.IsLetter(e.KeyChar) _
                     AndAlso Not Char.IsControl(e.KeyChar) _
                     AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtapellidos_TextChanged(sender As Object, e As EventArgs) Handles txtapellidos.TextChanged

    End Sub

    Private Sub txtapellidos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapellidos.KeyPress
        If Not Char.IsLetter(e.KeyChar) _
                     AndAlso Not Char.IsControl(e.KeyChar) _
                     AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Check_CheckedChanged(sender As Object, e As EventArgs) Handles Check.CheckedChanged
        Dim Text As String
        Text = txtcontra.Text
        If Check.Checked = True Then

            txtcontra.UseSystemPasswordChar = False
            txtcontra.Text = Text
        Else
            txtcontra.UseSystemPasswordChar = True
            txtcontra.Text = Text
        End If
    End Sub

    Private Sub btnPuesto_Click(sender As Object, e As EventArgs) Handles btnPuesto.Click
        frmPuestos.ShowDialog()
    End Sub

    Private Sub btnPuesto_MouseHover(sender As Object, e As EventArgs) Handles btnPuesto.MouseHover
        ToolTip.SetToolTip(btnPuesto, "Ingresar puestos")
        ToolTip.ToolTipTitle = "Formulario de Puestos"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtbuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbuscar.KeyPress
        If Not Char.IsLetter(e.KeyChar) _
                     AndAlso Not Char.IsControl(e.KeyChar) _
                     AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        llenarRol()
    End Sub

    Private Sub btnRefresh_MouseHover(sender As Object, e As EventArgs) Handles btnRefresh.MouseHover
        ToolTip.SetToolTip(btnRefresh, "Actualizar puestos")
        ToolTip.ToolTipTitle = "Puestos Agregados"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class
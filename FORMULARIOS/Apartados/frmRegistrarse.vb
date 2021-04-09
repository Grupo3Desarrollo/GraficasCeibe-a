Imports System.ComponentModel

Public Class frmRegistrarse
    Dim conexion As New Conexion()

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtidempleado.Text <> "" And txtidempleado.TextLength = 13 And txtnombre.Text <> "" And txtapellidos.Text <> "" And txtfechaN.Text <> "" And txttelefono.Text <> "" And cmbSexo.Text <> "" And txtcontra.Text <> "" Then
            Try
                insertarEmpleado()
                limpiar()
                Login.Show()
                Me.Hide()
                conexion.conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Revise los datos Ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub frmRegistrarse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtcontra.UseSystemPasswordChar = True
        llenarRol()
    End Sub

    Public Sub limpiar()
        txtidempleado.Text = ""
        txttelefono.Text = ""
        txtapellidos.Text = ""
        cmbSexo.Text = ""
        txtnombre.Text = ""
        txtcontra.Text = ""
        Check.Checked = False
    End Sub

    Public Sub llenarRol()
        conexion.llenarRol()
        cmbRol.DataSource = conexion.datos.Tables("rol")
        cmbRol.DisplayMember = "rol"
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
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
                MessageBox.Show("Empleado(a) ingresado con exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre.KeyPress
        If Not Char.IsLetter(e.KeyChar) _
                     AndAlso Not Char.IsControl(e.KeyChar) _
                     AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtapellidos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapellidos.KeyPress
        If Not Char.IsLetter(e.KeyChar) _
                     AndAlso Not Char.IsControl(e.KeyChar) _
                     AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Esta Seguro que quiere salir de registro?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            Me.Close()
            Login.Show()
        End If
    End Sub

    Private Sub btnPuesto_MouseHover(sender As Object, e As EventArgs) Handles btnPuesto.MouseHover
        ToolTip.SetToolTip(btnPuesto, "Ingresar puestos")
        ToolTip.ToolTipTitle = "Formulario de Puestos"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnPuesto_Click(sender As Object, e As EventArgs) Handles btnPuesto.Click
        frmPuestos.ShowDialog()
    End Sub
End Class
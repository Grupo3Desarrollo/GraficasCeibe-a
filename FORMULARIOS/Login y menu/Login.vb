Public Class Login
    Dim conexion As New Conexion()
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarRol()
    End Sub
    Private Sub limpiar()
        txtnombreusuario.Text = ""
        txtcontraseña.Text = ""
    End Sub
    Private Sub ingresoMenu()
        Dim DNI, psw, rol As String
        DNI = txtnombreusuario.Text
        rol = cmbrol.Text
        psw = txtcontraseña.Text
        Try
            If (conexion.validarUsuario(DNI, psw, rol)) Then
                If (rol = "Gerente") Then
                    MsgBox("Bienvenido(a) Gerente(a)")
                    Menuu.txtflag.Text = 1
                    limpiar()
                    Menuu.Show()
                    Me.Hide()
                ElseIf (rol = "Dependiente") Then
                    MsgBox("Bienvenido(a)")
                    Menuu.txtflag.Text = "2"
                    limpiar()
                    Menuu.Show()

                    Me.Hide()
                End If
            Else
                MsgBox("Datos incorrectos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub llenarRol()
        conexion.llenarRol()
        cmbrol.DataSource = conexion.datos.Tables("rol")
        cmbrol.DisplayMember = "rol"
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Esta Seguro que quiere salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Esta Seguro que quiere salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtnombreusuario.Text = "" And txtnombreusuario.Text.Length < 13 Then
            MsgBox("Ingrese un usuario valido")
        ElseIf txtcontraseña.Text = " " Then
            MsgBox("Ingrese su contraseña")
        Else
            ingresoMenu()
        End If
    End Sub
End Class

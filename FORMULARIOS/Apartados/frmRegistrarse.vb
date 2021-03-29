Public Class frmRegistrarse
    Dim conexion As New Conexion()

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtidempleado.Text <> "" And txtnombre.Text <> "" And txtapellidos.Text <> "" And txtfechaN.Text <> "" And txttelefono.Text <> "" And cmbSexo.Text <> "" And txtcontra.Text <> "" Then
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

            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
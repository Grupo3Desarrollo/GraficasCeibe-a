Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Public Class Menuu
    Dim conexion As New Conexion()
    Public cmb As SqlCommand

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Public Sub info_empleados()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Try
            conexion.conexion.Open()
            cmb = New SqlCommand("SELECT Nombres, Apellidos FROM Empleados WHERE DNIEmpleado =  '" + Empleados.info_empleados + "'", conexion.conexion)
            cmb.CommandType = CommandType.Text
            dt = New DataTable
            da = New SqlDataAdapter(cmb)
            da.Fill(dt)
            lblNombres.Text = dt.Rows(0)(0).ToString
            lblApellidos.Text = dt.Rows(0)(1).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmb = Nothing
            conexion.conexion.Close()
        End Try
    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        info_empleados()
        Me.WindowState = FormWindowState.Normal
        Me.Size = New System.Drawing.Size(1275, 630)

        If txtflag.Text = "2" Then
            btnempleados.Visible = False
            lempleado.Visible = False
            btnproveedor.Visible = False
            lproveedor.Visible = False
            btncompras.Visible = False
            lcompras.Visible = False
        End If
        abrirFormulario(frmhora)
    End Sub

    Private Sub abrirFormulario(ByVal formHijo As Object)
        If PanelForms.Controls.Count > 0 Then
            Me.PanelForms.Controls.RemoveAt(0)
        End If
        Dim frm As Form = TryCast(formHijo, Form)
        frm.TopLevel = False
        frm.Dock = DockStyle.Fill
        Me.PanelForms.Controls.Add(frm)
        Me.PanelForms.Tag = frm
        frm.Show()
    End Sub

    Private Sub btnlogohora_Click(sender As Object, e As EventArgs)
        abrirFormulario(frmhora)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        abrirFormulario(frmhora)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Esta Seguro que quiere salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            txtflag.Text = ""
            Me.Close()
            Login.Show()

        End If
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles BarraTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnempleados_Click(sender As Object, e As EventArgs) Handles btnempleados.Click
        abrirFormulario(frmEmpleados)
    End Sub

    Private Sub btncategoria_Click(sender As Object, e As EventArgs) Handles btncategoria.Click
        abrirFormulario(frmCategoria)
    End Sub

    Private Sub btnproductos_Click(sender As Object, e As EventArgs) Handles btnproductos.Click
        abrirFormulario(frmProducto)
    End Sub

    Private Sub btnclientes_Click(sender As Object, e As EventArgs) Handles btnclientes.Click
        abrirFormulario(frmClientes)
    End Sub

    Private Sub btnproveedor_Click(sender As Object, e As EventArgs) Handles btnproveedor.Click
        abrirFormulario(frmProveedor)
    End Sub

    Private Sub btnventas_Click(sender As Object, e As EventArgs) Handles btnventas.Click
        abrirFormulario(frmVenta)
    End Sub

    Private Sub btncompras_Click(sender As Object, e As EventArgs) Handles btncompras.Click
        abrirFormulario(frmCompras)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Esta Seguro que quiere salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            txtflag.Text = ""
            Me.Close()
            Login.Show()

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblCargo.Click

    End Sub
End Class
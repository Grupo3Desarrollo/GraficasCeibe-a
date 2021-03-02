Public Class frmVenta
    Private Sub txtnombre_cliente_TextChanged(sender As Object, e As EventArgs) Handles txtnombre_cliente.TextChanged

    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        MostrarClientes.txtflag.Text = "1"
        MostrarClientes.ShowDialog()
    End Sub

    Private Sub txtbuscarempleado_Click(sender As Object, e As EventArgs) Handles txtbuscarempleado.Click
        mostrarEmpleados.txtflag.Text = "1"
        mostrarEmpleados.ShowDialog()
    End Sub
End Class
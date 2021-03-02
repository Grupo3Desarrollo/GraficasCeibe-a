Public Class frmDetalleVenta
    Private Sub btnBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click
        mostrarProductos.txtflag.Text = "1"
        mostrarProductos.ShowDialog()
    End Sub
End Class
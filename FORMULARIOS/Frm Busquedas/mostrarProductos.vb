Imports System.ComponentModel
Public Class mostrarProductos
    Dim conexion As New Conexion()
    Dim dt As New DataTable()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub mostrarProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarProducto()
    End Sub

    Public Sub mostrarProducto()
        Try
            Dim func As New Conexion
            dt = func.mostrarProducto
            datalistado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt

                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False
                ocultar_columnas()
            Else
                datalistado.DataSource = Nothing

                datalistado.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ocultar_columnas()
        datalistado.Columns(1).Visible = False
        datalistado.Columns(2).Visible = False
        datalistado.Columns(10).Visible = False
    End Sub
    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        If txtflag.Text = "1" Then
            frmDetalleVenta.txtidproducto.Text = datalistado.SelectedCells.Item(1).Value
            frmDetalleVenta.txtnom_producto.Text = datalistado.SelectedCells.Item(4).Value
            frmDetalleVenta.txtstock.Text = datalistado.SelectedCells.Item(6).Value
            frmDetalleVenta.txtprecio_unitario.Text = datalistado.SelectedCells.Item(8).Value
            Me.Close()
        End If
        If txtflag.Text = "2" Then
            frmDetalleCompras.txtidproducto.Text = datalistado.SelectedCells.Item(1).Value
            frmDetalleCompras.txtnom_producto.Text = datalistado.SelectedCells.Item(4).Value
            Me.Close()
        End If
    End Sub

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        Dim FilaActual As Integer
        FilaActual = datalistado.CurrentRow.Index
        imagen.BackgroundImage = Nothing
        Dim b() As Byte = datalistado.Rows(FilaActual).Cells(10).Value
        Dim ms As New IO.MemoryStream(b)
        imagen.Image = Image.FromStream(ms)
        imagen.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
End Class
Public Class mostrarCategoria
    Dim conexion As New Conexion()
    Dim dt As New DataTable()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Public Sub mostrar_categoria()
        Try
            Dim func As New Conexion
            dt = func.mostrar_categoria
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
    End Sub

    Private Sub MostrarCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_categoria()
        txtflag.Visible = False
    End Sub



    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        If txtflag.Text = "1" Then
            frmProducto.txtidcategoria.Text = datalistado.SelectedCells.Item(1).Value
            frmProducto.txtnom_categoria.Text = datalistado.SelectedCells.Item(2).Value
            Me.Close()
        End If
    End Sub
End Class
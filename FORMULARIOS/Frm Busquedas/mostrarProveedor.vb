Imports System.ComponentModel

Public Class mostrarProveedor
    Dim conexion As New Conexion()
    Dim dt As New DataTable()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub mostrarProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Public Sub mostrar()
        Try
            Dim func As New Conexion
            dt = func.mostrarProveedor

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt

                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False

            Else
                datalistado.DataSource = Nothing

                datalistado.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick

    End Sub

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick

    End Sub

    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        If txtflag.Text = "1" Then
            frmCompras.txtidproveedor.Text = datalistado.SelectedCells.Item(0).Value
            frmCompras.txtproveedor.Text = datalistado.SelectedCells.Item(1).Value
            Me.Close()
        End If
    End Sub
End Class
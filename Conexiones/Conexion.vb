Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Conexion
    'Public conexion As SqlConnection = New SqlConnection("Data Source= DESKTOP-6LV81RN;Initial Catalog=GraficasC; user id = sa; password = Aleman16848760")
    Public conexion As SqlConnection = New SqlConnection("Data Source=DESKTOP-I773KQU;Initial Catalog=BaseDisenos; Integrated Security=True")
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public cmb As SqlCommand
    Public dr As SqlDataReader
    Public datos As DataSet
    Dim des As New TripleDESCryptoServiceProvider
    Dim MD5 As New MD5CryptoServiceProvider

    Function MD5Hash(ByVal value As String) As Byte()
        Return MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value))
    End Function

    Function Encrypt(ByVal Stringinput As String, ByVal key As String) As String
        des.Key = MD5Hash(key)
        des.Mode = CipherMode.ECB
        Dim buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(Stringinput)
        Return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length))
    End Function


    Public Sub conectar()
        Try
            conexion.Open()
            MessageBox.Show("Conectado")
        Catch ex As Exception
            MessageBox.Show("Error al conectar")
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Sub llenarRol()
        conexion.Open()
        da = New SqlDataAdapter("SELECT * FROM Rol", conexion)
        datos = New DataSet
        datos.Tables.Add("Rol")
        da.Fill(datos.Tables("Rol"))
        conexion.Close()
    End Sub

    Public Function validarUsuario(DNI As String, psw As String, rol As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("validarUsuario", conexion)
            cmb.CommandType = 4
            cmb.Parameters.AddWithValue("@DNI", DNI)
            cmb.Parameters.AddWithValue("@psw", Encrypt(psw, "abc"))
            cmb.Parameters.AddWithValue("@rol", rol)
            If cmb.ExecuteNonQuery <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
            MsgBox(ex.Message)
        Finally
            conexion.Close()
        End Try
    End Function
    ' *************************************** Categoria ********************************************
    ' MOSTRAR CATEGORIA
    Public Function mostrar_categoria() As DataTable
        Try
            conexion.Open()
            cmb = New SqlCommand("mostrar_categoria", conexion)
            cmb.CommandType = CommandType.StoredProcedure

            cmb.Connection = conexion

            If cmb.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmb)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function

    'INSERTAR CATEGORIA
    Public Function insertarCategoria(nombre_categoria As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("insertar_categoria", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@nombre_categoria", nombre_categoria)
            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try

    End Function

    'EDITAR CATEGORIA
    Public Function editarCategoria(idcategoria As Integer, nombre_categoria As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("editar_categoria", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@idcategoria", idcategoria)
            cmb.Parameters.AddWithValue("@nombre_categoria", nombre_categoria)
            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try

    End Function

    'bUSCAR CATEGORIA
    Public Function buscarCategoria(nombre_categoria As String) As DataTable
        Try
            conexion.Open()
            Dim cmb As New SqlCommand("buscarCategoria", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@nombre_categoria", nombre_categoria)
            If cmb.ExecuteNonQuery <> 0 Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmb)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function


    ' *************************************** PRODUCTOS *********************************************
    '                                           C R U D 
    ' FUNCION MOSTRAR PRODUCTOS
    Public Function mostrarProducto() As DataTable
        Try
            conexion.Open()
            cmb = New SqlCommand("mostrar_producto", conexion)
            cmb.CommandType = CommandType.StoredProcedure

            cmb.Connection = conexion

            If cmb.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmb)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function

    ' INSERTAR PRODUCTO
    Public Function insertarProducto(idcategoria As Integer, nombre As String, descripcion As String, stock As Double, precio_compra As Double, precio_venta As Double, fecha_vencimiento As Date, imagen() As Byte)
        Try
            conexion.Open()
            cmb = New SqlCommand("insertar_producto", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@idcategoria", idcategoria)
            cmb.Parameters.AddWithValue("@nombre", nombre)
            cmb.Parameters.AddWithValue("@descripcion", descripcion)
            cmb.Parameters.AddWithValue("@stock", stock)
            cmb.Parameters.AddWithValue("@precio_compra", precio_compra)
            cmb.Parameters.AddWithValue("@precio_venta", precio_venta)
            cmb.Parameters.AddWithValue("@fecha_vencimiento", fecha_vencimiento)
            cmb.Parameters.AddWithValue("@imagen", imagen)
            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try

    End Function


    ' EDITAR PRODUCTO
    Public Function editarproducto(idproducto As Integer, idcategoria As Integer, nombre As String, descripcion As String, stock As Double, precio_compra As Double, precio_venta As Double, fecha_vencimiento As Date, imagen() As Byte)
        Try
            conexion.Open()
            cmb = New SqlCommand("editar_producto", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@idproducto", idproducto)
            cmb.Parameters.AddWithValue("@idcategoria", idcategoria)
            cmb.Parameters.AddWithValue("@nombre", nombre)
            cmb.Parameters.AddWithValue("@descripcion", descripcion)
            cmb.Parameters.AddWithValue("@stock", stock)
            cmb.Parameters.AddWithValue("@precio_compra", precio_compra)
            cmb.Parameters.AddWithValue("@precio_venta", precio_venta)
            cmb.Parameters.AddWithValue("@fecha_vencimiento", fecha_vencimiento)
            cmb.Parameters.AddWithValue("@imagen", imagen)

            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    ' bUSCAR PRODUCTO
    Public Function buscarProducto(nombre As String) As DataTable
        Try
            conexion.Open()
            Dim cmb As New SqlCommand("buscarProducto", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@nombre", nombre)
            If cmb.ExecuteNonQuery <> 0 Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmb)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function

End Class


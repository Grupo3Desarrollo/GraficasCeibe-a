Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Conexion
    'Public conexion As SqlConnection = New SqlConnection("Data Source= DESKTOP-6LV81RN;Initial Catalog=GraficasC; user id = sa; password = Aleman16848760")
    Public conexion As SqlConnection = New SqlConnection("Data Source= DESKTOP-8VGV6BL;Initial Catalog=GraficaLCB; Integrated Security=True")
    Private cmba As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public cmb As SqlCommand
    Public dr As SqlDataReader
    Private dv As New DataView
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
        da = New SqlDataAdapter("SELECT * FROM Roles", conexion)
        datos = New DataSet
        datos.Tables.Add("Roles")
        da.Fill(datos.Tables("Roles"))
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

    ' ************************************************ EMPLEADOS ****************************************************
    Public Function insertar_Empleado(Nombres As String, Apellidos As String, FechaNacimiento As Date, Telefono As String, Sexo As Char, estado As String, contrasena As String, DNIEmpleado As String, rol As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("insertar_Empleado", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@Nombres", Nombres)
            cmb.Parameters.AddWithValue("@Apellidos", Apellidos)
            cmb.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento)
            cmb.Parameters.AddWithValue("@Tel", Telefono)
            cmb.Parameters.AddWithValue("@Sexo", Sexo)
            cmb.Parameters.AddWithValue("@Estado", estado)
            cmb.Parameters.AddWithValue("@contrasena", Encrypt(contrasena, "abc"))
            cmb.Parameters.AddWithValue("@DNI", DNIEmpleado)
            cmb.Parameters.AddWithValue("@Rol", rol)
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

    Public Function editarEmpleado(Nombres As String, Apellidos As String, FechaNacimiento As Date, Telefono As String, Sexo As Char, estado As String, contrasena As String, DNIEmpleado As String, rol As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("editar_Empleado", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@Nombres", Nombres)
            cmb.Parameters.AddWithValue("@Apellidos", Apellidos)
            cmb.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento)
            cmb.Parameters.AddWithValue("@Tel", Telefono)
            cmb.Parameters.AddWithValue("@Sexo", Sexo)
            cmb.Parameters.AddWithValue("@Estado", estado)
            cmb.Parameters.AddWithValue("@contrasena", Encrypt(contrasena, "abc"))
            cmb.Parameters.AddWithValue("@DNI", DNIEmpleado)
            cmb.Parameters.AddWithValue("@Rol", rol)

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

    Public Function eliminarEmpleado(DNIEmpleado As String, rol As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("eliminar_Empleado", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@DNI", DNIEmpleado)
            cmb.Parameters.AddWithValue("@Rol", rol)
            If cmb.ExecuteNonQuery <> 0 Then
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

    Public Function buscarEmpleado(UserName As String) As DataTable
        Try
            conexion.Open()
            Dim cmb As New SqlCommand("buscarEmpleado", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@UserName", UserName)
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

    Public Function mostrarEmpleados() As DataTable
        Try
            conexion.Open()
            cmb = New SqlCommand("Mostrar_Empleado", conexion)
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

    Public Function mostrarEmpleadosActivos() As DataTable
        Try
            conexion.Open()
            cmb = New SqlCommand("Mostrar_EmpleadoActivo", conexion)
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

    ' *************************************** Categoria ********************************************
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

    'BUSCAR CATEGORIA
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
    ' FUNCION MOSTRAR PRODUCTO
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

    ' BUSCAR PRODUCTO
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

    'Proveedor
    Public Function insertarProveedor(P_descripProv As String, P_ciudad As String, P_Tel As Integer)
        Try
            conexion.Open()
            cmb = New SqlCommand("insertar_Proveedor", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@P_descripProv", P_descripProv)
            cmb.Parameters.AddWithValue("@P_ciudad", P_ciudad)
            cmb.Parameters.AddWithValue("@P_Tel", P_Tel)


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

    Public Function editarProveedor(idProveedor As Integer, P_descripProv As String, P_ciudad As String, P_Tel As Integer)
        Try
            conexion.Open()
            cmb = New SqlCommand("editar_Proveedor", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@idProveedor", idProveedor)
            cmb.Parameters.AddWithValue("@P_descripProv", P_descripProv)
            cmb.Parameters.AddWithValue("@P_ciudad", P_ciudad)
            cmb.Parameters.AddWithValue("@P_Tel", P_Tel)

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

    Public Function mostrarProveedor() As DataTable
        Try
            conexion.Open()
            cmb = New SqlCommand("mostrar_proveedor", conexion)
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

    Public Function buscarProveedor(P_descripProv As String) As DataTable
        Try
            conexion.Open()
            Dim cmb As New SqlCommand("buscarProveedor", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@P_descripProv", P_descripProv)
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

    'Clientes
    Public Function mostrar() As DataTable
        Try
            conexion.Open()
            cmb = New SqlCommand("mostrar_cliente", conexion)
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

    Public Function insertarCliente(nombre As String, apellidos As String, correo As String, direccion As String, telefono As String, dni As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("insertar_cliente", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@nombre", nombre)
            cmb.Parameters.AddWithValue("@apellidos", apellidos)
            cmb.Parameters.AddWithValue("@correo", correo)
            cmb.Parameters.AddWithValue("@direccion", direccion)
            cmb.Parameters.AddWithValue("@telefono", telefono)
            cmb.Parameters.AddWithValue("@dni", dni)

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

    Public Function editarCliente(idcliente As Integer, nombre As String, apellidos As String, correo As String, direccion As String, telefono As String, dni As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("editar_cliente", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@idcliente", idcliente)
            cmb.Parameters.AddWithValue("@nombre", nombre)
            cmb.Parameters.AddWithValue("@apellidos", apellidos)
            cmb.Parameters.AddWithValue("@correo", correo)
            cmb.Parameters.AddWithValue("@direccion", direccion)
            cmb.Parameters.AddWithValue("@telefono", telefono)
            cmb.Parameters.AddWithValue("@dni", dni)

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
    Function busqueda(ByVal tabla, ByVal condicion) As DataTable
        Try
            conexion.Open()
            Dim buscar As String = "select * from " + tabla + " where " + condicion
            Dim cmd As New SqlCommand(buscar, conexion)
            If cmd.ExecuteNonQuery Then
                Dim dv As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dv)
                Return dv
            Else
                Return Nothing
            End If
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


End Class
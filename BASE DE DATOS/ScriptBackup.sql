USE [master]
GO
/****** Object:  Database [GraficaLCB]    Script Date: 3/6/2021 3:18:42 AM ******/
CREATE DATABASE [GraficaLCB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GraficaLCB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\GraficaLCB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GraficaLCB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\GraficaLCB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [GraficaLCB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GraficaLCB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GraficaLCB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GraficaLCB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GraficaLCB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GraficaLCB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GraficaLCB] SET ARITHABORT OFF 
GO
ALTER DATABASE [GraficaLCB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GraficaLCB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GraficaLCB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GraficaLCB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GraficaLCB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GraficaLCB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GraficaLCB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GraficaLCB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GraficaLCB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GraficaLCB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [GraficaLCB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GraficaLCB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GraficaLCB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GraficaLCB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GraficaLCB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GraficaLCB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GraficaLCB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GraficaLCB] SET RECOVERY FULL 
GO
ALTER DATABASE [GraficaLCB] SET  MULTI_USER 
GO
ALTER DATABASE [GraficaLCB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GraficaLCB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GraficaLCB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GraficaLCB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GraficaLCB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GraficaLCB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'GraficaLCB', N'ON'
GO
ALTER DATABASE [GraficaLCB] SET QUERY_STORE = OFF
GO
USE [GraficaLCB]
GO
/****** Object:  Table [dbo].[categorias]    Script Date: 3/6/2021 3:18:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categorias](
	[idcategoria] [int] IDENTITY(1,1) NOT NULL,
	[nombre_categoria] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idcategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 3/6/2021 3:18:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[idcliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellidos] [varchar](50) NOT NULL,
	[correo] [nvarchar](50) NOT NULL,
	[direccion] [varchar](100) NULL,
	[telefono] [varchar](9) NULL,
	[dni] [nvarchar](13) NULL,
PRIMARY KEY CLUSTERED 
(
	[idcliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compras]    Script Date: 3/6/2021 3:18:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compras](
	[idCompra] [int] IDENTITY(1,1) NOT NULL,
	[fecha_compra] [date] NOT NULL,
	[Descripcion_compra] [nvarchar](70) NOT NULL,
	[idproducto] [int] NOT NULL,
	[idProveedor] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalles_compras]    Script Date: 3/6/2021 3:18:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalles_compras](
	[idCompra] [int] NOT NULL,
	[idproducto] [int] NOT NULL,
	[precio_Compra] [decimal](10, 2) NOT NULL,
	[cantidad_Compra] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCompra] ASC,
	[idproducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalles_ventas]    Script Date: 3/6/2021 3:18:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalles_ventas](
	[idventa] [int] NOT NULL,
	[idproducto] [int] NOT NULL,
	[precio_V] [decimal](10, 2) NOT NULL,
	[cantidad] [decimal](10, 2) NOT NULL,
	[subtotal] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[idventa] ASC,
	[idproducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 3/6/2021 3:18:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[idEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [varchar](30) NOT NULL,
	[Apellidos] [varchar](30) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Tel] [varchar](9) NOT NULL,
	[Sexo] [char](1) NOT NULL,
	[Estado] [varchar](20) NOT NULL,
	[contrasenia] [nvarchar](30) NOT NULL,
	[DNIEmpleado] [nvarchar](13) NOT NULL,
	[rol] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[productos]    Script Date: 3/6/2021 3:18:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productos](
	[idproducto] [int] IDENTITY(1,1) NOT NULL,
	[idcategoria] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[stock] [decimal](10, 2) NULL,
	[precio_compra] [decimal](10, 2) NOT NULL,
	[precio_venta] [decimal](10, 2) NOT NULL,
	[fecha_vencimiento] [date] NOT NULL,
	[imagen] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[idproducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 3/6/2021 3:18:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[idProveedor] [int] IDENTITY(1,1) NOT NULL,
	[P_descripProv] [varchar](20) NOT NULL,
	[P_ciudad] [varchar](30) NOT NULL,
	[P_Tel] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 3/6/2021 3:18:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[rol] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ventas]    Script Date: 3/6/2021 3:18:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ventas](
	[idventa] [int] IDENTITY(1,1) NOT NULL,
	[fecha_venta] [date] NOT NULL,
	[num_documento] [varchar](50) NOT NULL,
	[idEmpleado] [int] NOT NULL,
	[idcliente] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idventa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Empleados] ON 

INSERT [dbo].[Empleados] ([idEmpleado], [Nombres], [Apellidos], [FechaNacimiento], [Tel], [Sexo], [Estado], [contrasenia], [DNIEmpleado], [rol]) VALUES (1, N'Jonathan Alexis', N'Aleman Linares', CAST(N'1998-05-09' AS Date), N'96693357', N'M', N'Activo', N'Y8msdnxDm9U=', N'0101199804248', N'Gerente')
INSERT [dbo].[Empleados] ([idEmpleado], [Nombres], [Apellidos], [FechaNacimiento], [Tel], [Sexo], [Estado], [contrasenia], [DNIEmpleado], [rol]) VALUES (2, N'Hugo Geovany', N'Murillo Urbina', CAST(N'2000-02-17' AS Date), N'96693300', N'M', N'Activo', N'Y8msdnxDm9U=', N'1807200000429', N'Dependiente')
SET IDENTITY_INSERT [dbo].[Empleados] OFF
GO
INSERT [dbo].[Roles] ([rol]) VALUES (N'Dependiente')
INSERT [dbo].[Roles] ([rol]) VALUES (N'Gerente')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__clientes__2A16D9453E998042]    Script Date: 3/6/2021 3:18:42 AM ******/
ALTER TABLE [dbo].[clientes] ADD UNIQUE NONCLUSTERED 
(
	[telefono] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__clientes__2A586E0B5296870E]    Script Date: 3/6/2021 3:18:42 AM ******/
ALTER TABLE [dbo].[clientes] ADD UNIQUE NONCLUSTERED 
(
	[correo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__clientes__D87608A7AAF89E35]    Script Date: 3/6/2021 3:18:42 AM ******/
ALTER TABLE [dbo].[clientes] ADD UNIQUE NONCLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Empleado__C451FA8D8900BC60]    Script Date: 3/6/2021 3:18:42 AM ******/
ALTER TABLE [dbo].[Empleados] ADD UNIQUE NONCLUSTERED 
(
	[Tel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Empleado__CECE101EFB668EA7]    Script Date: 3/6/2021 3:18:42 AM ******/
ALTER TABLE [dbo].[Empleados] ADD UNIQUE NONCLUSTERED 
(
	[DNIEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UQ__Proveedo__0B14B08CA09014A7]    Script Date: 3/6/2021 3:18:42 AM ******/
ALTER TABLE [dbo].[Proveedores] ADD UNIQUE NONCLUSTERED 
(
	[P_Tel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Proveedo__272070CA0A0F8E82]    Script Date: 3/6/2021 3:18:42 AM ******/
ALTER TABLE [dbo].[Proveedores] ADD UNIQUE NONCLUSTERED 
(
	[P_descripProv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD  CONSTRAINT [FK_IDproductoDos] FOREIGN KEY([idproducto])
REFERENCES [dbo].[productos] ([idproducto])
GO
ALTER TABLE [dbo].[Compras] CHECK CONSTRAINT [FK_IDproductoDos]
GO
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD  CONSTRAINT [FK_IDProveedor] FOREIGN KEY([idProveedor])
REFERENCES [dbo].[Proveedores] ([idProveedor])
GO
ALTER TABLE [dbo].[Compras] CHECK CONSTRAINT [FK_IDProveedor]
GO
ALTER TABLE [dbo].[detalles_compras]  WITH CHECK ADD  CONSTRAINT [FK_IDCompra] FOREIGN KEY([idCompra])
REFERENCES [dbo].[Compras] ([idCompra])
GO
ALTER TABLE [dbo].[detalles_compras] CHECK CONSTRAINT [FK_IDCompra]
GO
ALTER TABLE [dbo].[detalles_compras]  WITH CHECK ADD  CONSTRAINT [FK_IDproduc] FOREIGN KEY([idproducto])
REFERENCES [dbo].[productos] ([idproducto])
GO
ALTER TABLE [dbo].[detalles_compras] CHECK CONSTRAINT [FK_IDproduc]
GO
ALTER TABLE [dbo].[detalles_ventas]  WITH CHECK ADD  CONSTRAINT [FK_IDproducto] FOREIGN KEY([idproducto])
REFERENCES [dbo].[productos] ([idproducto])
GO
ALTER TABLE [dbo].[detalles_ventas] CHECK CONSTRAINT [FK_IDproducto]
GO
ALTER TABLE [dbo].[detalles_ventas]  WITH CHECK ADD  CONSTRAINT [FK_IDventa] FOREIGN KEY([idventa])
REFERENCES [dbo].[ventas] ([idventa])
GO
ALTER TABLE [dbo].[detalles_ventas] CHECK CONSTRAINT [FK_IDventa]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_ROL] FOREIGN KEY([rol])
REFERENCES [dbo].[Roles] ([rol])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_ROL]
GO
ALTER TABLE [dbo].[productos]  WITH CHECK ADD  CONSTRAINT [FK_IDcategoria] FOREIGN KEY([idcategoria])
REFERENCES [dbo].[categorias] ([idcategoria])
GO
ALTER TABLE [dbo].[productos] CHECK CONSTRAINT [FK_IDcategoria]
GO
ALTER TABLE [dbo].[ventas]  WITH CHECK ADD  CONSTRAINT [FK_IDcliente] FOREIGN KEY([idcliente])
REFERENCES [dbo].[clientes] ([idcliente])
GO
ALTER TABLE [dbo].[ventas] CHECK CONSTRAINT [FK_IDcliente]
GO
ALTER TABLE [dbo].[ventas]  WITH CHECK ADD  CONSTRAINT [FK_IDempleado] FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[Empleados] ([idEmpleado])
GO
ALTER TABLE [dbo].[ventas] CHECK CONSTRAINT [FK_IDempleado]
GO
/****** Object:  StoredProcedure [dbo].[buscarCategoria]    Script Date: 3/6/2021 3:18:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscarCategoria]
@nombre_categoria VARCHAR(50)
as
SELECT idcategoria as 'Codigo Categoria',nombre_categoria as 'Nombre Categoria' FROM categorias
WHERE nombre_categoria LIKE '%' +@nombre_categoria+ '%'
GO
/****** Object:  StoredProcedure [dbo].[buscarCliente]    Script Date: 3/6/2021 3:18:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscarCliente]
@dni NVARCHAR(13)
as
SELECT idcliente as 'Codigo',nombre as 'Nombre Cliente', apellidos as 'Apellidos Cliente',telefono as 'Telefono',dni as 'Identidad' 
FROM cliente
WHERE (CONCAT(Nombres, '',Apellidos) LIKE '%' +@dni+ '%') OR dni LIKE '%' +@dni+ '%'
GO
/****** Object:  StoredProcedure [dbo].[buscarEmpleado]    Script Date: 3/6/2021 3:18:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscarEmpleado]
@UserName VARCHAR(25)
as
SELECT Nombres as 'Nombres',Apellidos as 'Apellidos', FechaNacimiento AS 'Fecha de Nacimiento', tel As 'Telefono', Sexo as 'Sexo', estado as 'Estado',DNIEmpleado as 'Identidad', rol as 'Rol'
	   FROM Empleados 
WHERE (CONCAT(Nombres, '',Apellidos) LIKE '%' +@UserName+ '%') OR DNIEmpleado LIKE '%' +@UserName+ '%'
GO
/****** Object:  StoredProcedure [dbo].[buscarProducto]    Script Date: 3/6/2021 3:18:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscarProducto]
@nombre VARCHAR (50)
as
SELECT pro.idproducto as 'Codigo producto', pro.idcategoria as 'Codigo categoria', cat.nombre_categoria as 'Categoria', pro.nombre as 'Producto',pro.descripcion as 'Descripcion',pro.stock as 'Stock',pro.precio_compra as 'Precio de compra',pro.precio_venta as 'Precio de venta',pro.fecha_vencimiento as 'Fecha de vencimiento',pro.imagen as 'Imagen'
FROM productos as pro inner join categorias as cat on pro.idcategoria = cat.idcategoria
WHERE pro.nombre LIKE '%' +@nombre+ '%'
GO
/****** Object:  StoredProcedure [dbo].[buscarProveedor]    Script Date: 3/6/2021 3:18:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscarProveedor]
@P_descripProv VARCHAR(20)
as
	SELECT
	      idProveedor as 'Codigo Proveedor', P_descripProv as 'Descripcion del Proveedor', P_ciudad as 'Ciudad', P_Tel as 'Telefono'
    FROM Proveedores
WHERE P_descripProv LIKE '%' +@P_descripProv+ '%'
GO
/****** Object:  StoredProcedure [dbo].[buscarVenta]    Script Date: 3/6/2021 3:18:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscarVenta]
@num_documento as VARCHAR(50)
as
SELECT   dbo.ventas.idventa as 'Codigo Venta', dbo.ventas.idcliente 'Codigo Cliente', dbo.clientes.nombre as 'Nombre Cliente', dbo.clientes.apellidos as 'Apellidos Cliente', dbo.clientes.dni as 'Identidad Cliente', dbo.ventas.fecha_venta as 'Fecha de la venta', dbo.ventas.num_documento as 'Numero de Documento', dbo.Empleados.Nombres as 'Nombre Empleado', dbo.Empleados.Apellidos as 'Apellidos Empleado'
FROM     dbo.ventas INNER JOIN
             dbo.clientes ON dbo.ventas.idcliente = dbo.clientes.idcliente
			 inner join 
			 dbo.Empleados ON dbo.ventas.idEmpleado = dbo.Empleados.idEmpleado
WHERE num_documento LIKE '%' +@num_documento+ '%'
GO
/****** Object:  StoredProcedure [dbo].[editar_categoria]    Script Date: 3/6/2021 3:18:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[editar_categoria]
    @idcategoria INT,
	@nombre_categoria VARCHAR(50)
	as
    UPDATE categorias SET nombre_categoria = @nombre_categoria
     WHERE idcategoria = @idcategoria
GO
/****** Object:  StoredProcedure [dbo].[editar_cliente]    Script Date: 3/6/2021 3:18:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[editar_cliente]
    @idcliente INT, 
	@nombre as VARCHAR(50),
	@apellidos VARCHAR(50),
	@correo NVARCHAR(50),
	@direccion VARCHAR(100),
	@telefono VARCHAR(9),
	@dni NVARCHAR(13)
	as
	   UPDATE cliente SET nombre = @nombre, apellidos = @apellidos, correo=@correo, direccion = @direccion, telefono = @telefono,dni = @dni
	   WHERE idcliente = @idcliente
GO
/****** Object:  StoredProcedure [dbo].[editar_Empleado]    Script Date: 3/6/2021 3:18:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[editar_Empleado]
	@Nombres as VARCHAR(30),
	@Apellidos as VARCHAR(30),
	@FechaNacimiento as DATE,
	@Tel as VARCHAR(9),
	@Sexo as CHAR(1), 
	@Estado as VARCHAR(20),
	@contrasena as NVARCHAR(30),
	@DNI as NVARCHAR(13),
	@Rol as VARCHAR(30)
	AS 
	   UPDATE Empleados SET Nombres=@Nombres, Apellidos=@Apellidos, FechaNacimiento=@FechaNacimiento, tel=@Tel, Sexo=@Sexo, estado=@Estado, contrasenia=@contrasena, DNIEmpleado=@DNI, rol=@Rol
	   WHERE DNIEmpleado=@DNI
GO
/****** Object:  StoredProcedure [dbo].[editar_producto]    Script Date: 3/6/2021 3:18:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[editar_producto]
@idproducto INT,
@idcategoria INT,
@nombre VARCHAR (50),
@descripcion VARCHAR (50),
@stock decimal (10,2),
@precio_compra decimal (10,2),
@precio_venta decimal (10,2),
@fecha_vencimiento DATE,
@imagen image
as
UPDATE productos SET idcategoria=@idcategoria, nombre=@nombre, descripcion=@descripcion, stock=@stock, precio_compra=@precio_compra,	precio_venta=@precio_venta, fecha_vencimiento=@fecha_vencimiento, imagen=@imagen
WHERE idproducto=@idproducto
GO
/****** Object:  StoredProcedure [dbo].[editar_Proveedor]    Script Date: 3/6/2021 3:18:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[editar_Proveedor]
    @idProveedor INT,
	@P_descripProv VARCHAR(20),
	@P_ciudad VARCHAR(30),
	@P_Tel INT
	as
	   UPDATE Proveedores SET P_descripProv=@P_descripProv, P_ciudad=@P_ciudad, P_Tel=@P_Tel
	   WHERE idProveedor = @idProveedor
GO
/****** Object:  StoredProcedure [dbo].[editar_venta]    Script Date: 3/6/2021 3:18:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[editar_venta]
@idventa as INT,
@idcliente as INT,
@fecha_venta as DATE,
@num_documento as VARCHAR(50),
@idEmpleado as NVARCHAR(13)
as
UPDATE ventas SET idcliente=@idcliente,fecha_venta=@fecha_venta,num_documento=@num_documento, idEmpleado=@idEmpleado
WHERE idventa=@idventa
GO
/****** Object:  StoredProcedure [dbo].[eliminar_Empleado]    Script Date: 3/6/2021 3:18:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[eliminar_Empleado]
@DNI as NVARCHAR(13),
@rol as VARCHAR(30)
AS BEGIN
      IF EXISTS (SELECT rol FROM Empleados WHERE @rol = 'GERENTE')
	    RAISERROR('El usuario Gerente no puede ser despedido',16,1)
	   ELSE
	   UPDATE Empleados SET Estado = 'Despedido'
	   WHERE DNIEmpleado = @DNI AND rol <> 'GERENTE'
END
GO
/****** Object:  StoredProcedure [dbo].[insertar_categoria]    Script Date: 3/6/2021 3:18:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertar_categoria]
	@nombre_categoria VARCHAR(50)
	AS BEGIN
		IF EXISTS (SELECT nombre_categoria FROM categorias WHERE nombre_categoria=@nombre_categoria )
		RAISERROR ('Ya existe esa categoria, porfavor ingrese uno nuevo',16,1)
		ELSE
		INSERT INTO categorias VALUES(@nombre_categoria) 
END
GO
/****** Object:  StoredProcedure [dbo].[insertar_cliente]    Script Date: 3/6/2021 3:18:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertar_cliente] 
	@nombre VARCHAR(50),
	@apellidos VARCHAR(50),
	@correo NVARCHAR(50),
	@direccion VARCHAR(100),
	@telefono VARCHAR(9),
	@dni NVARCHAR(13)
	AS BEGIN
		IF EXISTS (SELECT dni,telefono,correo FROM cliente WHERE dni=@dni AND telefono=@telefono AND correo=@correo)
		RAISERROR ('Ya existe un registro con ese DNI, porfavor ingrese uno nuevo',16,1)
		ELSE
		INSERT INTO cliente VALUES(@nombre,@apellidos,@correo,@direccion,@telefono,@dni) 
END
GO
/****** Object:  StoredProcedure [dbo].[insertar_Empleado]    Script Date: 3/6/2021 3:18:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertar_Empleado]
	@Nombres as VARCHAR(30),
	@Apellidos as VARCHAR(30),
	@FechaNacimiento as DATE,
	@Tel as VARCHAR(9),
	@Sexo as CHAR(1), 
	@Estado as VARCHAR(20),
	@contrasena as NVARCHAR(30),
	@DNI as NVARCHAR(13),
	@Rol as VARCHAR(30)
	AS BEGIN
	     IF EXISTS (SELECT DNIEmpleado, Tel FROM Empleados WHERE DNIEmpleado=@DNI AND Tel=@Tel AND Estado='activo')
		RAISERROR ('Ya existe un registro con estos datos, porfavor ingrese uno nuevo',16,1)
		ELSE
		INSERT INTO Empleados VALUES(@Nombres, @Apellidos, @FechaNacimiento, @Tel, @Sexo, @Estado, @contrasena, @DNI, @Rol) 
END
GO
/****** Object:  StoredProcedure [dbo].[insertar_producto]    Script Date: 3/6/2021 3:18:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertar_producto]
@idcategoria as INT,
@nombre as VARCHAR (50),
@descripcion as VARCHAR (50),
@stock as DECIMAL (10,2),
@precio_compra as decimal (10,2),
@precio_venta as DECIMAL (10,2),
@fecha_vencimiento as DATE,
@imagen as image
as
		INSERT INTO productos VALUES(@idcategoria,@nombre,@descripcion,@stock,@precio_compra,@precio_venta,@fecha_vencimiento,@imagen) 
GO
/****** Object:  StoredProcedure [dbo].[insertar_Proveedor]    Script Date: 3/6/2021 3:18:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertar_Proveedor]
	@P_descripProv VARCHAR(20),
	@P_ciudad VARCHAR(30),
	@P_Tel INT

	AS BEGIN
		IF EXISTS (SELECT P_Tel FROM Proveedores WHERE P_Tel=@P_Tel)
		RAISERROR ('Ya existe un Proveedor con este telefono, porfavor ingrese uno nuevo',16,1)
		ELSE
		INSERT INTO Proveedores VALUES(@P_descripProv,@P_ciudad,@P_Tel) 
END
GO
/****** Object:  StoredProcedure [dbo].[insertar_venta]    Script Date: 3/6/2021 3:18:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertar_venta]
@fecha_venta as DATE,
@num_documento as VARCHAR(50),
@idEmpleado as NVARCHAR(13),
@idcliente as INT
as
INSERT INTO ventas VALUES(@fecha_venta,@num_documento,@idEmpleado,@idcliente)
GO
/****** Object:  StoredProcedure [dbo].[mostrar_categoria]    Script Date: 3/6/2021 3:18:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[mostrar_categoria]
as
SELECT idcategoria as 'Codigo Categoria', nombre_categoria as 'Nombre Categoria' from categorias order by idcategoria desc
GO
/****** Object:  StoredProcedure [dbo].[mostrar_cliente]    Script Date: 3/6/2021 3:18:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[mostrar_cliente]
as
SELECT idcliente as 'Codigo',nombre as 'Nombre Cliente', apellidos as 'Apellidos Cliente',telefono as 'Telefono', correo as 'Correo', direccion as 'Dirección',dni as 'Identidad' FROM cliente order BY idcliente desc
GO
/****** Object:  StoredProcedure [dbo].[Mostrar_Empleado]    Script Date: 3/6/2021 3:18:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Mostrar_Empleado]
as
SELECT DNIEmpleado as 'Identidad', Nombres as 'Nombres',Apellidos as 'Apellidos', FechaNacimiento AS 'Fecha de Nacimiento', tel As 'Telefono', Sexo as 'Sexo', estado as 'Estado', rol as 'Rol', contrasenia as 'Contraseña'
	   FROM Empleados 
	   order BY  DNIEmpleado desc
GO
/****** Object:  StoredProcedure [dbo].[Mostrar_EmpleadoActivo]    Script Date: 3/6/2021 3:18:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Mostrar_EmpleadoActivo]
as
SELECT DNIEmpleado as 'Identidad', Nombres as 'Nombres',Apellidos as 'Apellidos', FechaNacimiento AS 'Fecha de Nacimiento', tel As 'Telefono', Sexo as 'Sexo', estado as 'Estado', rol as 'Rol'
	   FROM Empleados 
	   WHERE Estado = 'Activo'
GO
/****** Object:  StoredProcedure [dbo].[mostrar_producto]    Script Date: 3/6/2021 3:18:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[mostrar_producto]
as
SELECT pro.idproducto as 'Codigo producto', pro.idcategoria as 'Codigo categoria', cat.nombre_categoria as 'Categoria', pro.nombre as 'Producto',pro.descripcion as 'Descripcion',pro.stock as 'Stock',pro.precio_compra as 'Precio de compra',pro.precio_venta as 'Precio de venta',pro.fecha_vencimiento as 'Fecha de vencimiento',pro.imagen as 'Imagen'
FROM productos as pro inner join categorias as cat on pro.idcategoria = cat.idcategoria
order BY pro.idproducto desc
GO
/****** Object:  StoredProcedure [dbo].[mostrar_proveedor]    Script Date: 3/6/2021 3:18:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[mostrar_proveedor]
	as
	SELECT
	      idProveedor as 'Codigo Proveedor', P_descripProv as 'Descripcion del Proveedor', P_ciudad as 'Ciudad', P_Tel as 'Telefono'
    FROM Proveedores 
	order BY  idProveedor desc
GO
/****** Object:  StoredProcedure [dbo].[mostrar_venta]    Script Date: 3/6/2021 3:18:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[mostrar_venta]
as
SELECT   dbo.ventas.idventa as 'Codigo Venta', dbo.ventas.idcliente 'Codigo Cliente', dbo.clientes.nombre as 'Nombre Cliente', dbo.clientes.apellidos as 'Apellidos Cliente', dbo.clientes.dni as 'Identidad Cliente', dbo.ventas.fecha_venta as 'Fecha de la venta', dbo.ventas.num_documento as 'Numero de Documento', dbo.Empleados.Nombres as 'Nombre Empleado', dbo.Empleados.Apellidos as 'Apellidos Empleado'
FROM     dbo.ventas INNER JOIN
             dbo.clientes ON dbo.ventas.idcliente = dbo.clientes.idcliente
			 inner join 
			 dbo.Empleados ON dbo.ventas.idEmpleado = dbo.Empleados.idEmpleado
			 order BY dbo.ventas.idventa desc
GO
/****** Object:  StoredProcedure [dbo].[validarUsuario]    Script Date: 3/6/2021 3:18:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[validarUsuario]
@DNI NVARCHAR(13),
@psw VARCHAR(15),
@rol VARCHAR(30)
AS BEGIN
IF EXISTS(SELECT Estado FROM Empleados WHERE DNIEmpleado = @DNI AND contrasenia = @psw AND rol = @rol AND Estado = 'Activo')
          SELECT * FROM empleados;
		ELSE
        RAISERROR('El usuario no existe',16,1)
END
GO
USE [master]
GO
ALTER DATABASE [GraficaLCB] SET  READ_WRITE 
GO

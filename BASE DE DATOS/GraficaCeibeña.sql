--BASE 12/03/21

--Base de Datos Proyecto Desarrollo de Software 
CREATE DATABASE GraficaLCB 
USE GraficaLCB

--//////////////////////////////////////////////// TABLAS //////////////////////////////////////////////////
CREATE TABLE Roles(
	rol VARCHAR(30) primary key NOT NULL
);

CREATE TABLE Empleados(
	idEmpleado INT IDENTITY(1,1) primary key NOT NULL,
	Nombres VARCHAR(30) NOT NULL,
	Apellidos VARCHAR(30) NOT NULL,
	FechaNacimiento DATE NOT NULL,
	Tel VARCHAR(9) UNIQUE NOT NULL,
	Sexo char(1) NOT NULL, 
	Estado VARCHAR(20) NOT NULL,
	contrasenia NVARCHAR(30) NOT NULL,
	DNIEmpleado NVARCHAR(13) UNIQUE NOT NULL,
	rol VARCHAR(30) NOT NULL,

	CONSTRAINT FK_ROL FOREIGN KEY (rol) REFERENCES Roles(rol),	
);

CREATE TABLE clientes(
    idcliente INT IDENTITY(1,1) Primary key NOT NULL, 
	nombre VARCHAR(50) NOT NULL,
	apellidos VARCHAR(50) NOT NULL,
	correo NVARCHAR(50) NOT NULL UNIQUE,
	direccion VARCHAR(100) null,
	telefono VARCHAR(9) null UNIQUE,
	dni NVARCHAR(13) null UNIQUE
);

CREATE TABLE categorias(
    idcategoria INT IDENTITY(1,1) Primary key,
	nombre_categoria VARCHAR(50) NOT NULL
);

CREATE TABLE productos(
	idproducto INT IDENTITY(1,1) Primary key,
	idcategoria INT NOT NULL,
	nombre varchar (50) not null,
	descripcion VARCHAR (50) NOT NULL,
	stock DECIMAL (10,2),
	precio_compra decimal (10,2) not null,
	precio_venta DECIMAL (10,2) NOT NULL,
	fecha_vencimiento DATE NOT NULL,
	imagen image

CONSTRAINT FK_IDcategoria FOREIGN KEY (idcategoria) REFERENCES categorias(idcategoria)
);

CREATE TABLE ventas(
	idventa INT IDENTITY(1,1) Primary key,
	fecha_venta DATE NOT NULL,
	num_documento VARCHAR(50) NOT NULL,
	idEmpleado INT NOT NULL,
	idcliente INT NOT NULL,
	nombresClientes NVARCHAR(70) NOT NULL,

CONSTRAINT FK_IDempleado FOREIGN KEY (idEmpleado) REFERENCES Empleados(idEmpleado),
 CONSTRAINT FK_IDcliente FOREIGN KEY (idcliente) REFERENCES clientes(idcliente)
);

CREATE TABLE detalles_ventas(
	idventa INT NOT NULL,
	idproducto INT NOT NULL,
	precio_V DECIMAL (10,2) NOT NULL,
	cantidad DECIMAL (10,2) NOT NULL,
	primary key(idventa,idproducto),
	CONSTRAINT FK_IDventa FOREIGN KEY (idventa) REFERENCES ventas(idventa),
	CONSTRAINT FK_IDproducto FOREIGN KEY (idproducto) REFERENCES productos(idproducto)
);

CREATE TABLE Proveedores(
	idProveedor INT IDENTITY(1,1) primary key NOT NULL,
	P_descripProv VARCHAR(20) UNIQUE NOT NULL,
	P_ciudad VARCHAR(30) NOT NULL,
	P_Tel int UNIQUE NOT NULL,
);

CREATE TABLE Compras(
    idCompra INT IDENTITY(1,1) primary key NOT NULL,
    fecha_compra DATE NOT NULL,
    Descripcion_compra NVARCHAR(70) NOT NULL,	
	idProveedor INT NOT NULL
	CONSTRAINT FK_IDProveedor FOREIGN KEY (idProveedor) REFERENCES Proveedores(idProveedor)
);

CREATE TABLE detalles_compras(
	idCompra INT NOT NULL,
	idproducto INT NOT NULL,
	precio_Compra DECIMAL (10,2) NOT NULL,
	cantidad_Compra DECIMAL (10,2) NOT NULL,
	primary key(idCompra,idproducto),
	CONSTRAINT FK_IDCompra FOREIGN KEY (idCompra) REFERENCES Compras(idCompra),
	CONSTRAINT FK_IDproduc FOREIGN KEY (idproducto) REFERENCES productos(idproducto)
);

--/////////////////////////////////////////// PROCEDIMIENTOS ALMACENADOS ////////////////////////////////////////

CREATE PROCEDURE validarUsuario
@DNI NVARCHAR(13),
@psw VARCHAR(15),
@rol VARCHAR(30)
AS BEGIN
IF EXISTS(SELECT Estado FROM Empleados WHERE DNIEmpleado = @DNI AND contrasenia = @psw AND rol = @rol AND Estado = 'Activo')
          SELECT * FROM empleados;
		ELSE
        RAISERROR('El usuario no existe',16,1)
END

-- Insertar Empleado
CREATE PROCEDURE insertar_Empleado
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

--Editar Empleado
CREATE PROCEDURE editar_Empleado
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

-- Despedir Empleado
CREATE PROCEDURE eliminar_Empleado
@DNI as NVARCHAR(13),
@rol as VARCHAR(30)
AS BEGIN
      IF EXISTS (SELECT rol FROM Empleados WHERE @rol = 'GERENTE')
	    RAISERROR('El usuario Gerente no puede ser despedido',16,1)
	   ELSE
	   UPDATE Empleados SET Estado = 'Despedido'
	   WHERE DNIEmpleado = @DNI AND rol <> 'GERENTE'
END

-- Mostrar Empleado
CREATE PROCEDURE Mostrar_Empleado
as
SELECT DNIEmpleado as 'Identidad', Nombres as 'Nombres',Apellidos as 'Apellidos', FechaNacimiento AS 'Fecha de Nacimiento', tel As 'Telefono', Sexo as 'Sexo', estado as 'Estado', rol as 'Rol', contrasenia as 'Contraseña'
	   FROM Empleados 
	   order BY  DNIEmpleado desc
go
-- Mostrar Empleado en busquedas
CREATE PROCEDURE Mostrar_EmpleadoD
as
SELECT idEmpleado as 'Codigo', DNIEmpleado as 'Identidad', Nombres as 'Nombres',Apellidos as 'Apellidos', FechaNacimiento AS 'Fecha de Nacimiento', tel As 'Telefono', Sexo as 'Sexo', estado as 'Estado', rol as 'Rol'
	   FROM Empleados 
	   WHERE Estado = 'Activo'
go
-- Mostrar Empleados activos
CREATE PROCEDURE Mostrar_EmpleadoActivo
as
SELECT DNIEmpleado as 'Identidad', Nombres as 'Nombres',Apellidos as 'Apellidos', FechaNacimiento AS 'Fecha de Nacimiento', tel As 'Telefono', Sexo as 'Sexo', estado as 'Estado', rol as 'Rol'
	   FROM Empleados 
	   WHERE Estado = 'Activo'
go

-- BUSQUEDA
CREATE PROCEDURE buscarEmpleado
@UserName VARCHAR(25)
as
SELECT Nombres as 'Nombres',Apellidos as 'Apellidos', FechaNacimiento AS 'Fecha de Nacimiento', tel As 'Telefono', Sexo as 'Sexo', estado as 'Estado',DNIEmpleado as 'Identidad', rol as 'Rol'
	   FROM Empleados 
WHERE (CONCAT(Nombres, '',Apellidos) LIKE '%' +@UserName+ '%') OR DNIEmpleado LIKE '%' +@UserName+ '%'

-- CLIENTE
-- Mostrar Cliente
CREATE PROCEDURE mostrar_cliente
as
SELECT idcliente as 'Codigo', dni as 'Identidad', nombre as 'Nombre Cliente', apellidos as 'Apellidos Cliente',correo as 'Correo',telefono as 'Telefono', direccion as 'Dirección' 
FROM clientes 
WHERE idcliente <> 1 and nombre <> 'GENERAL' and telefono <> '00000000'
order BY idcliente desc
go

CREATE PROCEDURE mostrar_clienteBUS
as
SELECT  dni as 'Identidad', nombre as 'Nombre Cliente', apellidos as 'Apellidos Cliente',correo as 'Correo',telefono as 'Telefono', direccion as 'Dirección' 
FROM clientes 
WHERE idcliente <> 1 and nombre <> 'GENERAL' and telefono <> '00000000'
order BY idcliente desc
go

-- insertar cliente
CREATE PROCEDURE insertar_cliente 
	@nombre VARCHAR(50),
	@apellidos VARCHAR(50),
	@correo NVARCHAR(50),
	@direccion VARCHAR(100),
	@telefono VARCHAR(9),
	@dni NVARCHAR(13)
	AS BEGIN
		IF EXISTS (SELECT dni,telefono FROM clientes WHERE dni=@dni AND telefono=@telefono)
		RAISERROR ('Ya existe un registro con ese DNI, porfavor ingrese uno nuevo',16,1)
		ELSE
		INSERT INTO clientes VALUES(@nombre,@apellidos,@correo,@direccion,@telefono,@dni) 
END

--Editar cliente
CREATE PROCEDURE editar_cliente
    @idcliente INT, 
	@nombre as VARCHAR(50),
	@apellidos VARCHAR(50),
	@correo NVARCHAR(50),
	@direccion VARCHAR(100),
	@telefono VARCHAR(9),
	@dni NVARCHAR(13)
	as
	   UPDATE clientes SET nombre = @nombre, apellidos = @apellidos,correo = @correo, direccion = @direccion, telefono = @telefono,dni = @dni
	   WHERE idcliente = @idcliente
go

-- Buscar cliente
CREATE PROCEDURE buscarCliente
@dni NVARCHAR(13)
as
SELECT dni as 'Identidad', nombre as 'Nombre Cliente', apellidos as 'Apellidos Cliente',correo as 'Correo',telefono as 'Telefono', direccion as 'Dirección'
FROM clientes
WHERE ((CONCAT(nombre, '',apellidos) LIKE '%' +@dni+ '%') OR (dni LIKE '%' +@dni+ '%')) AND idcliente <> 1

CREATE PROCEDURE buscarClienteBUS
@dni NVARCHAR(13)
as
SELECT idcliente as 'Codigo', dni as 'Identidad', nombre as 'Nombre Cliente', apellidos as 'Apellidos Cliente',correo as 'Correo',telefono as 'Telefono', direccion as 'Dirección'
FROM clientes
WHERE ((CONCAT(nombre, '',apellidos) LIKE '%' +@dni+ '%') OR (dni LIKE '%' +@dni+ '%')) AND idcliente <> 1

-- CATEGORIA
-- insertar categoria
CREATE PROCEDURE insertar_categoria
	@nombre_categoria VARCHAR(50)
	AS BEGIN
		IF EXISTS (SELECT nombre_categoria FROM categorias WHERE nombre_categoria=@nombre_categoria )
		RAISERROR ('Ya existe esa categoria, porfavor ingrese uno nuevo',16,1)
		ELSE
		INSERT INTO categorias VALUES(@nombre_categoria) 
END

-- modificar categoria
CREATE PROCEDURE editar_categoria
    @idcategoria INT,
	@nombre_categoria VARCHAR(50)
	as
    UPDATE categorias SET nombre_categoria = @nombre_categoria
     WHERE idcategoria = @idcategoria
go

-- Buscar categoria
CREATE PROCEDURE buscarCategoria
@nombre_categoria VARCHAR(50)
as
SELECT idcategoria as 'Codigo Categoria',nombre_categoria as 'Nombre Categoria' FROM categorias
WHERE nombre_categoria LIKE '%' +@nombre_categoria+ '%'

-- Mostrar Cargar categoria
CREATE PROCEDURE mostrar_categoria
as
SELECT idcategoria as 'Codigo Categoria', nombre_categoria as 'Nombre Categoria' from categorias order by idcategoria desc
go

--PRODUCTO
--mostrar productos
CREATE PROCEDURE mostrar_producto
as
SELECT pro.idproducto as 'Codigo producto', pro.idcategoria as 'Codigo categoria', cat.nombre_categoria as 'Categoria', pro.nombre as 'Producto',pro.descripcion as 'Descripcion',pro.stock as 'Stock',pro.precio_compra as 'Precio de compra',pro.precio_venta as 'Precio de venta',pro.fecha_vencimiento as 'Fecha de vencimiento',pro.imagen as 'Imagen'
FROM productos as pro inner join categorias as cat on pro.idcategoria = cat.idcategoria
order BY pro.idproducto desc
go

-- Insertar producto
CREATE PROCEDURE insertar_producto
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
go

-- editar producto
CREATE PROCEDURE editar_producto
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
go

-- Buscar producto
CREATE PROCEDURE buscarProducto
@nombre VARCHAR (50)
as
SELECT pro.idproducto as 'Codigo producto', pro.idcategoria as 'Codigo categoria', cat.nombre_categoria as 'Categoria', pro.nombre as 'Producto',pro.descripcion as 'Descripcion',pro.stock as 'Stock',pro.precio_compra as 'Precio de compra',pro.precio_venta as 'Precio de venta',pro.fecha_vencimiento as 'Fecha de vencimiento',pro.imagen as 'Imagen'
FROM productos as pro inner join categorias as cat on pro.idcategoria = cat.idcategoria
WHERE pro.nombre LIKE '%' +@nombre+ '%'

-- PROVEEDORES
--Mostrar Proveedor
CREATE PROCEDURE mostrar_proveedor
	as
	SELECT
	      idProveedor as 'Codigo Proveedor', P_descripProv as 'Descripcion del Proveedor', P_ciudad as 'Ciudad', P_Tel as 'Telefono'
    FROM Proveedores 
	order BY  idProveedor desc
go

-- Insertar Proveedor
CREATE PROCEDURE insertar_Proveedor
	@P_descripProv VARCHAR(20),
	@P_ciudad VARCHAR(30),
	@P_Tel INT

	AS BEGIN
		IF EXISTS (SELECT P_Tel FROM Proveedores WHERE P_Tel=@P_Tel)
		RAISERROR ('Ya existe un Proveedor con este telefono, porfavor ingrese uno nuevo',16,1)
		ELSE
		INSERT INTO Proveedores VALUES(@P_descripProv,@P_ciudad,@P_Tel) 
END

-- Editar Proveedor
CREATE PROCEDURE editar_Proveedor
    @idProveedor INT,
	@P_descripProv VARCHAR(20),
	@P_ciudad VARCHAR(30),
	@P_Tel INT
	as
	   UPDATE Proveedores SET P_descripProv=@P_descripProv, P_ciudad=@P_ciudad, P_Tel=@P_Tel
	   WHERE idProveedor = @idProveedor
go

-- Buscar proveedor
CREATE PROCEDURE buscarProveedor
@P_descripProv VARCHAR(20)
as
	SELECT
	      idProveedor as 'Codigo Proveedor', P_descripProv as 'Descripcion del Proveedor', P_ciudad as 'Ciudad', P_Tel as 'Telefono'
    FROM Proveedores
WHERE P_descripProv LIKE '%' +@P_descripProv+ '%'


-- VENTA
CREATE PROCEDURE insertar_venta
@fecha_venta as DATE,
@num_documento as VARCHAR(50),
@idEmpleado as INT,
@idcliente as INT,
@nombresClientes as NVARCHAR(70) 
as
INSERT INTO ventas VALUES(@fecha_venta,@num_documento,@idEmpleado,@idcliente, @nombresClientes)
go

--editar venta
CREATE PROCEDURE editar_venta
@idventa as INT,
@fecha_venta as DATE,
@num_documento as VARCHAR(50),
@idEmpleado as INT,
@idcliente as INT,
@nombresClientes as NVARCHAR(70)
as
UPDATE ventas SET fecha_venta=@fecha_venta,num_documento=@num_documento, idEmpleado=@idEmpleado,idcliente=@idcliente, nombresClientes=@nombresClientes
WHERE idventa=@idventa
go

-- mostrar venta
CREATE PROCEDURE mostrar_venta
as
SELECT   dbo.ventas.idventa as 'Codigo Venta', dbo.ventas.idcliente 'Codigo Cliente', dbo.ventas.nombresClientes as 'Nombre Cliente', dbo.ventas.fecha_venta as 'Fecha de la venta', dbo.Empleados.Nombres as 'Nombre Empleado', dbo.Empleados.Apellidos as 'Apellidos Empleado'
FROM     dbo.ventas INNER JOIN
			 dbo.Empleados ON dbo.ventas.idEmpleado = dbo.Empleados.idEmpleado
			 order BY dbo.ventas.idventa desc
			 go

-- Buscar Venta
CREATE PROCEDURE buscarVenta
@num_documento as NVARCHAR(50)
as
SELECT   dbo.ventas.idventa as 'Codigo Venta', dbo.ventas.idcliente 'Codigo Cliente', dbo.ventas.nombresClientes as 'Nombre Cliente', dbo.ventas.fecha_venta as 'Fecha de la venta', dbo.Empleados.Nombres as 'Nombre Empleado', dbo.Empleados.Apellidos as 'Apellidos Empleado'
FROM     dbo.ventas INNER JOIN
			 dbo.Empleados ON dbo.ventas.idEmpleado = dbo.Empleados.idEmpleado
WHERE idventa LIKE '%' +@num_documento+ '%'

-- DETALLES DE VENTA
-- insertar detalles venta
CREATE PROCEDURE insertar_detalles_venta
@idventa as INT,
@idproducto as INT,
@precio_V as decimal (10,2),
@cantidad as decimal (10,2)
as
INSERT INTO detalles_ventas VALUES(@idventa,@idproducto,@precio_V,@cantidad)
go

-- editar detalles venta
CREATE PROCEDURE editar_detalles_venta
@idventa as INT,
@idproducto as INT,
@precio_V as decimal (10,2),
@cantidad as decimal (10,2)
as
UPDATE detalles_ventas SET precio_V=@precio_V ,cantidad=@cantidad
WHERE idventa= @idventa and idproducto=@idproducto
go

-- ELMINAR PRODUCTO detalles venta
CREATE PROCEDURE EliminarDetalleV
@idventa as INT,
@idproducto as INT
as
DELETE FROM detalles_ventas
WHERE idventa= @idventa and idproducto=@idproducto
go

-- mostrar detalles venta

CREATE PROCEDURE mostrar_detalle_venta
@IdVenta INT
as
SELECT        dbo.detalles_ventas.idventa as 'Codigo Venta', dbo.detalles_ventas.idproducto as 'Codigo Producto', dbo.productos.nombre as 'Producto', dbo.detalles_ventas.precio_V as 'Precio Unitario', dbo.detalles_ventas.cantidad as 'Cantidad'
FROM            dbo.detalles_ventas INNER JOIN
                         dbo.productos ON dbo.detalles_ventas.idproducto = dbo.productos.idproducto 
						 
						 where idventa=@IdVenta
go

-- STOCK
-- AUMENTAR STOCK
CREATE PROCEDURE aumentar_stock
@idproducto as INT,
@cantidad as decimal (10,2)
as
UPDATE productos SET stock = stock+@cantidad 
WHERE idproducto=@idproducto
go

-- DISMINUID STOCK
CREATE PROCEDURE disminuir_stock
@idproducto as INT,
@cantidad as decimal (10,2)
as
UPDATE productos SET stock = stock-@cantidad 
WHERE idproducto=@idproducto
go

--Mostrar el total de una venta
CREATE PROCEDURE mostrarTotalV
@idventa as INT
as
SELECT SUM(cantidad) As 'Articulos',CONCAT('Lps.',' ',SUM(precio_V*cantidad)) As 'Total Venta'
FROM detalles_ventas
WHERE idventa = 11
go

--Mostrar Stock
CREATE PROCEDURE mostrarStock
@idproducto as INT
as
SELECT stock As 'Stock'
FROM productos
WHERE idproducto=@idproducto
go

--18/03/21
------COMPRAS

--Insertar Compra
CREATE PROCEDURE insertar_compra
@fecha_compra as DATE,
@Descripcion_compra as NVARCHAR(70),
@idProveedor as INT
as
INSERT INTO Compras VALUES(@fecha_compra,@Descripcion_compra,@idProveedor)
go

--editar compra
CREATE PROCEDURE editar_compra
@idCompra as INT,
@fecha_compra as DATE,
@Descripcion_compra as NVARCHAR(70),
@idProveedor as INT
as
UPDATE Compras SET fecha_compra=@fecha_compra, Descripcion_compra=@Descripcion_compra, idProveedor=@idProveedor
WHERE idCompra=@idCompra
go

-- mostrar Compra
CREATE PROCEDURE mostrar_Compra
as
SELECT        dbo.Compras.idCompra as 'Codigo Compra', dbo.Proveedores.idProveedor as 'Codigo Proveedor', dbo.Proveedores.P_descripProv as 'Proveedor', dbo.Compras.fecha_compra as 'Fecha Compra', dbo.Compras.Descripcion_compra as 'Descripción Compra'
FROM            dbo.Compras INNER JOIN
                         dbo.Proveedores ON dbo.Compras.idProveedor = dbo.Proveedores.idProveedor
go

-- Buscar Compra
CREATE PROCEDURE buscarCompra
@num_documento as NVARCHAR(50)
as
SELECT        dbo.Compras.idCompra as 'Codigo Compra', dbo.Proveedores.idProveedor as 'Codigo Proveedor', dbo.Proveedores.P_descripProv as 'Proveedor', dbo.Compras.fecha_compra as 'Fecha Compra', dbo.Compras.Descripcion_compra as 'Descripción Compra'
FROM            dbo.Compras INNER JOIN
                         dbo.Proveedores ON dbo.Compras.idProveedor = dbo.Proveedores.idProveedor
WHERE idCompra LIKE '%' +@num_documento+ '%'

-- DETALLES DE COMPRA
-- insertar detalles compra
CREATE PROCEDURE insertar_detalles_compra
@idCompra as INT,
@idproducto as INT,
@precio_Compra DECIMAL (10,2),
@cantidad_Compra DECIMAL (10,2)
as
INSERT INTO detalles_compras VALUES(@idCompra,@idproducto,@precio_Compra,@cantidad_Compra)
go

-- editar detalles compra
CREATE PROCEDURE editar_detalles_compra
@idCompra as INT,
@idproducto as INT,
@precio_Compra DECIMAL (10,2),
@cantidad_Compra DECIMAL (10,2)
as
UPDATE detalles_compras SET precio_Compra=@precio_Compra ,cantidad_Compra=@cantidad_Compra
WHERE idCompra= @idCompra and idproducto=@idproducto
go

-- ELMINAR PRODUCTO detalles compra
CREATE PROCEDURE EliminarDetalleC
@idCompra as INT,
@idproducto as INT
as
DELETE FROM detalles_compras
WHERE idCompra= @idCompra and idproducto=@idproducto
go

-- mostrar detalles compra
CREATE PROCEDURE mostrar_detalle_compra
@IdCompra INT
as
SELECT        dbo.detalles_compras.idCompra as 'Codigo Compra', dbo.productos.idproducto as 'Codigo Producto', dbo.productos.nombre as 'Producto', dbo.detalles_compras.precio_Compra as 'Precio', dbo.detalles_compras.cantidad_Compra as 'Cantidad'
FROM            dbo.detalles_compras INNER JOIN
                         dbo.productos ON dbo.detalles_compras.idproducto = dbo.productos.idproducto 						 
						 where idCompra=@IdCompra
go

CREATE VIEW vistaVentas as
SELECT        dbo.ventas.idventa, dbo.ventas.fecha_venta, dbo.ventas.num_documento, dbo.detalles_ventas.idproducto, dbo.productos.nombre, dbo.detalles_ventas.precio_V, dbo.detalles_ventas.cantidad, dbo.Empleados.Nombres, 
                         dbo.Empleados.Apellidos, dbo.ventas.nombresClientes
FROM            dbo.ventas INNER JOIN
                         dbo.detalles_ventas ON dbo.ventas.idventa = dbo.detalles_ventas.idventa INNER JOIN
                         dbo.productos ON dbo.detalles_ventas.idproducto = dbo.productos.idproducto INNER JOIN
                         dbo.Empleados ON dbo.ventas.idEmpleado = dbo.Empleados.idEmpleado

CREATE VIEW vistaCalculo as
SELECT idventa, SUM(cantidad) As 'Articulos',CONCAT('Lps.',' ',SUM(precio_V*cantidad)) As 'Total Venta'
FROM detalles_ventas
GROUP BY idventa
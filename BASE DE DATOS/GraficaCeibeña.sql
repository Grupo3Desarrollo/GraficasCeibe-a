--Base de Datos Proyecto Desarrollo de Software 
CREATE DATABASE GraficaLCB 
USE GraficaLCB

--//////////////////////////////////////////////// TABLAS //////////////////////////////////////////////////
CREATE TABLE Roles(
	rol VARCHAR(30) primary key NOT NULL
);

create TABLE Empleados(
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
	idcliente INT NULL,

CONSTRAINT FK_IDempleado FOREIGN KEY (idEmpleado) REFERENCES Empleados(idEmpleado),
 CONSTRAINT FK_IDcliente FOREIGN KEY (idcliente) REFERENCES clientes(idcliente)
);

CREATE TABLE detalles_ventas(
	idventa INT NOT NULL,
	idproducto INT NOT NULL,
	precio_V DECIMAL (10,2) NOT NULL,
	cantidad DECIMAL (10,2) NOT NULL,
	subtotal DECIMAL (10,2) NULL,
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
	idproducto INT NOT NULL,
	idProveedor INT NOT NULL
	CONSTRAINT FK_IDproductoDos FOREIGN KEY (idproducto) REFERENCES productos(idproducto),
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
SELECT idcliente as 'Codigo',nombre as 'Nombre Cliente', apellidos as 'Apellidos Cliente',telefono as 'Telefono', correo as 'Correo', direccion as 'Dirección',dni as 'Identidad' FROM cliente order BY idcliente desc
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
		IF EXISTS (SELECT dni,telefono,correo FROM cliente WHERE dni=@dni AND telefono=@telefono AND correo=@correo)
		RAISERROR ('Ya existe un registro con ese DNI, porfavor ingrese uno nuevo',16,1)
		ELSE
		INSERT INTO cliente VALUES(@nombre,@apellidos,@correo,@direccion,@telefono,@dni) 
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
	   UPDATE cliente SET nombre = @nombre, apellidos = @apellidos, correo=@correo, direccion = @direccion, telefono = @telefono,dni = @dni
	   WHERE idcliente = @idcliente
go

-- Buscar cliente
CREATE PROCEDURE buscarCliente
@dni NVARCHAR(13)
as
SELECT idcliente as 'Codigo',nombre as 'Nombre Cliente', apellidos as 'Apellidos Cliente',telefono as 'Telefono',dni as 'Identidad' 
FROM cliente
WHERE (CONCAT(Nombres, '',Apellidos) LIKE '%' +@dni+ '%') OR dni LIKE '%' +@dni+ '%'

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

-- VENTA
-- insertar venta
CREATE PROCEDURE insertar_venta
@idcliente as INT,
@fecha_venta as DATE,
@num_documento as VARCHAR(50),
@idEmpleado as NVARCHAR(13)
as
INSERT INTO venta VALUES(@idcliente,@fecha_venta,@num_documento,@idEmpleado)
go

--editar
CREATE PROCEDURE editar_venta
@idventa as INT,
@idcliente as INT,
@fecha_venta as DATE,
@num_documento as VARCHAR(50),
@idEmpleado as NVARCHAR(13)
as
UPDATE venta SET idcliente=@idcliente,fecha_venta=@fecha_venta,num_documento=@num_documento, idEmpleado=@idEmpleado
WHERE idventa=@idventa
go

-- mostrar venta
CREATE PROCEDURE mostrar_venta
as
SELECT   dbo.venta.idventa as 'Codigo Venta', dbo.venta.idcliente 'Codigo Cliente', dbo.cliente.nombre as 'Nombre Cliente', dbo.cliente.apellidos as 'Apellidos Cliente', dbo.cliente.dni as 'Identidad Cliente', dbo.venta.fecha_venta as 'Fecha de la venta', dbo.venta.num_documento as 'Numero de Documento', dbo.Empleados.Nombres as 'Nombre Empleado', dbo.Empleados.Apellidos as 'Apellidos Empleado'
FROM     dbo.venta INNER JOIN
             dbo.cliente ON dbo.venta.idcliente = dbo.cliente.idcliente
			 inner join 
			 dbo.Empleados ON dbo.venta.idEmpleado = dbo.Empleados.idEmpleado
			 order BY dbo.venta.idventa desc
			 go

-- Buscar Venta
CREATE PROCEDURE buscarVenta
@num_documento as VARCHAR(50)
as
SELECT   dbo.venta.idventa as 'Codigo Venta', dbo.venta.idcliente 'Codigo Cliente', dbo.cliente.nombre as 'Nombre Cliente', dbo.cliente.apellidos as 'Apellidos Cliente', dbo.cliente.dni as 'Identidad Cliente', dbo.venta.fecha_venta as 'Fecha de la venta', dbo.venta.num_documento as 'Numero de Documento', dbo.Empleados.Nombres as 'Nombre Empleado', dbo.Empleados.Apellidos as 'Apellidos Empleado'
FROM     dbo.venta INNER JOIN
             dbo.cliente ON dbo.venta.idcliente = dbo.cliente.idcliente
			 inner join 
			 dbo.Empleados ON dbo.venta.idEmpleado = dbo.Empleados.idEmpleado
WHERE num_documento LIKE '%' +@num_documento+ '%'

-- DETALLES DE VENTA

-- insertar detalles venta
CREATE PROCEDURE insertar_detalles_venta
@idventa as INT,
@idproducto as INT,
@precio_V as decimal (10,2),
@cantidad as decimal (10,2)

as
INSERT INTO detalle_venta VALUES(@idventa,@idproducto,@precio_V,@cantidad)
go

-- editar detalles venta
CREATE PROCEDURE editar_detalles_venta
@idventa as INT,
@idproducto as INT,
@precio_V as decimal (10,2),
@cantidad as decimal (10,2)
as
UPDATE detalle_venta SET idproducto=@idproducto, precio_V=@precio_V ,cantidad=@cantidad
WHERE idventa= @idventa
go

-- mostrar detalles venta

CREATE PROCEDURE mostrar_detalle_venta
as
SELECT        dbo.detalle_venta.idventa as 'Codigo Venta', dbo.detalle_venta.idproducto as 'Codigo Producto', dbo.producto.nombre as 'Producto', dbo.detalle_venta.precio_V as 'Precio Unitario', dbo.detalle_venta.cantidad as 'Cantidad'
FROM            dbo.detalle_venta INNER JOIN
                         dbo.producto ON dbo.detalle_venta.idproducto = dbo.producto.idproducto 
						 order BY  dbo.detalle_venta.iddetalle_venta desc
go

-- STOCK
-- AUMENTAR STOCK
CREATE PROCEDURE aumentar_stock
@idproducto as INT,
@cantidad as decimal (18,2)
as
UPDATE producto SET stock = stock+@cantidad 
WHERE idproducto=@idproducto
go

-- DISMINUID STOCK
CREATE PROCEDURE disminuir_stock
@idproducto as INT,
@cantidad as decimal (18,2)
as
UPDATE producto SET stock = stock-@cantidad 
WHERE idproducto=@idproducto
go

-- PROVEEDORE
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

--CompraProveedor
-- Insertar Compra
CREATE PROCEDURE ingresar_CompraProveedor
	@fecha_compra as DATE,
	@idproducto as INT,
	@idProveedor as INT

	AS BEGIN
		INSERT INTO Compras VALUES(@fecha_compra, @idproducto, @idProveedor) 
END

-- Editar Compra
CREATE PROCEDURE editar_compra
	@iCompra as INT,
	@fecha_compra as DATE,
	@idproducto as INT,
	@idProveedor as INT
as
UPDATE Compras SET fecha_compra=@fecha_compra, idproducto=@idproducto, idProveedor=@idProveedor
WHERE idCompra=@idCompra
go






CREATE PROCEDURE insertar_CompraProveedor
	@idProveedor INT,
	@idproducto INT,
	@P_precio_compra decimal (18,2),
	@P_cantidad INT,
	@fecha_compra DATE

	AS BEGIN
		INSERT INTO Compra VALUES(@idProveedor,@idproducto,@P_precio_compra,@P_cantidad,@fecha_compra) 
END


-- MostrarCompraProveedor

CREATE PROCEDURE mostrar_CompraProveedor
as
SELECT dbo.Compra.idCompra as 'Codigo Compra', dbo.Proveedores.idProveedor as 'Codigo Proveedor', dbo.producto.idproducto as 'Codigo Producto', dbo.Proveedores.P_descripProv as 'Descripcion Proveedor', dbo.producto.nombre as 'Producto', dbo.Compra.P_cantidad as 'Cantidad', dbo.Compra.P_precio_compra as 'Precio de Compra', dbo.Compra.fecha_compra as 'Fecha de Compra'
FROM   dbo.producto INNER JOIN
             dbo.Compra ON dbo.producto.idproducto = dbo.Compra.idproducto INNER JOIN
             dbo.Proveedores ON dbo.Compra.idProveedor = dbo.Proveedores.idProveedor
			 order BY dbo.Compra.idCompra desc

--Trabajo 23/02/21 - 26/02/21

-- CLIENTE
-- Mostrar Cliente
CREATE PROCEDURE mostrar_cliente
as
SELECT dni as 'Identidad', nombre as 'Nombre Cliente', apellidos as 'Apellidos Cliente',correo as 'Correo',telefono as 'Telefono', direccion as 'Dirección' FROM clientes order BY idcliente desc
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
WHERE (CONCAT(nombre, '',apellidos) LIKE '%' +@dni+ '%') OR dni LIKE '%' +@dni+ '%'


-- PROVEEDORE
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
WHERE (P_descripProv LIKE '%' +@P_descripProv+ '%') OR (P_ciudad LIKE '%' +@P_descripProv+ '%') 

/*
execute insertar_Empleado 'Jonathan Alexis','Aleman Linares','1998-05-09','96693357','M','Activo','Y8msdnxDm9U=','0101199804248','Gerente'
execute insertar_Empleado 'Hugo Geovany','Murillo Urbina','2000-02-17','96693300','M','Activo','Y8msdnxDm9U=','1807200000429','Dependiente'
*/

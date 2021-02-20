CREATE DATABASE GraficaLCB;

USE GraficaLCB;

CREATE TABLE Roles(
	idRol NVARCHAR(13) primary key NOT NULL,
	rol VARCHAR(30) NOT NULL
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
	DNIEmpleado NVARCHAR(13) NOT NULL,
	idRol NVARCHAR(13) NOT NULL,

	CONSTRAINT FK_ROL FOREIGN KEY (idRol) REFERENCES Roles(idRol),	
);

CREATE TABLE clientes(
    idcliente INT IDENTITY(1,1) Primary key NOT NULL, 
	nombre VARCHAR(50) NOT NULL,
	apellidos VARCHAR(50) NOT NULL,
	telefono VARCHAR(9) null UNIQUE,
	correo NVARCHAR(50) NOT NULL UNIQUE,
	direccion VARCHAR(100) null,
	dni NVARCHAR(13) null UNIQUE
);

CREATE TABLE categorias(
    idcategoria INT IDENTITY(1,1) Primary key,
	nombre_categoria VARCHAR(50) NOT NULL
);

CREATE TABLE productos(
	idproducto INT IDENTITY(1,1) Primary key,
	descripcion VARCHAR (50) NOT NULL,
	stock DECIMAL (10,2),
	precio_venta DECIMAL (10,2) NOT NULL,
	fecha_vencimiento DATE NOT NULL,
	imagen image,
	idcategoria INT NOT NULL

CONSTRAINT FK_IDcategoria FOREIGN KEY (idcategoria) REFERENCES categorias(idcategoria)
);

CREATE TABLE ventas(
	idventa INT IDENTITY(1,1) Primary key,
	fecha_venta DATE NOT NULL,
	num_documento VARCHAR(50) NOT NULL,
	idEmpleado INT NOT NULL,
	idcliente INT NOT NULL

CONSTRAINT FK_IDempleado FOREIGN KEY (idEmpleado) REFERENCES Empleados(idEmpleado),

 FK_IDcliente FOREIGN KEY (idcliente) REFERENCES clientes(idcliente)
);

CREATE TABLE detalles_ventas(
	idventa INT NOT NULL,
	idproducto INT NOT NULL,
	precio_V DECIMAL (10,2) NOT NULL,
	cantidad DECIMAL (10,2) NOT NULL,
	subtotal DECIMAL (10,2) NOT NULL,
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


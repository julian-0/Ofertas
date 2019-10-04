USE GD2C2019
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF EXISTS (
		SELECT *
		FROM sys.schemas
		WHERE name = 'NUNCA_INJOIN'
		)
BEGIN
	IF EXISTS (
			SELECT *
			FROM sys.tables
			WHERE object_name(object_id) = 'Entrega'
				AND schema_name(schema_id) = 'NUNCA_INJOIN'
			)
		DROP TABLE NUNCA_INJOIN.Entrega

	IF EXISTS (
			SELECT *
			FROM sys.tables
			WHERE object_name(object_id) = 'FacturaProveedor'
				AND schema_name(schema_id) = 'NUNCA_INJOIN'
			)
		DROP TABLE NUNCA_INJOIN.FacturaProveedor

	IF EXISTS (
			SELECT *
			FROM sys.tables
			WHERE object_name(object_id) = 'Compra'
				AND schema_name(schema_id) = 'NUNCA_INJOIN'
			)
		DROP TABLE NUNCA_INJOIN.Compra

	IF EXISTS (
			SELECT *
			FROM sys.tables
			WHERE object_name(object_id) = 'Oferta'
				AND schema_name(schema_id) = 'NUNCA_INJOIN'
			)
		DROP TABLE NUNCA_INJOIN.Oferta

	IF EXISTS (
			SELECT *
			FROM sys.tables
			WHERE object_name(object_id) = 'Proveedor'
				AND schema_name(schema_id) = 'NUNCA_INJOIN'
			)
		DROP TABLE NUNCA_INJOIN.Proveedor

	IF EXISTS (
			SELECT *
			FROM sys.tables
			WHERE object_name(object_id) = 'Rubro'
				AND schema_name(schema_id) = 'NUNCA_INJOIN'
			)
		DROP TABLE NUNCA_INJOIN.Rubro

	IF EXISTS (
			SELECT *
			FROM sys.tables
			WHERE object_name(object_id) = 'Oferta'
				AND schema_name(schema_id) = 'NUNCA_INJOIN'
			)
		DROP TABLE NUNCA_INJOIN.Oferta

	IF EXISTS (
			SELECT *
			FROM sys.tables
			WHERE object_name(object_id) = 'FacturaProveedor'
				AND schema_name(schema_id) = 'NUNCA_INJOIN'
			)
		DROP TABLE NUNCA_INJOIN.FacturaProveedor

	IF EXISTS (
			SELECT *
			FROM sys.tables
			WHERE object_name(object_id) = 'Compra'
				AND schema_name(schema_id) = 'NUNCA_INJOIN'
			)
		DROP TABLE NUNCA_INJOIN.Compra

	IF EXISTS (
			SELECT *
			FROM sys.tables
			WHERE object_name(object_id) = 'Carga'
				AND schema_name(schema_id) = 'NUNCA_INJOIN'
			)
		DROP TABLE NUNCA_INJOIN.Carga

	IF EXISTS (
			SELECT *
			FROM sys.tables
			WHERE object_name(object_id) = 'Tarjeta'
				AND schema_name(schema_id) = 'NUNCA_INJOIN'
			)
		DROP TABLE NUNCA_INJOIN.Tarjeta

	IF EXISTS (
			SELECT *
			FROM sys.tables
			WHERE object_name(object_id) = 'Cliente'
				AND schema_name(schema_id) = 'NUNCA_INJOIN'
			)
		DROP TABLE NUNCA_INJOIN.Cliente

	IF EXISTS (
			SELECT *
			FROM sys.tables
			WHERE object_name(object_id) = 'Usuario'
				AND schema_name(schema_id) = 'NUNCA_INJOIN'
			)
		DROP TABLE NUNCA_INJOIN.Usuario

	IF EXISTS (
			SELECT *
			FROM sys.tables
			WHERE object_name(object_id) = 'FuncionalidadPorRol'
				AND schema_name(schema_id) = 'NUNCA_INJOIN'
			)
		DROP TABLE NUNCA_INJOIN.FuncionalidadPorRol

	IF EXISTS (
			SELECT *
			FROM sys.tables
			WHERE object_name(object_id) = 'Rol'
				AND schema_name(schema_id) = 'NUNCA_INJOIN'
			)
		DROP TABLE NUNCA_INJOIN.Rol

	IF EXISTS (
			SELECT *
			FROM sys.tables
			WHERE object_name(object_id) = 'Funcionalidad'
				AND schema_name(schema_id) = 'NUNCA_INJOIN'
			)
		DROP TABLE NUNCA_INJOIN.Funcionalidad
END
ELSE
BEGIN
	EXEC ('create schema NUNCA_INJOIN authorization [gdCupon2019]')

	PRINT 'Creado schema NUNCA_INJOIN'
END
GO

/*
 *	CREACIÓN DE TABLAS
 */
USE GD2C2019
GO

CREATE TABLE NUNCA_INJOIN.Funcionalidad ("funcionalidad_id" VARCHAR(50) PRIMARY KEY);

CREATE TABLE NUNCA_INJOIN.Rol (
	"rol_id" VARCHAR(50) PRIMARY KEY,
	"baja_logica" CHAR(1) NOT NULL DEFAULT 'N' CHECK (baja_logica IN ('S', 'N')),
	"habilitado" CHAR(1) NOT NULL DEFAULT 'A' CHECK (habilitado IN ('A', 'I')),
	);

CREATE TABLE NUNCA_INJOIN.FuncionalidadPorRol (
	"funcionalidad_id" VARCHAR(50) REFERENCES NUNCA_INJOIN.Funcionalidad,
	"rol_id" VARCHAR(50) REFERENCES NUNCA_INJOIN.Rol,
	PRIMARY KEY (
		rol_id,
		funcionalidad_id
		)
	);

CREATE TABLE NUNCA_INJOIN.Usuario (
	"usuario_id" VARCHAR(50) PRIMARY KEY,
	"rol_id" VARCHAR(50) REFERENCES NUNCA_INJOIN.Rol,
	"contrasenia" VARBINARY(32) NOT NULL,
	"intentos_fallidos" SMALLINT DEFAULT 0,
	"baja_logica" CHAR(1) NOT NULL DEFAULT 'N' CHECK (baja_logica IN ('S', 'N'))
	);

CREATE TABLE NUNCA_INJOIN.Cliente (
	"cliente_id" NUMERIC(9) identity PRIMARY KEY,
	"usuario_id" VARCHAR(50) REFERENCES NUNCA_INJOIN.Usuario,
	"nombre" NVARCHAR(255),
	"apellido" NVARCHAR(255),
	"dni" NUMERIC(18, 0),
	"mail" NVARCHAR(255),
	"telefono" NUMERIC(18, 0),
	"domicilio" NVARCHAR(255),
	"localidad" NVARCHAR(255),
	"codigo_postal" NVARCHAR(8),
	"fecha_nac" DATETIME,
	"credito" NUMERIC(18, 2) NOT NULL DEFAULT 200,
	"baja_logica" CHAR(1) NOT NULL DEFAULT 'N' CHECK (baja_logica IN ('S', 'N'))
	);

CREATE TABLE NUNCA_INJOIN.Tarjeta (
	"tarjeta_id" NUMERIC(9) identity PRIMARY KEY,
	"cliente_id" NUMERIC(9) REFERENCES NUNCA_INJOIN.Cliente,
	"duenio" NVARCHAR(255),
	numero NUMERIC(19)
	);

CREATE TABLE NUNCA_INJOIN.Carga (
	"carga_id" NUMERIC(9) identity PRIMARY KEY,
	"cliente_id" NUMERIC(9) REFERENCES NUNCA_INJOIN.Cliente,
	"tarjeta_id" NUMERIC(9) REFERENCES NUNCA_INJOIN.Tarjeta,
	"fecha" DATETIME NOT NULL,
	"tipo_pago" NVARCHAR(100),
	"monto" NUMERIC(18, 2)
	);

CREATE TABLE NUNCA_INJOIN.Rubro (
	"rubro_id" NUMERIC(9) identity PRIMARY KEY,
	"nombre_rubro" NVARCHAR(100)
	);

CREATE TABLE NUNCA_INJOIN.Proveedor (
	"proveedor_id" NUMERIC(9) identity PRIMARY KEY,
	"rubro_id" NUMERIC(9) REFERENCES NUNCA_INJOIN.Rubro,
	"usuario_id" VARCHAR(50) REFERENCES NUNCA_INJOIN.Usuario,
	"razon_social" NVARCHAR(100),
	"mail" NVARCHAR(255),
	"telefono" NUMERIC(18, 0),
	"domicilio" NVARCHAR(255),
	"localidad" NVARCHAR(255),
	"ciudad" NVARCHAR(255),
	"codigo_postal" NVARCHAR(8),
	"cuit" NVARCHAR(20),
	"nombre_contacto" NVARCHAR(255),
	"baja_logica" CHAR(1) NOT NULL DEFAULT 'N' CHECK (baja_logica IN ('S', 'N'))
	);

CREATE TABLE NUNCA_INJOIN.Oferta (
	oferta_codigo NVARCHAR(50) PRIMARY KEY,
	proveedor_id NUMERIC(9) REFERENCES NUNCA_INJOIN.Proveedor,
	descripcion NVARCHAR(255),
	fecha_publicacion DATETIME,
	fecha_vencimiento DATETIME,
	precio_oferta NUMERIC(18, 2),
	precio_lista NUMERIC(18, 2),
	cantidad_disponible NUMERIC(18, 0)
	)

CREATE TABLE NUNCA_INJOIN.Compra (
	compra_id NUMERIC(9) identity PRIMARY KEY,
	oferta_id NVARCHAR(50) REFERENCES NUNCA_INJOIN.Oferta,
	cliente_compra_id NUMERIC(9) REFERENCES NUNCA_INJOIN.Cliente,
	fecha_compra DATETIME,
	vencimiento DATETIME
	)

CREATE TABLE NUNCA_INJOIN.FacturaProveedor (
	factura_id NUMERIC(9) identity,
	factura_tipo CHAR(1),
	compra_id NUMERIC(9) REFERENCES NUNCA_INJOIN.Compra,
	proveedor_id NUMERIC(9) REFERENCES NUNCA_INJOIN.Proveedor,
	fecha DATETIME,
	numero NUMERIC(18, 0),
	importe NUMERIC(26, 2),
	PRIMARY KEY (
		factura_id,
		factura_tipo
		)
	)

CREATE TABLE NUNCA_INJOIN.Entrega (
	entrega_id NUMERIC(9) identity,
	compra_id NUMERIC(9) REFERENCES NUNCA_INJOIN.Compra,
	cliente_entrega_id NUMERIC(9) REFERENCES NUNCA_INJOIN.Cliente,
	fecha_consumo DATETIME
	)

/*
 *
 *	INSERTS
 *
 */
/* Funcionalidades */
INSERT INTO NUNCA_INJOIN.Funcionalidad (funcionalidad_id)
VALUES ('abm de rol')

INSERT INTO NUNCA_INJOIN.Funcionalidad (funcionalidad_id)
VALUES ('registro de usuario')

INSERT INTO NUNCA_INJOIN.Funcionalidad (funcionalidad_id)
VALUES ('abm de clientes')

INSERT INTO NUNCA_INJOIN.Funcionalidad (funcionalidad_id)
VALUES ('abm de proveedor')

INSERT INTO NUNCA_INJOIN.Funcionalidad (funcionalidad_id)
VALUES ('carga de credito')

INSERT INTO NUNCA_INJOIN.Funcionalidad (funcionalidad_id)
VALUES ('confeccion y publicacion de ofertas')

INSERT INTO NUNCA_INJOIN.Funcionalidad (funcionalidad_id)
VALUES ('comprar oferta')

INSERT INTO NUNCA_INJOIN.Funcionalidad (funcionalidad_id)
VALUES ('entrega de oferta')

INSERT INTO NUNCA_INJOIN.Funcionalidad (funcionalidad_id)
VALUES ('facturacion a proveedor')

INSERT INTO NUNCA_INJOIN.Funcionalidad (funcionalidad_id)
VALUES ('listado estadistico')
GO

/* Roles */
INSERT INTO NUNCA_INJOIN.Rol (rol_id)
VALUES ('administrador general') -- Lo que usan durante los tests - tiene todas las funcionalidades (Pag 14)

INSERT INTO NUNCA_INJOIN.Rol (rol_id)
VALUES ('administrativo')

INSERT INTO NUNCA_INJOIN.Rol (rol_id)
VALUES ('cliente')

INSERT INTO NUNCA_INJOIN.Rol (rol_id)
VALUES ('proveedor')
GO

/* Funcionalidades por rol */
--Administrador general (Todas las funcionalidades)
INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	'administrador general',
	'abm de rol'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	'administrador general',
	'registro de usuario'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	'administrador general',
	'abm de clientes'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	'administrador general',
	'abm de proveedor'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	'administrador general',
	'carga de credito'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	'administrador general',
	'comprar oferta'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	'administrador general',
	'confeccion y publicacion de ofertas'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	'administrador general',
	'entrega de oferta'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	'administrador general',
	'facturacion a proveedor'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	'administrador general',
	'listado estadistico'
	)

--Administrativo
INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	'administrativo',
	'abm de rol'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	'administrativo',
	'registro de usuario'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	'administrativo',
	'abm de clientes'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	'administrativo',
	'abm de proveedor'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	'administrativo',
	'facturacion a proveedor'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	'administrativo',
	'listado estadistico'
	)

-- Cliente
INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	'cliente',
	'registro de usuario'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	'cliente',
	'abm de clientes'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	'cliente',
	'carga de credito'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	'cliente',
	'comprar oferta'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	'proveedor',
	'registro de usuario'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	'proveedor',
	'abm de proveedor'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	'proveedor',
	'confeccion y publicacion de ofertas'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	'proveedor',
	'entrega de oferta'
	)

/*
 * Contraseñas
 */
DECLARE @PassGeneral NVARCHAR(32)
SET @PassGeneral = 'w23e'
DECLARE @HashedPass VARBINARY(32)
SET @HashedPass = hashbytes('SHA2_256', @PassGeneral)

--ADMINISTRADOR GENERAL
INSERT INTO NUNCA_INJOIN.Usuario (
	usuario_id,
	rol_id,
	contrasenia
	)
VALUES (
	'admin',
	'administrador general',
	@HashedPass
	)


/*
 *MIGRACION
 */

/* CLIENTES */
INSERT INTO NUNCA_INJOIN.Cliente (
	nombre
	,apellido
	,dni
	,mail
	,telefono
	,domicilio
	,localidad
	,fecha_nac
	)
SELECT DISTINCT Cli_Nombre
	,Cli_Apellido
	,Cli_Dni
	,Cli_Mail
	,Cli_Telefono
	,Cli_Direccion
	,Cli_Ciudad
	,Cli_Fecha_Nac
FROM gd_esquema.Maestra
GO
/* VER QUE HACER CON LAS CARGAS DE MARGA SUAREZ */

/* RUBROS */
INSERT INTO NUNCA_INJOIN.Rubro (nombre_rubro) 
SELECT DISTINCT Provee_Rubro
FROM gd_esquema.Maestra
WHERE Provee_Rubro IS NOT NULL

GO

/* PROVEEDORES */

INSERT INTO NUNCA_INJOIN.Proveedor (
	razon_social,
	telefono,
	domicilio,
	ciudad,
	cuit,
	rubro_id
	)
SELECT DISTINCT Provee_RS
	, Provee_Telefono
	, Provee_Dom
	, Provee_Ciudad
	, Provee_CUIT
	, (SELECT rubro_id FROM NUNCA_INJOIN.Rubro WHERE Provee_Rubro = nombre_rubro)
FROM gd_esquema.Maestra
WHERE Provee_CUIT IS NOT NULL
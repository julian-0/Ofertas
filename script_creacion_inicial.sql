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
			WHERE object_name(object_id) = 'Cupon'
				AND schema_name(schema_id) = 'NUNCA_INJOIN'
			)
		DROP TABLE NUNCA_INJOIN.Cupon

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

IF EXISTS (
		SELECT *
		FROM sys.VIEWS
		WHERE object_name(object_id) = 'RolesActivos'
			AND schema_name(schema_id) = 'NUNCA_INJOIN'
		)
BEGIN
	DROP VIEW NUNCA_INJOIN.RolesActivos
END
GO

IF EXISTS (
		SELECT *
		FROM sys.VIEWS
		WHERE object_name(object_id) = 'UsuariosHabilitados'
			AND schema_name(schema_id) = 'NUNCA_INJOIN'
		)
BEGIN
	DROP VIEW NUNCA_INJOIN.UsuariosHabilitados
END
GO

IF EXISTS (
		SELECT *
		FROM sys.VIEWS
		WHERE object_name(object_id) = 'CuponesEntregados'
			AND schema_name(schema_id) = 'NUNCA_INJOIN'
		)
BEGIN
	DROP VIEW NUNCA_INJOIN.CuponesEntregados
END
GO

--Functions
IF EXISTS (
		SELECT *
		FROM sys.objects
		WHERE object_name(object_id) = 'OfertasActivas'
			AND schema_name(schema_id) = 'NUNCA_INJOIN'
		)
BEGIN
	DROP FUNCTION NUNCA_INJOIN.OfertasActivas
END
GO

IF EXISTS (
		SELECT *
		FROM sys.objects
		WHERE object_name(object_id) = 'CargasRealizadas'
			AND schema_name(schema_id) = 'NUNCA_INJOIN'
		)
BEGIN
	DROP FUNCTION NUNCA_INJOIN.CargasRealizadas
END
GO

IF EXISTS (
		SELECT *
		FROM sys.objects
		WHERE object_name(object_id) = 'FacturasEmitidas'
			AND schema_name(schema_id) = 'NUNCA_INJOIN'
		)
BEGIN
	DROP FUNCTION NUNCA_INJOIN.FacturasEmitidas
END
GO

IF EXISTS (
		SELECT *
		FROM sys.objects
		WHERE object_name(object_id) = 'CuponesReales'
			AND schema_name(schema_id) = 'NUNCA_INJOIN'
		)
BEGIN
	DROP FUNCTION NUNCA_INJOIN.CuponesReales
END
GO

IF EXISTS (
		SELECT *
		FROM sys.procedures
		WHERE name = 'sp_validarUsuario'
		)
BEGIN
	DROP PROCEDURE NUNCA_INJOIN.sp_validarUsuario
END
GO

/*
 *	CREACIÓN DE TABLAS
 */
USE GD2C2019
GO

CREATE TABLE NUNCA_INJOIN.Funcionalidad ("funcionalidad_id" VARCHAR(50) PRIMARY KEY);

CREATE TABLE NUNCA_INJOIN.Rol (
	"rol_id" NUMERIC(9) identity PRIMARY KEY,
	nombre_rol VARCHAR(50) NOT NULL,
	"baja_logica" CHAR(1) NOT NULL DEFAULT 'N' CHECK (baja_logica IN ('S', 'N'))
	);

CREATE TABLE NUNCA_INJOIN.FuncionalidadPorRol (
	"funcionalidad_id" VARCHAR(50) REFERENCES NUNCA_INJOIN.Funcionalidad,
	"rol_id" NUMERIC(9) REFERENCES NUNCA_INJOIN.Rol,
	PRIMARY KEY (
		rol_id,
		funcionalidad_id
		)
	);

CREATE TABLE NUNCA_INJOIN.Usuario (
	"usuario_id" VARCHAR(50) PRIMARY KEY,
	"rol_id" NUMERIC(9) REFERENCES NUNCA_INJOIN.Rol,
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

CREATE TABLE NUNCA_INJOIN.FacturaProveedor (
	factura_numero NUMERIC(18, 0) identity PRIMARY KEY,
	proveedor_id NUMERIC(9) REFERENCES NUNCA_INJOIN.Proveedor,
	fecha DATETIME,
	importe NUMERIC(26, 2)
	)

SET IDENTITY_INSERT NUNCA_INJOIN.FacturaProveedor ON

CREATE TABLE NUNCA_INJOIN.Cupon (
	cupon_id NUMERIC(9) identity PRIMARY KEY,
	oferta_codigo NVARCHAR(50) REFERENCES NUNCA_INJOIN.Oferta,
	cliente_compra_id NUMERIC(9) REFERENCES NUNCA_INJOIN.Cliente,
	factura_id NUMERIC(18, 0) REFERENCES NUNCA_INJOIN.FacturaProveedor,
	fecha_compra DATETIME,
	cantidad_comprada NUMERIC(18, 0),
	fue_entregado CHAR(1) NOT NULL DEFAULT 'N' CHECK (fue_entregado IN ('S', 'N')),
	vencimiento DATETIME,
	fecha_entrega DATETIME -- Droppeada al terminar la migración
	)

CREATE TABLE NUNCA_INJOIN.Entrega (
	entrega_id NUMERIC(9) identity,
	cupon_id NUMERIC(9) REFERENCES NUNCA_INJOIN.Cupon,
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
INSERT INTO NUNCA_INJOIN.Rol (nombre_rol)
VALUES ('administrador general') -- Lo que usan durante los tests - tiene todas las funcionalidades (Pag 14)

INSERT INTO NUNCA_INJOIN.Rol (nombre_rol)
VALUES ('administrativo')

INSERT INTO NUNCA_INJOIN.Rol (nombre_rol)
VALUES ('cliente')

INSERT INTO NUNCA_INJOIN.Rol (nombre_rol)
VALUES ('proveedor')
GO

/* Funcionalidades por rol */
--Administrador general (Todas las funcionalidades)
INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	(
		SELECT rol_id
		FROM NUNCA_INJOIN.Rol
		WHERE nombre_rol = 'administrador general'
		),
	'abm de rol'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	(
		SELECT rol_id
		FROM NUNCA_INJOIN.Rol
		WHERE nombre_rol = 'administrador general'
		),
	'registro de usuario'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	(
		SELECT rol_id
		FROM NUNCA_INJOIN.Rol
		WHERE nombre_rol = 'administrador general'
		),
	'abm de clientes'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	(
		SELECT rol_id
		FROM NUNCA_INJOIN.Rol
		WHERE nombre_rol = 'administrador general'
		),
	'abm de proveedor'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	(
		SELECT rol_id
		FROM NUNCA_INJOIN.Rol
		WHERE nombre_rol = 'administrador general'
		),
	'carga de credito'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	(
		SELECT rol_id
		FROM NUNCA_INJOIN.Rol
		WHERE nombre_rol = 'administrador general'
		),
	'comprar oferta'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	(
		SELECT rol_id
		FROM NUNCA_INJOIN.Rol
		WHERE nombre_rol = 'administrador general'
		),
	'confeccion y publicacion de ofertas'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	(
		SELECT rol_id
		FROM NUNCA_INJOIN.Rol
		WHERE nombre_rol = 'administrador general'
		),
	'entrega de oferta'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	(
		SELECT rol_id
		FROM NUNCA_INJOIN.Rol
		WHERE nombre_rol = 'administrador general'
		),
	'facturacion a proveedor'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	(
		SELECT rol_id
		FROM NUNCA_INJOIN.Rol
		WHERE nombre_rol = 'administrador general'
		),
	'listado estadistico'
	)

--Administrativo
INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	(
		SELECT rol_id
		FROM NUNCA_INJOIN.Rol
		WHERE nombre_rol = 'administrativo'
		),
	'abm de rol'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	(
		SELECT rol_id
		FROM NUNCA_INJOIN.Rol
		WHERE nombre_rol = 'administrativo'
		),
	'registro de usuario'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	(
		SELECT rol_id
		FROM NUNCA_INJOIN.Rol
		WHERE nombre_rol = 'administrativo'
		),
	'abm de clientes'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	(
		SELECT rol_id
		FROM NUNCA_INJOIN.Rol
		WHERE nombre_rol = 'administrativo'
		),
	'abm de proveedor'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	(
		SELECT rol_id
		FROM NUNCA_INJOIN.Rol
		WHERE nombre_rol = 'administrativo'
		),
	'facturacion a proveedor'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	(
		SELECT rol_id
		FROM NUNCA_INJOIN.Rol
		WHERE nombre_rol = 'administrativo'
		),
	'listado estadistico'
	)

-- Cliente
INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	(
		SELECT rol_id
		FROM NUNCA_INJOIN.Rol
		WHERE nombre_rol = 'cliente'
		),
	'registro de usuario'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	(
		SELECT rol_id
		FROM NUNCA_INJOIN.Rol
		WHERE nombre_rol = 'cliente'
		),
	'abm de clientes'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	(
		SELECT rol_id
		FROM NUNCA_INJOIN.Rol
		WHERE nombre_rol = 'cliente'
		),
	'carga de credito'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	(
		SELECT rol_id
		FROM NUNCA_INJOIN.Rol
		WHERE nombre_rol = 'cliente'
		),
	'comprar oferta'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	(
		SELECT rol_id
		FROM NUNCA_INJOIN.Rol
		WHERE nombre_rol = 'proveedor'
		),
	'registro de usuario'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	(
		SELECT rol_id
		FROM NUNCA_INJOIN.Rol
		WHERE nombre_rol = 'proveedor'
		),
	'abm de proveedor'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	(
		SELECT rol_id
		FROM NUNCA_INJOIN.Rol
		WHERE nombre_rol = 'proveedor'
		),
	'confeccion y publicacion de ofertas'
	)

INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol (
	rol_id,
	funcionalidad_id
	)
VALUES (
	(
		SELECT rol_id
		FROM NUNCA_INJOIN.Rol
		WHERE nombre_rol = 'proveedor'
		),
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
	(
		SELECT rol_id
		FROM NUNCA_INJOIN.Rol
		WHERE nombre_rol = 'administrador general'
		),
	@HashedPass
	)

/*
 *MIGRACION
 */
/* CLIENTES */
INSERT INTO NUNCA_INJOIN.Cliente (
	nombre,
	apellido,
	dni,
	mail,
	telefono,
	domicilio,
	localidad,
	fecha_nac
	)
SELECT DISTINCT Cli_Nombre,
	Cli_Apellido,
	Cli_Dni,
	Cli_Mail,
	Cli_Telefono,
	Cli_Direccion,
	Cli_Ciudad,
	Cli_Fecha_Nac
FROM gd_esquema.Maestra
GO

INSERT INTO NUNCA_INJOIN.Cliente (
	nombre,
	apellido,
	dni,
	mail,
	telefono,
	domicilio,
	localidad,
	fecha_nac
	)
SELECT DISTINCT Cli_Nombre,
	Cli_Dest_Apellido,
	Cli_Dest_Dni,
	Cli_Dest_Mail,
	Cli_Dest_Telefono,
	Cli_Dest_Direccion,
	Cli_Dest_Ciudad,
	Cli_Dest_Fecha_Nac
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
SELECT DISTINCT Provee_RS,
	Provee_Telefono,
	Provee_Dom,
	Provee_Ciudad,
	Provee_CUIT,
	(
		SELECT rubro_id
		FROM NUNCA_INJOIN.Rubro
		WHERE Provee_Rubro = nombre_rubro
		)
FROM gd_esquema.Maestra
WHERE Provee_CUIT IS NOT NULL

/* OFERTAS */
INSERT INTO NUNCA_INJOIN.Oferta (
	oferta_codigo,
	proveedor_id,
	descripcion,
	fecha_publicacion,
	fecha_vencimiento,
	precio_oferta,
	precio_lista,
	cantidad_disponible
	)
SELECT DISTINCT Oferta_Codigo,
	(
		SELECT proveedor_id
		FROM NUNCA_INJOIN.Proveedor
		WHERE Provee_RS = razon_social
			AND Provee_CUIT = cuit
		),
	Oferta_Descripcion,
	Oferta_Fecha,
	Oferta_Fecha_Venc,
	Oferta_Precio,
	Oferta_Precio_Ficticio,
	Oferta_Cantidad
FROM gd_esquema.Maestra
WHERE Oferta_Codigo IS NOT NULL

/* FACTURAS */
INSERT INTO NUNCA_INJOIN.FacturaProveedor (
	factura_numero,
	proveedor_id,
	fecha,
	importe
	)
SELECT Factura_Nro,
	(
		SELECT proveedor_id
		FROM NUNCA_INJOIN.Proveedor
		WHERE Provee_RS = razon_social
			AND Provee_CUIT = cuit
		),
	Factura_Fecha,
	sum(Oferta_Precio)
FROM gd_esquema.Maestra
WHERE Factura_Fecha IS NOT NULL
	AND Factura_Nro IS NOT NULL
GROUP BY Factura_Fecha,
	Factura_Nro,
	Provee_RS,
	Provee_CUIT

/* VER QUE HAY ALGUNAS OFERTAS QUE SE REPITEN, AUNQUE TENGAN DIFERENTE CODIGO DE OFERTA */
/* CUPONES */
USE GD2C2019
GO

DECLARE @fechaConfig DATETIME = convert(DATETIME, '5-5-2020') --TODO: Tomar del .config
	/*
Los casos que tienen todos los campos iguales salvo [Oferta_Entregado_Fecha],
[Factura_Nro] y [Factura_Fecha] se apalnaron y se consideraron como una sola compra
*/

INSERT INTO NUNCA_INJOIN.Cupon (
	oferta_codigo,
	cliente_compra_id,
	factura_id,
	fecha_compra,
	fue_entregado,
	fecha_entrega, -- Droppeado al terminar la migracion de Entrega
	cantidad_comprada
	)
SELECT Oferta_Codigo,
	(
		SELECT cliente_id
		FROM NUNCA_INJOIN.Cliente
		WHERE Cli_Dni = dni
			AND Cli_Nombre = nombre
			AND Cli_Apellido = apellido
			AND Cli_Mail = mail
			AND Cli_Ciudad = localidad
		) id_cli,
	numero_factura,
	Oferta_Fecha_Compra,
	(
		CASE 
			WHEN fecha_entregado > @fechaConfig
				THEN 'S'
			ELSE 'N'
			END
		) entregado,
	fecha_entregado,
	cant_compra
FROM (
	SELECT [Cli_Nombre],
		[Cli_Apellido],
		[Cli_Dni],
		[Oferta_Codigo],
		[Cli_Mail],
		[Cli_Ciudad],
		Max([Oferta_Entregado_Fecha]) AS fecha_entregado,
		Max([Factura_Nro]) AS numero_factura,
		Max([Factura_Fecha]) AS fecha_factura,
		Oferta_Fecha_Compra,
		-- Consideramos que cada nueva compra en la Maestra siempre tiene esos 3 campos en NULL
		SUM(CASE 
				WHEN [Oferta_Entregado_Fecha] IS NULL
					AND [Factura_Nro] IS NULL
					AND [Factura_Fecha] IS NULL
					THEN 1
				ELSE 0
				END) AS cant_compra
	FROM [GD2C2019].[gd_esquema].[Maestra]
	GROUP BY [Cli_Nombre],
		[Cli_Apellido],
		[Cli_Dni],
		[Oferta_Codigo],
		[Cli_Mail],
		[Cli_Ciudad],
		Oferta_Fecha_Compra
	) cupones_normales
WHERE Oferta_Fecha_Compra IS NOT NULL

INSERT INTO NUNCA_INJOIN.Entrega (
	cupon_id,
	--cliente_entrega_id, No vale la pena - no estaba implementado en el sist anterior
	fecha_consumo
	)
SELECT cupon_id,
	fecha_entrega
FROM NUNCA_INJOIN.Cupon
WHERE fecha_entrega IS NOT NULL
GO

ALTER TABLE NUNCA_INJOIN.Cupon

DROP COLUMN fecha_entrega
GO

INSERT INTO NUNCA_INJOIN.Carga (
	cliente_id,
	fecha,
	tipo_pago,
	monto
	)
SELECT (
		SELECT cliente_id
		FROM NUNCA_INJOIN.Cliente
		WHERE Cli_Dni = dni
			AND Cli_Nombre = nombre
			AND Cli_Apellido = apellido
			AND Cli_Mail = mail
			AND Cli_Ciudad = localidad
		),
	Carga_Fecha,
	Tipo_Pago_Desc,
	Carga_Credito
FROM gd_esquema.Maestra
WHERE Carga_Credito IS NOT NULL
	AND Carga_Fecha IS NOT NULL
GO

/*
 * VIEWS Y FUNCIONES
 */
/*Drops*/
--Views
--Roles activos
USE GD2C2019
GO

CREATE VIEW NUNCA_INJOIN.RolesActivos
AS
SELECT rol_id
FROM NUNCA_INJOIN.Rol
WHERE baja_logica = 'N'
GO

--Usuarios habilitados
USE GD2C2019
GO

CREATE VIEW NUNCA_INJOIN.UsuariosHabilitados
AS
SELECT usuario_id
FROM NUNCA_INJOIN.Usuario
WHERE baja_logica = 'N'
	AND intentos_fallidos <= 3
GO

--Cupones Entregados
CREATE VIEW NUNCA_INJOIN.CuponesEntregados
AS
SELECT cupon_id
FROM NUNCA_INJOIN.Cupon
WHERE fue_entregado = 'S'
GO

--Ofertas Activas (Es una funcion para que pueda recibir la fecha y tratarse como view)
CREATE FUNCTION NUNCA_INJOIN.OfertasActivas (@fechaActual DATETIME)
RETURNS TABLE
AS
RETURN (
		SELECT *
		FROM NUNCA_INJOIN.Oferta
		WHERE @fechaActual BETWEEN fecha_publicacion AND fecha_vencimiento
		)
GO

-- Cargas que ya se acreditaron
CREATE FUNCTION NUNCA_INJOIN.CargasRealizadas (@fechaActual DATETIME)
RETURNS TABLE
AS
RETURN (
		SELECT *
		FROM NUNCA_INJOIN.Carga
		WHERE fecha < @fechaActual
		)
GO

-- Facturas que ya se emitieron
CREATE FUNCTION NUNCA_INJOIN.FacturasEmitidas (@fechaActual DATETIME)
RETURNS TABLE
AS
RETURN (
		SELECT *
		FROM NUNCA_INJOIN.FacturaProveedor
		WHERE fecha < @fechaActual
		)
GO

-- Cupones que verdaderamente ya se compraron
CREATE FUNCTION NUNCA_INJOIN.CuponesReales (@fechaActual DATETIME)
RETURNS TABLE
AS
RETURN (
		SELECT *
		FROM NUNCA_INJOIN.Cupon
		WHERE fecha_compra < @fechaActual
		)
GO

/*
 * PROCEDURES
 */
USE GD2C2019
GO

--Procedure para validar usuario y contrasenia ingresados
IF OBJECT_ID('NUNCA_INJOIN.sp_validarUsuario', 'P') IS NOT NULL  
   DROP PROCEDURE NUNCA_INJOIN.sp_validarUsuario;  
GO  
CREATE PROCEDURE NUNCA_INJOIN.sp_validarUsuario (
	@id_ingresado NVARCHAR(50),
	@contra_ingresada NVARCHAR(32)
	)
AS
BEGIN
	DECLARE @intentos_fallidos SMALLINT,
		@contra_hasheada VARBINARY(32),
		@contra_real VARBINARY(32),
		@valor_retorno SMALLINT,
		@baja_logica NCHAR(1)

	SET @intentos_fallidos = (
			SELECT intentos_fallidos
			FROM [NUNCA_INJOIN].Usuario
			WHERE usuario_id = @id_ingresado
			)
	SET @contra_hasheada = hashbytes('SHA2_256', @contra_ingresada)
	SET @contra_real = (
			SELECT contrasenia
			FROM [NUNCA_INJOIN].Usuario
			WHERE usuario_id = @id_ingresado
			)
	SET @baja_logica = (
			SELECT baja_logica
			FROM [NUNCA_INJOIN].Usuario
			WHERE usuario_id = @id_ingresado
			)

	IF NOT EXISTS (
			SELECT usuario_id
			FROM [NUNCA_INJOIN].Usuario
			WHERE usuario_id = @id_ingresado
				AND baja_logica = 'N'
			) --veo si no existe el usuario
		SET @valor_retorno = - 2 --no pudo loggear, no existe el usuario
	ELSE IF (
			@intentos_fallidos < 3
			AND @baja_logica = 'N'
			) --usuario existe y puede intentar todavia
	BEGIN
		IF (@contra_real = @contra_hasheada)
		BEGIN
			SET @valor_retorno = 1 --logg posible, salio todo bien 

			UPDATE [NUNCA_INJOIN].Usuario
			SET intentos_fallidos = 0
			WHERE usuario_id = @id_ingresado
		END
		ELSE
		BEGIN
			SET @valor_retorno = 0 --ingreso mal la contra pero tiene intentos posibles

			UPDATE [NUNCA_INJOIN].Usuario
			SET intentos_fallidos = intentos_fallidos + 1
			WHERE usuario_id = @id_ingresado
		END
	END
	ELSE
	BEGIN
		UPDATE [NUNCA_INJOIN].Usuario
		SET baja_logica = 'S'
		WHERE usuario_id = @id_ingresado

		SET @valor_retorno = - 1 --El usuario excedio esas tres oportunidades y fue dado de baja (por ahora borrado)
	END

	RETURN @valor_retorno
END
GO

IF OBJECT_ID('NUNCA_INJOIN.sp_obtenerFuncionalidades', 'P') IS NOT NULL  
   DROP PROCEDURE NUNCA_INJOIN.sp_obtenerFuncionalidades;  
GO  
CREATE PROCEDURE NUNCA_INJOIN.sp_obtenerFuncionalidades (@id_usuario NVARCHAR(50),@puedeRol smallint out,@puedeRegUser smallint out,
@puedeAbmCli smallint out,@puedeAbmPro smallint out,@puedeCargar smallint out,@puedeComprar smallint out,@puedeOfertar smallint out,
@puedeFacturar smallint out,@puedeEst smallint out)
as
begin
	declare @idRol nvarchar(255)
	
	select @idRol = rol_id
	from NUNCA_INJOIN.Usuario
	where usuario_id = @id_usuario
	
	set @puedeRol = 0
	set @puedeRegUser=0
	set @puedeAbmCli=0
	set @puedeAbmPro=0
	set @puedeCargar=0
	set @puedeComprar=0
	set @puedeOfertar=0
	set @puedeFacturar=0
	set @puedeEst=0

	if exists (select 1
				from NUNCA_INJOIN.FuncionalidadPorRol
				where rol_id = @idRol and funcionalidad_id = 'abm de rol')
				set @puedeRol = 1

	if exists (select 1
				from NUNCA_INJOIN.FuncionalidadPorRol
				where rol_id = @idRol and funcionalidad_id = 'registro de usuario')
				set @puedeRegUser = 1

	if exists (select 1
				from NUNCA_INJOIN.FuncionalidadPorRol
				where rol_id = @idRol and funcionalidad_id = 'abm de clientes')
				set @puedeAbmCli = 1

	if exists (select 1
				from NUNCA_INJOIN.FuncionalidadPorRol
				where rol_id = @idRol and funcionalidad_id = 'abm de proveedor')
				set @puedeAbmPro = 1

	if exists (select 1
				from NUNCA_INJOIN.FuncionalidadPorRol
				where rol_id = @idRol and funcionalidad_id = 'carga de credito')
				set @puedeCargar = 1

	if exists (select 1
				from NUNCA_INJOIN.FuncionalidadPorRol
				where rol_id = @idRol and funcionalidad_id = 'comprar oferta')
				set @puedeComprar = 1

	if exists (select 1
				from NUNCA_INJOIN.FuncionalidadPorRol
				where rol_id = @idRol and funcionalidad_id = 'confeccion y publicacion de ofertas')
				set @puedeOfertar = 1

	if exists (select 1
				from NUNCA_INJOIN.FuncionalidadPorRol
				where rol_id = @idRol and funcionalidad_id = 'facturacion a proveedor')
				set @puedeFacturar = 1

	if exists (select 1
				from NUNCA_INJOIN.FuncionalidadPorRol
				where rol_id = @idRol and funcionalidad_id = 'listado estadistico')
				set @puedeEst = 1
end
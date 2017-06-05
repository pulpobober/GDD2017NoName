USE [GD1C2017]
GO

	IF OBJECT_ID('NONAME.DROP_FK') IS NOT NULL
	DROP PROCEDURE NONAME.DROP_FK
	GO

CREATE PROCEDURE NONAME.DROP_FK
as
	IF OBJECT_ID('NONAME.FK_Viaje_Turno') IS NOT NULL
	ALTER TABLE [NONAME].[Viaje] DROP CONSTRAINT [FK_Viaje_Turno]
	
	IF OBJECT_ID('NONAME.FK_Viaje_Cliente') IS NOT NULL
	ALTER TABLE [NONAME].[Viaje] DROP CONSTRAINT [FK_Viaje_Cliente]
	
	IF OBJECT_ID('NONAME.FK_Viaje_Chofer') IS NOT NULL
	ALTER TABLE [NONAME].[Viaje] DROP CONSTRAINT [FK_Viaje_Chofer]
	
	IF OBJECT_ID('NONAME.FK_Rol_Usuario_Usuario') IS NOT NULL
	ALTER TABLE [NONAME].[Rol_Usuario] DROP CONSTRAINT [FK_Rol_Usuario_Usuario]
	
	IF OBJECT_ID('NONAME.FK_Rol_Usuario_Rol') IS NOT NULL
	ALTER TABLE [NONAME].[Rol_Usuario] DROP CONSTRAINT [FK_Rol_Usuario_Rol]
	
	IF OBJECT_ID('NONAME.FK_Rendicion_Viaje_Viaje') IS NOT NULL
	ALTER TABLE [NONAME].[Rendicion_Viaje] DROP CONSTRAINT [FK_Rendicion_Viaje_Viaje]
	
	IF OBJECT_ID('NONAME.FK_Rendicion_Viaje_Rendicion') IS NOT NULL
	ALTER TABLE [NONAME].[Rendicion_Viaje] DROP CONSTRAINT [FK_Rendicion_Viaje_Rendicion]
	
	IF OBJECT_ID('NONAME.FK_Rendicion_Turno') IS NOT NULL
	ALTER TABLE [NONAME].[Rendicion] DROP CONSTRAINT [FK_Rendicion_Turno]
	
	IF OBJECT_ID('NONAME.FK_Rendicion_Chofer') IS NOT NULL
	ALTER TABLE [NONAME].[Rendicion] DROP CONSTRAINT [FK_Rendicion_Chofer]
	
	IF OBJECT_ID('NONAME.FK_Funcion_Rol_Rol') IS NOT NULL
	ALTER TABLE [NONAME].[Funcion_Rol] DROP CONSTRAINT [FK_Funcion_Rol_Rol]
	
	IF OBJECT_ID('NONAME.FK_Funcion_Rol_Funcion') IS NOT NULL
	ALTER TABLE [NONAME].[Funcion_Rol] DROP CONSTRAINT [FK_Funcion_Rol_Funcion]
	
	IF OBJECT_ID('NONAME.FK_Factura_Viaje') IS NOT NULL
	ALTER TABLE [NONAME].[Factura] DROP CONSTRAINT [FK_Factura_Viaje]
	
	IF OBJECT_ID('NONAME.FK_Factura_Cliente') IS NOT NULL
	ALTER TABLE [NONAME].[Factura] DROP CONSTRAINT [FK_Factura_Cliente]
	
	IF OBJECT_ID('NONAME.FK_Cliente_Usuario') IS NOT NULL
	ALTER TABLE [NONAME].[Cliente] DROP CONSTRAINT [FK_Cliente_Usuario]
	
	IF OBJECT_ID('NONAME.FK_Chofer_Usuario') IS NOT NULL
	ALTER TABLE [NONAME].[Chofer] DROP CONSTRAINT [FK_Chofer_Usuario]

	IF OBJECT_ID('NONAME.FK_Auto_Chofer_Chofer') IS NOT NULL
	ALTER TABLE [NONAME].[Auto_Chofer] DROP CONSTRAINT [FK_Auto_Chofer_Chofer]
	
	IF OBJECT_ID('NONAME.FK_Auto_Chofer_Auto') IS NOT NULL
	ALTER TABLE [NONAME].[Auto_Chofer] DROP CONSTRAINT [FK_Auto_Chofer_Auto]
	
	IF OBJECT_ID('NONAME.FK_Auto_Turno') IS NOT NULL
	ALTER TABLE [NONAME].[Auto] DROP CONSTRAINT [FK_Auto_Turno]
	
	IF OBJECT_ID('NONAME.FK_Auto_Marca') IS NOT NULL
	ALTER TABLE [NONAME].[Auto] DROP CONSTRAINT [FK_Auto_Marca]
	

GO


-- Validacion de existencia 

IF SCHEMA_ID('NONAME') IS NOT NULL
BEGIN

--constraints
	
EXEC NONAME.DROP_FK

--tablas

  IF OBJECT_ID('NONAME.Viaje') IS NOT NULL
	DROP TABLE [NONAME].[Viaje]

  IF OBJECT_ID('NONAME.Usuario') IS NOT NULL
	DROP TABLE [NONAME].[Usuario]

  IF OBJECT_ID('NONAME.Turno') IS NOT NULL
	DROP TABLE [NONAME].[Turno]

  IF OBJECT_ID('NONAME.Rol_Usuario') IS NOT NULL
	DROP TABLE [NONAME].[Rol_Usuario]

  IF OBJECT_ID('NONAME.Rol') IS NOT NULL
	DROP TABLE [NONAME].[Rol]

  IF OBJECT_ID('NONAME.Rendicion_Viaje') IS NOT NULL
	DROP TABLE [NONAME].[Rendicion_Viaje]

  IF OBJECT_ID('NONAME.Rendicion') IS NOT NULL
	DROP TABLE [NONAME].[Rendicion]

  IF OBJECT_ID('NONAME.Marca') IS NOT NULL
	DROP TABLE [NONAME].[Marca]

  IF OBJECT_ID('NONAME.Funcion_Rol') IS NOT NULL
	DROP TABLE [NONAME].[Funcion_Rol]

  IF OBJECT_ID('NONAME.Funcion') IS NOT NULL
	DROP TABLE [NONAME].[Funcion]

  IF OBJECT_ID('NONAME.Factura') IS NOT NULL
	DROP TABLE [NONAME].[Factura]

  IF OBJECT_ID('NONAME.Cliente') IS NOT NULL
	DROP TABLE [NONAME].[Cliente]

  IF OBJECT_ID('NONAME.Chofer') IS NOT NULL
	DROP TABLE [NONAME].[Chofer]

  IF OBJECT_ID('NONAME.Auto_Chofer') IS NOT NULL
	DROP TABLE [NONAME].[Auto_Chofer]

  IF OBJECT_ID('NONAME.Auto') IS NOT NULL
	DROP TABLE [NONAME].[Auto]

--Stored Procedures
  IF OBJECT_ID('NONAME.DROP_FK') IS NOT NULL
	DROP PROCEDURE NONAME.DROP_FK

	IF OBJECT_ID('NONAME.sproc_rol_alta') IS NOT NULL
		DROP PROCEDURE NONAME.sproc_rol_alta

	IF OBJECT_ID('NONAME.sproc_rol_baja') IS NOT NULL
		DROP PROCEDURE NONAME.sproc_rol_baja

	IF OBJECT_ID('NONAME.sproc_rol_modificacion') IS NOT NULL
		DROP PROCEDURE NONAME.sproc_rol_modificacion

	IF OBJECT_ID('NONAME.sproc_cliente_alta') IS NOT NULL
		DROP PROCEDURE NONAME.sproc_cliente_alta

	IF OBJECT_ID('NONAME.sproc_cliente_baja') IS NOT NULL
		DROP PROCEDURE NONAME.sproc_cliente_baja

	IF OBJECT_ID('NONAME.sproc_cliente_modificacion') IS NOT NULL
		DROP PROCEDURE NONAME.sproc_cliente_modificacion

	IF OBJECT_ID('NONAME.sproc_automovil_alta') IS NOT NULL
		DROP PROCEDURE NONAME.sproc_automovil_alta

	IF OBJECT_ID('NONAME.sproc_automovil_baja') IS NOT NULL
		DROP PROCEDURE NONAME.sproc_automovil_baja

	IF OBJECT_ID('NONAME.sproc_automovil_modificacion') IS NOT NULL
		DROP PROCEDURE NONAME.sproc_automovil_modificacion

--User-Defined Data & Table Types
	IF TYPE_ID('NONAME.ListaFuncionalidadesRol') IS NOT NULL
		DROP TYPE NONAME.ListaFuncionalidadesRol

--Ahora sí, el Schema
  DROP SCHEMA [NONAME]

END
GO
 

--Creacion de Esquema 

CREATE SCHEMA [NONAME] AUTHORIZATION [gd]
GO

CREATE TABLE [NONAME].[Factura](
	[nro_factura] [numeric](18, 0) NOT NULL,
	[id_cliente] [int] NOT NULL,
	[id_viaje] [int] NOT NULL,
	[fecha_fin] [datetime] NOT NULL,
	[fecha_inicio] [datetime] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[importe] [numeric](18, 0) NOT NULL
)
GO

CREATE TABLE [NONAME].[Cliente](
	[id_cliente] [int] NOT NULL,
	[codigo_postal] [varchar](50)
)
GO

CREATE TABLE [NONAME].[Usuario](
	[id_usuario] [int] IDENTITY(1, 1) NOT NULL,
	[usuario_dni] [numeric](18, 0) NOT NULL,
	[nombre] [varchar](255) NOT NULL,
	[apellido] [varchar](255) NOT NULL,
	[telefono] [numeric](18, 0) NOT NULL,
	[direccion] [varchar](255) NOT NULL,
	[mail] [varchar](50) NOT NULL,
	[fecha_nacimiento] [datetime] NOT NULL,
	[nombre_de_usuario] [nvarchar](50) NOT NULL,
	[contrasena] [nvarchar](255) NOT NULL,
	[habilitado] [bit] NOT NULL,
	[intentos_fallidos] [int] NOT NULL
)
GO

CREATE TABLE [NONAME].[Viaje](
	[id_viaje] [int] IDENTITY(1, 1) NOT NULL,
	[fecha_hora_inicio] [datetime] NOT NULL,
	[fecha_hora_fin] [datetime] NOT NULL,
	[cantidad_km] [numeric](18, 0) NOT NULL,
	[id_turno] [int] NOT NULL,
	[id_chofer] [int] NOT NULL,
	[id_cliente] [int] NOT NULL
)
GO

CREATE TABLE [NONAME].[Rendicion_Viaje](
	[id_viaje] [int] NOT NULL,
	[nro_rendicion] [numeric](18, 0) NOT NULL,
	[porcentaje] [numeric](18, 0) NOT NULL
)
GO

CREATE TABLE [NONAME].[Rendicion](
	[nro_rendicion] [numeric](18, 0) NOT NULL,
	[id_chofer] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[id_turno] [int] NOT NULL,
	[importe] [numeric](18, 0) NOT NULL
)
GO

CREATE TABLE [NONAME].[Chofer](
	[id_chofer] [int] NOT NULL,
	[cedula] [varchar](10) NULL,
 )
 GO

CREATE TABLE [NONAME].[Auto_Chofer](
	[id_auto] [int] NOT NULL,
	[id_chofer] [int] NOT NULL
)
GO

CREATE TABLE [NONAME].[Auto](
	[id_auto] [int] IDENTITY(1, 1) NOT NULL,
	[patente_auto] [varchar](10) NOT NULL,
	[modelo] [varchar](255) NOT NULL,
	[id_turno] [int] NOT NULL,
	[id_marca] [int] NOT NULL,
	[rodado] [varchar](10) NULL,
	[habilitado] [bit] NOT NULL,
	[licencia] [varchar](26) NULL
)
GO

CREATE TABLE [NONAME].[Marca](
	[id_marca] [int] NOT NULL,
	[nombre] [varchar](255) NOT NULL
)
GO

CREATE TABLE [NONAME].[Rol_Usuario](
	[id_rol] [int] NOT NULL,
	[id_usuario] [int] NOT NULL
)
GO

CREATE TABLE [NONAME].[Rol](
	[id_rol] [int] IDENTITY(4,1) NOT NULL,
	[tipo] [varchar](255) NOT NULL,
	[habilitado] [bit] NOT NULL
)
GO

CREATE TABLE [NONAME].[Funcion_Rol](
	[id_rol] [int] NOT NULL,
	[id_funcion] [int] NOT NULL
)
GO

CREATE TABLE [NONAME].[Funcion](
	[id_funcion] [int] NOT NULL,
	[descripcion] [varchar](255) NOT NULL
 )
 GO

CREATE TABLE [NONAME].[Turno](
	[id_turno] [int] NOT NULL,
	[hora_inicio] [numeric](18, 0) NOT NULL,
	[hora_fin] [numeric](18, 0) NOT NULL,
	[descripcion] [varchar](255) NOT NULL,
	[valor_km] [numeric](18, 0) NOT NULL,
	[precio_base] [numeric](18, 0) NOT NULL,
	[habilitado] [bit] NOT NULL
 )
 GO


 --Primary keys

ALTER TABLE [NONAME].[Turno]
ADD CONSTRAINT PK_Turno PRIMARY KEY (id_turno)

ALTER TABLE [NONAME].[Factura]
ADD CONSTRAINT PK_Factura PRIMARY KEY (nro_factura)

ALTER TABLE [NONAME].[Cliente]
ADD CONSTRAINT PK_Cliente PRIMARY KEY (id_cliente)

ALTER TABLE [NONAME].[Usuario]
ADD CONSTRAINT PK_Usuario PRIMARY KEY (id_usuario)

ALTER TABLE [NONAME].[Viaje]
ADD CONSTRAINT PK_Viaje PRIMARY KEY (id_viaje)

ALTER TABLE [NONAME].[Rendicion]
ADD CONSTRAINT PK_Rendicion PRIMARY KEY (nro_rendicion)

ALTER TABLE [NONAME].[Chofer]
ADD CONSTRAINT PK_Chofer PRIMARY KEY (id_chofer)

ALTER TABLE [NONAME].[Auto]
ADD CONSTRAINT PK_Auto PRIMARY KEY (id_auto)

ALTER TABLE [NONAME].[Marca]
ADD CONSTRAINT PK_Marca PRIMARY KEY (id_marca)

ALTER TABLE [NONAME].[Rol]
ADD CONSTRAINT PK_Rol PRIMARY KEY (id_rol)

ALTER TABLE [NONAME].[Funcion]
ADD CONSTRAINT PK_Funcion PRIMARY KEY (id_funcion)


--Foreign keys

ALTER TABLE [NONAME].[Factura]
ADD CONSTRAINT FK_Factura_Cliente FOREIGN KEY (id_cliente) 
REFERENCES [NONAME].[Cliente] (id_cliente)

ALTER TABLE [NONAME].[Factura]
CHECK CONSTRAINT [FK_Factura_Cliente]

ALTER TABLE [NONAME].[Factura]
ADD CONSTRAINT FK_Factura_Viaje FOREIGN KEY (id_viaje) 
REFERENCES [NONAME].[Viaje] (id_viaje)

ALTER TABLE [NONAME].[Factura]
CHECK CONSTRAINT [FK_Factura_Viaje]

ALTER TABLE [NONAME].[Rendicion_Viaje]
ADD CONSTRAINT FK_Rendicion_Viaje_Viaje FOREIGN KEY (id_viaje) 
REFERENCES [NONAME].[Viaje] (id_viaje)

ALTER TABLE [NONAME].[Rendicion_Viaje]
CHECK CONSTRAINT [FK_Rendicion_Viaje_Viaje]

ALTER TABLE [NONAME].[Rendicion_Viaje]
ADD CONSTRAINT FK_Rendicion_Viaje_Rendicion FOREIGN KEY (nro_rendicion) 
REFERENCES [NONAME].[Rendicion] (nro_rendicion)

ALTER TABLE [NONAME].[Rendicion_Viaje]
CHECK CONSTRAINT [FK_Rendicion_Viaje_Rendicion]

ALTER TABLE [NONAME].[Rendicion]
ADD CONSTRAINT FK_Rendicion_Chofer FOREIGN KEY (id_chofer) 
REFERENCES [NONAME].[Chofer] (id_chofer)

ALTER TABLE [NONAME].[Rendicion]
CHECK CONSTRAINT [FK_Rendicion_Chofer]

ALTER TABLE [NONAME].[Rendicion]
ADD CONSTRAINT FK_Rendicion_Turno FOREIGN KEY (id_turno) 
REFERENCES [NONAME].[Turno] (id_turno)

ALTER TABLE [NONAME].[Rendicion]
CHECK CONSTRAINT [FK_Rendicion_Turno]

ALTER TABLE [NONAME].[Auto]
ADD CONSTRAINT FK_Auto_Turno FOREIGN KEY (id_turno) 
REFERENCES [NONAME].[Turno] (id_turno)

ALTER TABLE [NONAME].[Auto]
CHECK CONSTRAINT [FK_Auto_Turno]

ALTER TABLE [NONAME].[Auto]
ADD CONSTRAINT FK_Auto_Marca FOREIGN KEY (id_marca) 
REFERENCES [NONAME].[Marca] (id_marca)

ALTER TABLE [NONAME].[Auto]
CHECK CONSTRAINT [FK_Auto_Marca]

ALTER TABLE [NONAME].[Auto_Chofer]
ADD CONSTRAINT FK_Auto_Chofer_Auto FOREIGN KEY (id_auto) 
REFERENCES [NONAME].[Auto] (id_auto)

ALTER TABLE [NONAME].[Auto_Chofer]
CHECK CONSTRAINT [FK_Auto_Chofer_Auto]

ALTER TABLE [NONAME].[Auto_Chofer]
ADD CONSTRAINT FK_Auto_Chofer_Chofer FOREIGN KEY (id_chofer) 
REFERENCES [NONAME].[Chofer] (id_chofer)

ALTER TABLE [NONAME].[Auto_Chofer]
CHECK CONSTRAINT [FK_Auto_Chofer_Chofer]

ALTER TABLE [NONAME].[Chofer]
WITH CHECK ADD CONSTRAINT FK_Chofer_Usuario FOREIGN KEY (id_chofer)
REFERENCES [NONAME].[Usuario] (id_usuario)

ALTER TABLE [NONAME].[Chofer]
CHECK CONSTRAINT [FK_Chofer_Usuario]

ALTER TABLE [NONAME].[Viaje]
WITH CHECK ADD CONSTRAINT FK_Viaje_Turno FOREIGN KEY (id_turno)
REFERENCES [NONAME].[Turno] (id_turno)

ALTER TABLE [NONAME].[Viaje]
CHECK CONSTRAINT [FK_Viaje_Turno]

ALTER TABLE [NONAME].[Viaje]
WITH CHECK ADD CONSTRAINT FK_Viaje_Chofer FOREIGN KEY (id_chofer)
REFERENCES [NONAME].[Chofer] (id_chofer)

ALTER TABLE [NONAME].[Viaje]
CHECK CONSTRAINT [FK_Viaje_Chofer]

ALTER TABLE [NONAME].[Viaje]
WITH CHECK ADD CONSTRAINT FK_Viaje_Cliente FOREIGN KEY (id_cliente)
REFERENCES [NONAME].[Cliente] (id_cliente)

ALTER TABLE [NONAME].[Viaje]
CHECK CONSTRAINT [FK_Viaje_Cliente]

ALTER TABLE [NONAME].[Cliente]
WITH CHECK ADD CONSTRAINT FK_Cliente_Usuario FOREIGN KEY (id_cliente)
REFERENCES [NONAME].[Usuario] (id_usuario)

ALTER TABLE [NONAME].[Cliente]
CHECK CONSTRAINT [FK_Cliente_Usuario]

ALTER TABLE [NONAME].[Rol_Usuario]
WITH CHECK ADD CONSTRAINT FK_Rol_Usuario_Usuario FOREIGN KEY (id_usuario)
REFERENCES [NONAME].[Usuario] (id_usuario)

ALTER TABLE [NONAME].[Rol_Usuario]
CHECK CONSTRAINT [FK_Rol_Usuario_Usuario]

ALTER TABLE [NONAME].[Rol_Usuario]
WITH CHECK ADD CONSTRAINT FK_Rol_Usuario_Rol FOREIGN KEY (id_rol)
REFERENCES [NONAME].[Rol] (id_rol)

ALTER TABLE [NONAME].[Rol_Usuario]
CHECK CONSTRAINT [FK_Rol_Usuario_Rol]

ALTER TABLE [NONAME].[Funcion_Rol]
WITH CHECK ADD CONSTRAINT FK_Funcion_Rol_Rol FOREIGN KEY (id_rol)
REFERENCES [NONAME].[Rol] (id_rol)

ALTER TABLE [NONAME].[Funcion_Rol]
CHECK CONSTRAINT [FK_Funcion_Rol_Rol]

ALTER TABLE [NONAME].[Funcion_Rol]
WITH CHECK ADD CONSTRAINT FK_Funcion_Rol_Funcion FOREIGN KEY (id_funcion)
REFERENCES [NONAME].[Funcion] (id_Funcion)

ALTER TABLE [NONAME].[Funcion_Rol]
CHECK CONSTRAINT [FK_Funcion_Rol_Funcion]

--CONSTRAINT

ALTER TABLE [NONAME].[Usuario]  ADD CONSTRAINT [dni_unico] UNIQUE (usuario_dni);

ALTER TABLE [NONAME].[Usuario]  ADD CONSTRAINT [telefono_unico] UNIQUE (telefono);

ALTER TABLE [NONAME].[Auto]  ADD CONSTRAINT [patente_unico] UNIQUE (patente_auto);

--Tener en cuenta que un chofer no puede estar asignado a más de un auto activo al mismo momento.
ALTER TABLE [NONAME].[Auto_Chofer]  ADD CONSTRAINT [choferxauto_unico] UNIQUE (id_chofer);

--inserts

INSERT INTO [NONAME].Marca (nombre, id_marca)
  VALUES 
		('Fiat', 1),
		('Peugeot', 2),
		('Ford', 3),
		('Renault', 4),
		('Volkswagen', 5),
		('Chevrolet', 6)
GO

INSERT INTO [NONAME].Funcion (descripcion, id_funcion)
 VALUES 
		('Alta Rol', 1),
		('Modificacion Rol', 2),
		('Baja Rol', 3),
		('Alta Usuario', 4),
		('Modificacion Usuario', 5),
		('Baja Usuario', 6),
		('Alta Auto', 7),
		('Modificacion Auto', 8),
		('Baja Auto', 9),
		('Alta Turno', 10),
		('Modificacion Turno', 11),
		('Baja Turno', 12),
		('Registro de Viajes', 13),
		('Pago al Chofer', 14),
		('Facturacion del Cliente', 15),
		('Listado Estadistico', 16)
GO

--chequear las funcionalidades que faltan 

--Seteo IDENTITY_INSERT temporariamente en ON para que permita el ingreso de los 3 roles iniciales (id_rol es de tipo IDENTITY).
SET IDENTITY_INSERT NONAME.Rol ON;

INSERT INTO [NONAME].Rol (tipo, id_rol, habilitado)
 VALUES 
		('Administrador', 1, 1),
		('Cliente', 2, 1),
		('Chofer', 3, 1)

--Reseteo IDENTITY_INSERT de vuelta en OFF (id_rol = IDENTITY(4,1)).
SET IDENTITY_INSERT NONAME.Rol OFF;
GO

INSERT INTO [NONAME].Funcion_Rol (id_rol, id_funcion)
 VALUES 
		(1, 1),
		(1, 2),
		(1, 3),
		(1, 4),
		(1, 5),
		(1, 6),
		(1, 7),
		(1, 8),
		(1, 9),
		(1, 10),
		(1, 11),
		(1, 12),
		(1, 13),
		(1, 14)
GO

-- todavia no tienen asiganads funcionalidades los clientes y los choferes...

INSERT INTO [NONAME].Turno (hora_inicio, hora_fin, descripcion, valor_km, precio_base, id_turno, habilitado)
 VALUES 
		(0, 8, 'Turno Mañna', 0.73, 7.30, 1, 1),
		(8, 16, 'Turno Tarde', 0.73, 7.30, 2, 1),
		(16, 24, 'Turno Noche', 0.85, 8.50, 3, 1)
GO

--Administrador

INSERT INTO [NONAME].Usuario (
	usuario_dni,
	nombre,
	apellido,
	telefono,
	direccion,
	mail,
	fecha_nacimiento,
	nombre_de_usuario,
	contrasena,
	habilitado,
	intentos_fallidos)
VALUES (
	0000000000000000,
	'admin',
	'admin',
	0000000000000000,
	'N/A',
	'N/A',
	GETDATE(),
	'admin',
	HASHBYTES('SHA2_256', 'w23e'),
	1,
	0)
GO

INSERT INTO [NONAME].Rol_Usuario
SELECT Rol.id_rol, Usuario.id_usuario
FROM NONAME.Rol, NONAME.Usuario
WHERE Rol.tipo LIKE '_dmin%' AND Usuario.nombre_de_usuario = 'admin'
GO

-- Chofer

INSERT INTO [NONAME].Usuario
  SELECT DISTINCT
    [Chofer_Dni],
    [Chofer_Nombre],
    [Chofer_Apellido],
    [Chofer_Telefono],
    [Chofer_Direccion],
    [Chofer_Mail],
    [Chofer_Fecha_Nac],
    cast([Chofer_Dni] as nvarchar(50)) + '-1',
    HASHBYTES('SHA2_256', cast([Chofer_Dni] as nvarchar(50)) + '-1'),
    1,
    0
  FROM [GD1C2017].[gd_esquema].[Maestra]

GO

INSERT INTO [NONAME].Chofer
  SELECT DISTINCT
    U.id_usuario,
    'True'
  FROM NONAME.Usuario AS U
  INNER JOIN gd_esquema.maestra AS C
    ON (U.nombre = C.Chofer_Nombre)
    AND (u.apellido = C.Chofer_Apellido)

GO

-- seguin con chofer auto y chofer rendicion....


--Cliente

INSERT INTO [NONAME].Usuario
  SELECT DISTINCT

    [Cliente_Dni],
    [Cliente_Nombre],
    [Cliente_Apellido],
    [Cliente_Telefono],
    [Cliente_Direccion],
    [Cliente_Mail],
    [Cliente_Fecha_Nac],
    cast([Cliente_Dni] as nvarchar(50)) + '-1',
    HASHBYTES('SHA2_256', cast([Cliente_Dni] as nvarchar(50)) + '-1'),
    1,
    0
  FROM [GD1C2017].[gd_esquema].[Maestra]

GO


INSERT INTO [NONAME].Cliente
  SELECT DISTINCT
    U.id_usuario,
    NULL
  FROM (NONAME.Usuario AS U
  INNER JOIN gd_esquema.maestra AS C
    ON (U.nombre = C.Cliente_Nombre)
    AND (U.apellido = C.Cliente_Apellido))

GO


INSERT INTO [NONAME].Viaje 
	SELECT 
	m.Viaje_Fecha,
	m.Viaje_Fecha,
	m.Viaje_Cant_Kilometros,
	t.id_turno,
	ch.id_usuario,
	cl.id_usuario
	from [gd_esquema].[Maestra] m
	join [NONAME].Turno t ON m.Turno_Descripcion= t.descripcion
	join [NONAME].Usuario ch ON m.Chofer_Dni = ch.usuario_dni 
	join [NONAME].Usuario cl ON m.Cliente_Dni = cl.usuario_dni
	
GO

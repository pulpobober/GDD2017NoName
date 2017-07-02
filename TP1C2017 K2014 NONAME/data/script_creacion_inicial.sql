
USE [GD1C2017]
GO

	IF OBJECT_ID('NONAME.DROP_FK') IS NOT NULL
		DROP PROCEDURE NONAME.DROP_FK
	GO

	IF OBJECT_ID('NONAME.sp_migra_marca') IS NOT NULL
		DROP PROCEDURE NONAME.sp_migra_marca
	GO

	IF OBJECT_ID('NONAME.sp_migra_funcion') IS NOT NULL
		DROP PROCEDURE NONAME.sp_migra_funcion
	GO

	IF OBJECT_ID('NONAME.sp_migra_funcion_rol') IS NOT NULL
		DROP PROCEDURE NONAME.sp_migra_funcion_rol
	GO

	IF OBJECT_ID('NONAME.sp_confirmacion_facturacion') IS NOT NULL
	DROP PROCEDURE NONAME.sp_confirmacion_facturacion
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
	
	IF OBJECT_ID('NONAME.FK_Auto_Marca') IS NOT NULL
		ALTER TABLE [NONAME].[Auto] DROP CONSTRAINT [FK_Auto_Marca]
	
	IF OBJECT_ID('NONAME.FK_Factura_Viaje_Factura') IS NOT NULL
		ALTER TABLE [NONAME].[Factura_Viaje] DROP CONSTRAINT [FK_Factura_Viaje_Factura]

	IF OBJECT_ID('NONAME.FK_Factura_Viaje_Viaje') IS NOT NULL
		ALTER TABLE [NONAME].[Factura_Viaje] DROP CONSTRAINT [FK_Factura_Viaje_Viaje]
GO


-- Validacion de existencia 

IF SCHEMA_ID('NONAME') IS NOT NULL
BEGIN

--FK
	
EXEC NONAME.DROP_FK

--Tablas

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

	IF OBJECT_ID('NONAME.Factura_Viaje') IS NOT NULL
		DROP TABLE [NONAME].[Factura_Viaje]

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

	IF OBJECT_ID('NONAME.sproc_login_usuario') IS NOT NULL
		DROP PROCEDURE NONAME.sproc_login_usuario

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

	IF OBJECT_ID('NONAME.sproc_turno_alta') IS NOT NULL
		DROP PROCEDURE NONAME.sproc_turno_alta

	IF OBJECT_ID('NONAME.sproc_turno_baja') IS NOT NULL
		DROP PROCEDURE NONAME.sproc_turno_baja

	IF OBJECT_ID('NONAME.sproc_turno_modificacion') IS NOT NULL
		DROP PROCEDURE NONAME.sproc_turno_modificacion

	IF OBJECT_ID('NONAME.sproc_chofer_alta') IS NOT NULL
		DROP PROCEDURE NONAME.sproc_chofer_alta

	IF OBJECT_ID('NONAME.sproc_chofer_baja') IS NOT NULL
		DROP PROCEDURE NONAME.sproc_chofer_baja

	IF OBJECT_ID('NONAME.sproc_chofer_modificacion') IS NOT NULL
		DROP PROCEDURE NONAME.sproc_chofer_modificacion

	IF OBJECT_ID('NONAME.sp_detelle_rendicion') IS NOT NULL
		DROP PROCEDURE NONAME.sp_detelle_rendicion
	
	IF OBJECT_ID('NONAME.sp_importe_rendicion') IS NOT NULL
		DROP PROCEDURE NONAME.sp_importe_rendicion

	IF OBJECT_ID('NONAME.sproc_login_usuario') IS NOT NULL
		DROP PROCEDURE NONAME.sproc_login_usuario
	
	IF OBJECT_ID('NONAME.sp_importe_facturacion') IS NOT NULL
		DROP PROCEDURE NONAME.sp_importe_facturacion	

	IF OBJECT_ID('NONAME.sp_detalle_facturacion') IS NOT NULL
		DROP PROCEDURE NONAME.sp_detalle_facturacion	

	IF OBJECT_ID('NONAME.sp_RegistroViaje') IS NOT NULL
		DROP PROCEDURE NONAME.sp_RegistroViaje	

	IF OBJECT_ID('NONAME.sproc_top5_choferesConMayorRecaudacion') IS NOT NULL
		DROP PROCEDURE NONAME.sproc_top5_choferesConMayorRecaudacion
	
	IF OBJECT_ID('NONAME.sproc_top5_choferesConViajeMasLargoRealizado') IS NOT NULL
		DROP PROCEDURE NONAME.sproc_top5_choferesConViajeMasLargoRealizado

	IF OBJECT_ID('NONAME.sproc_top5_clientesConMayorConsumo') IS NOT NULL
		DROP PROCEDURE NONAME.sproc_top5_clientesConMayorConsumo

	IF OBJECT_ID('NONAME.sproc_top1_clienteQueUtilizoMasVecesMismoAuto') IS NOT NULL
		DROP PROCEDURE NONAME.sproc_top1_clienteQueUtilizoMasVecesMismoAuto

	IF OBJECT_ID('NONAME.sp_confirmacion_rendicion') IS NOT NULL
	DROP PROCEDURE NONAME.sp_confirmacion_rendicion

--User-Defined Functions
	
	IF OBJECT_ID('NONAME.seSuperponeConOtrosTurnos') IS NOT NULL
		DROP FUNCTION NONAME.seSuperponeConOtrosTurnos

--User-Defined Data & Table Types

	IF TYPE_ID('NONAME.ListaIDs') IS NOT NULL
		DROP TYPE NONAME.ListaIDs

	IF TYPE_ID('NONAME.ListaFuncionalidadesRol') IS NOT NULL
 		DROP TYPE NONAME.ListaFuncionalidadesRol


--Schema

	DROP SCHEMA [NONAME]

END
GO

--Creacion de Esquema 

CREATE SCHEMA [NONAME] AUTHORIZATION [gd]
GO


CREATE TABLE [NONAME].[Factura](
	[nro_factura] [numeric](18, 0) IDENTITY(10000, 1) NOT NULL,
	[id_cliente] [int] NOT NULL,
	[fecha_fin] [datetime],
	[fecha_inicio] [datetime] NOT NULL,
	[fecha] [datetime], 
	[facturada] [bit]
)
GO

CREATE TABLE [NONAME].[Factura_Viaje](
	[nro_factura] [numeric](18, 0) NOT NULL,
	[id_viaje] [int]  NOT NULL
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
	[id_cliente] [int] NOT NULL,
)
GO

CREATE TABLE [NONAME].[Rendicion_Viaje](
	[id_viaje] [int] NOT NULL,
	[nro_rendicion] [numeric](18, 0) NOT NULL,
	[porcentaje] [numeric](18, 0)
)
GO

CREATE TABLE [NONAME].[Rendicion](
	[nro_rendicion] [numeric](18, 0) IDENTITY(10000, 1) NOT NULL,
	[id_chofer] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[id_turno] [int] NOT NULL,
	[importe] [numeric](18, 2),
	[rendida] [bit]
)
GO

CREATE TABLE [NONAME].[Chofer](
	[id_chofer] [int] NOT NULL,
	[cedula] [varchar](10) NULL,
 )
 GO

CREATE TABLE [NONAME].[Auto_Chofer](
	[id_auto] [int] NOT NULL,
	[id_chofer] [int] NOT NULL,
	[id_turno] [int] NOT NULL,
)
GO

CREATE TABLE [NONAME].[Auto](
	[id_auto] [int] IDENTITY(1, 1) NOT NULL,
	[patente_auto] [varchar](10) NOT NULL,
	[modelo] [varchar](255) NOT NULL,
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
	[id_turno] [int] IDENTITY(4,1) NOT NULL,
	[hora_inicio] [numeric](18, 0) NOT NULL,
	[hora_fin] [numeric](18, 0) NOT NULL,
	[descripcion] [varchar](255) NOT NULL,
	[valor_km] [numeric](18, 2) NOT NULL,
	[precio_base] [numeric](18, 2) NOT NULL,
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

ALTER TABLE [NONAME].[Factura_Viaje]
ADD CONSTRAINT FK_Factura_Viaje_Factura FOREIGN KEY (nro_factura) 
REFERENCES [NONAME].[Factura] (nro_factura)

ALTER TABLE [NONAME].[Factura_Viaje]
CHECK CONSTRAINT [FK_Factura_Viaje_Factura]

ALTER TABLE [NONAME].[Factura_Viaje]
ADD CONSTRAINT FK_Factura_Viaje_Viaje FOREIGN KEY (id_viaje) 
REFERENCES [NONAME].[Viaje] (id_viaje)

ALTER TABLE [NONAME].[Factura_Viaje]
CHECK CONSTRAINT [FK_Factura_Viaje_Viaje]

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
GO

ALTER TABLE [NONAME].[Usuario]  ADD CONSTRAINT [telefono_unico] UNIQUE (telefono);
GO

ALTER TABLE [NONAME].[Auto]  ADD CONSTRAINT [patente_unico] UNIQUE (patente_auto);
GO

ALTER TABLE [NONAME].[Viaje]  ADD CONSTRAINT [viaje_unico] UNIQUE (cantidad_km, id_cliente, id_chofer, fecha_hora_inicio ,id_turno);
GO

-- Creacion de Store Procedures



CREATE TYPE NONAME.ListaIDs
AS TABLE (
	id INT NOT NULL PRIMARY KEY);
GO


CREATE PROCEDURE NONAME.sproc_rol_alta
	@tipo VARCHAR(255),
	@ids_funciones AS NONAME.ListaIDs READONLY,--Lista de tipo Tabla (Table-Valued Parameters) que contiene al menos un valor de id_funcion
	@habilitado BIT = 1

AS
BEGIN	
	
	DECLARE @id_rol INT;

	INSERT INTO NONAME.Rol (
		tipo,
		habilitado)
	VALUES (
		@tipo,
		@habilitado)

	SET @id_rol = SCOPE_IDENTITY() --Capturo el último id_rol auto-incrementado en Rol	

	
	INSERT INTO NONAME.Funcion_Rol
	SELECT @id_rol, id -- (id = id_funcion)
	FROM @ids_funciones

END
GO


CREATE PROCEDURE NONAME.sproc_rol_baja
	@id_rol INT

/*	
La eliminación del rol implica una baja lógica del mismo, ósea, el rol debe poder
inhabilitarse. No está permitida la asignación de un rol inhabilitado a un usuario,
por ende, se debe quitar el rol inhabilitado a todos aquellos usuarios que lo posean.
*/

AS
BEGIN

	UPDATE [NONAME].Rol
	SET habilitado = 0
	WHERE id_rol = @id_rol

--Averiguar si la quita del rol eliminado a los usuarios que lo tengan asignado debería hacerse mediante un TRIGGER...
	DELETE FROM NONAME.Rol_Usuario
	WHERE Rol_Usuario.id_rol = @id_rol

END

GO


CREATE PROCEDURE NONAME.sproc_rol_modificacion
	@id_rol INT,
	@tipo VARCHAR(255) = NULL,
	@ids_funciones AS NONAME.ListaIDs READONLY, --Lista de tipo Tabla (Table-Valued Parameters) que contiene (o no) valores de id_funcion a asignar (deshabilitar)
	@habilitado BIT = NULL

/*
En la modificación de un rol solo se pueden alterar los campos: nombre y el listado de funcionalidades.
Se deben poder quitar de a una las funcionalidades como así también agregar nuevas funcionalidades al rol
que se está modificando. Se debe poder volver a habilitar un rol inhabilitado desde la sección de modificación.
Esto no implica recuperar las asignaciones que existían en un pasado.
*/

AS
BEGIN
	
	IF(@tipo IS NOT NULL)
		BEGIN
			UPDATE NONAME.Rol
			SET tipo = @tipo
			WHERE id_rol = @id_rol
		END


	IF(@habilitado IS NOT NULL)
		BEGIN
			UPDATE NONAME.Rol
			SET habilitado = @habilitado
			WHERE id_rol = @id_rol
		END
	

/* En caso de haber algun id_funcion en la lista de funciones @ids_funciones,
actualizo la lista de funcionalidades del Rol en base a lo que me llegó por parametro.
Caso contrario (no llegan ids_funciones / vacio), le quito todos los permisos */
	IF EXISTS (SELECT 1 FROM @ids_funciones) --Me llegó al menos un id_funcion ==> AGREGO Y/O QUITO FUNCIONALIDADES
		BEGIN
			
			DECLARE @id_funcion INT;
	
			--Asigno al Rol aquellas nuevas funcionalidades que no tenía asignadas previamente
			INSERT INTO NONAME.Funcion_Rol
			SELECT @id_rol, id -- (id = id_funcion)
			FROM @ids_funciones
			WHERE id NOT IN (SELECT id_funcion FROM NONAME.Funcion_Rol WHERE id_rol = @id_rol)
			
			--Quito aquellas funcionalidades viejas que ya no le corresponden al Rol
			DELETE FROM NONAME.Funcion_Rol
			WHERE Funcion_Rol.id_rol = @id_rol AND (Funcion_Rol.id_funcion NOT IN (SELECT * FROM @ids_funciones))

		END
	ELSE --tabla de ids_funciones vacia --> le quito todos los permisos que tenia
		BEGIN
			DELETE FROM NONAME.Funcion_Rol
			WHERE Funcion_Rol.id_rol = @id_rol
		END
END
GO


CREATE PROCEDURE NONAME.sproc_cliente_alta
	@nombre VARCHAR(255),
	@apellido VARCHAR(255),
	@usuario_dni NUMERIC(18,0),
	@mail VARCHAR(50),
	@telefono NUMERIC(18, 0),
	@direccion VARCHAR(255),
	@codigo_postal VARCHAR(50),
	@fecha_nacimiento DATETIME,
	@habilitado BIT = 1

AS
BEGIN

	DECLARE @id_rol INT
	DECLARE @id_usuario INT

	SET @id_rol = (SELECT id_rol FROM NONAME.Rol WHERE UPPER(tipo) = 'CLIENTE')

	INSERT INTO NONAME.Usuario (
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
		@usuario_dni,
		@nombre,
		@apellido,
		@telefono,
		@direccion,
		@mail,
		@fecha_nacimiento,
		@usuario_dni,
		HASHBYTES('SHA2_256', CAST(@usuario_dni as NVARCHAR(255))),
		@habilitado,
		0)

	
	SET @id_usuario = SCOPE_IDENTITY() --Capturo el último id_usuario auto-incrementado en Usuario

	INSERT INTO [NONAME].Cliente (
		id_cliente,
		codigo_postal)
	VALUES (
		@id_usuario,
		@codigo_postal)


	IF EXISTS (SELECT 1 FROM NONAME.Rol WHERE id_rol = @id_rol AND habilitado = 1) --No está permitida la asignación de un rol inhabilitado a un usuario
		BEGIN
			INSERT INTO [NONAME].Rol_Usuario (
				id_rol,
				id_usuario)
			VALUES (
				@id_rol,
				@id_usuario) -- @id_usuario = último id_usuario auto-incrementado
		END
END

GO


CREATE PROCEDURE NONAME.sproc_cliente_baja
	@id_usuario INT -- (id_usuario = id_cliente)

/*	
	La eliminación de un cliente implica la baja lógica del mismo. Un cliente
	inhabilitado no podrá ser asignado a un viaje, como así mismo realizársele una
	facturación de viajes mensual luego que fue dado de baja. Se debe poder volver a
	habilitar el cliente deshabilitado desde la sección de modificación.
*/

AS
BEGIN

	UPDATE [NONAME].Usuario
	SET habilitado = 0
	WHERE id_usuario = @id_usuario

END

GO


CREATE PROCEDURE NONAME.sproc_cliente_modificacion
	@id_usuario INT,
	@usuario_dni NUMERIC(18,0),
	@nombre VARCHAR(255),
	@apellido VARCHAR(255),
	@telefono NUMERIC(18, 0),
	@direccion VARCHAR(255),
	@mail VARCHAR(50),
	@fecha_nacimiento DATETIME,
	@codigo_postal VARCHAR(50),
	@habilitado BIT = NULL

/*
Todos los datos mencionados anteriormente son modificables, en cuanto a la
obligatoriedad de los mismos, es para todos a excepción del mail. El teléfono es un dato
único, por ende no pueden existir 2 usuarios con el mismo teléfono. El sistema deberá
controlar esta restricción e informar debidamente al usuario ante alguna anomalía.
Se debe poder volver a habilitar el cliente deshabilitado desde la sección de modificación.
*/

AS
BEGIN
	
	UPDATE [NONAME].Usuario
	SET
		nombre = @nombre,
		apellido = @apellido,
		usuario_dni = @usuario_dni,
		mail = @mail,
		telefono = @telefono,
		direccion = @direccion,
		fecha_nacimiento = @fecha_nacimiento
	WHERE id_usuario = @id_usuario

	UPDATE NONAME.Cliente
	SET codigo_postal = @codigo_postal
	WHERE id_cliente = @id_usuario

	IF(@habilitado IS NOT NULL)
		BEGIN
			UPDATE [NONAME].Usuario
			SET habilitado = @habilitado
			WHERE id_usuario = @id_usuario
		END

END

GO

CREATE PROCEDURE NONAME.sproc_automovil_alta
	@id_marca INT,
	@modelo VARCHAR(255),
	@patente_auto VARCHAR(10),
	@ids_turnos AS NONAME.ListaIDs READONLY, --Lista de tipo Tabla (Table-Valued Parameters) que contiene al menos un valor de id_turno
	@id_chofer INT,
	@rodado VARCHAR(10) = NULL,
	@licencia VARCHAR(26) = NULL,
	@habilitado BIT = 1

AS
BEGIN

	DECLARE @id_auto INT

	INSERT INTO NONAME.Auto (
		patente_auto,
		modelo,
		id_marca,
		rodado,
		habilitado,
		licencia)
	VALUES (
		@patente_auto,
		@modelo,
		@id_marca,
		@rodado,
		@habilitado,
		@licencia)

	SET @id_auto = SCOPE_IDENTITY() --Capturo el último id_auto auto-incrementado en Auto

	IF NOT EXISTS (SELECT 1 FROM NONAME.Auto_Chofer WHERE id_auto = @id_auto AND id_chofer = @id_chofer)
		BEGIN
			INSERT INTO [NONAME].Auto_Chofer
			--SELECT Auto.id_auto, Chofer.id_chofer, Turno.id_turno
			SELECT @id_auto, @id_chofer, id -- (id = id_turno)
			FROM @ids_turnos
			--WHERE Auto.id_auto = @id_auto AND Chofer.id_chofer = @id_chofer AND Turno.id_turno = @id_turno
		END

END

GO

CREATE PROCEDURE NONAME.sproc_automovil_baja
	@id_auto INT

/*	
Cuando se trate de una baja, la misma será lógica. Para un automóvil inactivo sus
datos seguirán existiendo en la base de datos, por ende, dicho automóvil no podrá ser
utilizado para registrar viajes a su nombre. Se debe poder volver a habilitar el
automóvil inhabilitado desde la sección de modificación.
*/

AS
BEGIN

	UPDATE [NONAME].Auto
	SET habilitado = 0
	WHERE id_auto = @id_auto

END

GO

CREATE PROCEDURE NONAME.sproc_automovil_modificacion
	@id_auto INT,
	@patente_auto VARCHAR(10),
	@modelo VARCHAR(255),
	@ids_turnos AS NONAME.ListaIDs READONLY, --Lista de tipo Tabla (Table-Valued Parameters) que contiene (o no) valores de id_turno a asignar (deshabilitar)
	@id_marca INT,
	@id_chofer INT,
	@rodado VARCHAR(10) = NULL,
	@licencia VARCHAR(26) = NULL,
	@habilitado BIT = NULL

/*
En la modificación de un automóvil se pueden alterar todos sus datos, tener en
cuenta que un chofer no puede estar asignado a más de un auto activo al mismo
momento. Se debe poder volver a habilitar el automóvil inhabilitado desde la
sección de modificación.
*/

AS
BEGIN
	
	UPDATE NONAME.Auto
	SET	patente_auto = @patente_auto,
		modelo = @modelo,
		id_marca = @id_marca
	WHERE id_auto = @id_auto

	
	UPDATE NONAME.Auto_Chofer
	SET id_chofer = @id_chofer
	WHERE id_auto = @id_auto


/* En caso de haber algun id_turno en la lista de turnos @ids_turnos,
actualizo la lista de turnos de Auto_Chofer en base a lo que me llegó por parametro.
Caso contrario (no llegan ids_turnos / me llega vacio), le quito todos los turnos */
	IF EXISTS (SELECT 1 FROM @ids_turnos) --Me llegó al menos un id_turno ==> AGREGO Y/O QUITO TURNOS
		BEGIN
			
			DECLARE @id_turno INT;
	
			--Asigno a Auto_Chofer aquellos nuevos turnos que no tenía asignados previamente
			INSERT INTO NONAME.Auto_Chofer
			SELECT @id_auto, @id_chofer, id -- (id = id_funcion)
			FROM @ids_turnos
			WHERE id NOT IN (SELECT id_turno FROM NONAME.Auto_Chofer WHERE (id_auto = @id_auto) AND (id_chofer = @id_chofer))
			
			--Quito aquellos turnos viejos que ya no le corresponden a Auto_Chofer
			DELETE FROM NONAME.Auto_Chofer
			WHERE (id_auto = @id_auto) AND (id_chofer = @id_chofer) AND (id_turno NOT IN (SELECT * FROM @ids_turnos))

		END
	ELSE --tabla de ids_turnos vacia --> le quito todos los turnos que tenia
		BEGIN
			DELETE FROM NONAME.Auto_Chofer
			WHERE (id_auto = @id_auto) AND (id_chofer = @id_chofer)
		END


	IF(@habilitado IS NOT NULL)
		BEGIN
			UPDATE NONAME.Auto
			SET habilitado = @habilitado
			WHERE id_auto = @id_auto
		END

	
	IF(@rodado IS NOT NULL)
		BEGIN
			UPDATE NONAME.Auto
			SET rodado = @rodado
			WHERE id_auto = @id_auto
		END

	
	IF(@licencia IS NOT NULL)
		BEGIN
			UPDATE NONAME.Auto
			SET licencia = @licencia
			WHERE id_auto = @id_auto
		END
		
END

GO


CREATE FUNCTION NONAME.seSuperponeConOtrosTurnos (
	@id_turno INT,
	@hora_inicio NUMERIC(18,0),
	@hora_fin NUMERIC(18,0))

RETURNS BIT

AS

BEGIN
	
	DECLARE @valorDeRetorno BIT

	IF NOT EXISTS (SELECT 1 FROM NONAME.Turno WHERE (
					(@hora_inicio < Turno.hora_fin AND @hora_fin > Turno.hora_fin) OR
					(@hora_inicio < Turno.hora_inicio AND @hora_fin > Turno.hora_inicio) OR
					(@hora_inicio > Turno.hora_inicio AND @hora_fin < Turno.hora_fin) OR
					(@hora_inicio < Turno.hora_inicio AND @hora_fin > Turno.hora_fin))
					AND (Turno.id_turno <> @id_turno)
					AND (Turno.habilitado = 1))
		BEGIN
			SET @valorDeRetorno = 0
		END
	ELSE
		BEGIN
			SET @valorDeRetorno = 1
		END

	RETURN @valorDeRetorno
END
GO


CREATE PROCEDURE NONAME.sproc_turno_alta
	@hora_inicio NUMERIC(18, 0),
	@hora_fin NUMERIC(18, 0),
	@descripcion VARCHAR(255),
	@valor_km NUMERIC(18,2),
	@precio_base NUMERIC(18,2),
	@habilitado BIT

AS
BEGIN

	IF((@hora_inicio < @hora_fin) AND --el turno comienza y finaliza dentro del mismo dia y no excede las 24hs
		NOT EXISTS (SELECT 1 FROM NONAME.Turno WHERE (  --los turnos no se superponen
					(@hora_inicio < Turno.hora_fin AND @hora_fin > Turno.hora_fin) OR
					(@hora_inicio < Turno.hora_inicio AND @hora_fin > Turno.hora_inicio) OR
					(@hora_inicio > Turno.hora_inicio AND @hora_fin < Turno.hora_fin) OR
					(@hora_inicio < Turno.hora_inicio AND @hora_fin > Turno.hora_fin))
					AND (Turno.habilitado = 1)))
		BEGIN
			INSERT INTO NONAME.Turno (
				hora_inicio,
				hora_fin,
				descripcion,
				valor_km,
				precio_base,
				habilitado)
			VALUES (
				@hora_inicio,
				@hora_fin,
				@descripcion,
				@valor_km,
				@precio_base,
				@habilitado)
		END

END
GO

CREATE PROCEDURE NONAME.sproc_turno_baja
	@id_turno INT

/*	
	La eliminación de un turno implica su baja lógica. Cuando un turno se inhabilita
	sus datos siguen existiendo en la base de datos, pero no se pueden realizar viajes en
	mencionado turno.
*/

AS
BEGIN

	UPDATE [NONAME].Turno
	SET habilitado = 0
	WHERE id_turno = @id_turno

END
GO


CREATE PROCEDURE NONAME.sproc_turno_modificacion
	@id_turno INT,
	@hora_inicio NUMERIC(18, 0) = NULL,
	@hora_fin NUMERIC(18, 0) = NULL,
	@descripcion VARCHAR(255) = NULL,
	@valor_km NUMERIC(18,2) = NULL,
	@precio_base NUMERIC(18,2) = NULL,
	@habilitado BIT = NULL

/*
Se debe poder volver a habilitar un turno inhabilitado desde la sección de 
modificación y el mismo debe cumplir con las mismas restricciones:
Bajo ninguna circunstancia las franjas horarias pueden superponerse entre sí.
Un turno no debe exceder las 24hs y además debe comenzar y finalizar dentro del mismo día.
*/

AS
BEGIN

	DECLARE @horarioCorrecto INT
	SET @horarioCorrecto = 0

--se precisa modificar tanto hora_inicio como hora_fin	
	IF((@hora_inicio IS NOT NULL) AND (@hora_fin IS NOT NULL))
		BEGIN

			IF((@hora_inicio < @hora_fin) AND --el turno comienza y finaliza dentro del mismo dia y no excede las 24hs
				NONAME.seSuperponeConOtrosTurnos(@id_turno, @hora_inicio, @hora_fin) <> 1) --los turnos no se superponen
				BEGIN
					UPDATE [NONAME].Turno
					SET hora_inicio = @hora_inicio,
						hora_fin = @hora_fin
					WHERE id_turno = @id_turno

					SET @horarioCorrecto = 1
				END
		END
	
--se precisa modificar hora_inicio unicamente
	IF((@hora_inicio IS NOT NULL) AND (@hora_fin IS NULL))
		BEGIN
			DECLARE @hora_fin_orig NUMERIC(18,0)
			SET @hora_fin_orig = (SELECT Turno.hora_fin FROM NONAME.Turno WHERE id_turno = @id_turno)
			
			IF((@hora_inicio < @hora_fin_orig) AND --el turno comienza y finaliza dentro del mismo dia y no excede las 24hs
				NONAME.seSuperponeConOtrosTurnos(@id_turno, @hora_inicio, @hora_fin_orig) <> 1) --los turnos no se superponen
				BEGIN
					UPDATE [NONAME].Turno
					SET hora_inicio = @hora_inicio
					WHERE id_turno = @id_turno

					SET @horarioCorrecto = 1
				END
		END

--se precisa modificar hora_fin unicamente
	IF((@hora_inicio IS NULL) AND (@hora_fin IS NOT NULL))
		BEGIN
			DECLARE @hora_inicio_orig NUMERIC(18,0)
			SET @hora_inicio_orig = (SELECT Turno.hora_inicio FROM NONAME.Turno WHERE id_turno = @id_turno)
			
			IF((@hora_inicio_orig < @hora_fin) AND --el turno comienza y finaliza dentro del mismo dia y no excede las 24hs
				NONAME.seSuperponeConOtrosTurnos(@id_turno, @hora_inicio_orig, @hora_fin) <> 1) --los turnos no se superponen
				BEGIN
					UPDATE [NONAME].Turno
					SET hora_fin = @hora_fin
					WHERE id_turno = @id_turno

					SET @horarioCorrecto = 1
				END
		END
	
	
	IF(@descripcion IS NOT NULL)
		BEGIN
			UPDATE [NONAME].Turno
			SET descripcion = @descripcion
			WHERE id_turno = @id_turno
		END


	IF(@valor_km IS NOT NULL)
		BEGIN
			UPDATE [NONAME].Turno
			SET valor_km = @valor_km
			WHERE id_turno = @id_turno
		END


	IF(@precio_base IS NOT NULL)
		BEGIN
			UPDATE [NONAME].Turno
			SET precio_base = @precio_base
			WHERE id_turno = @id_turno
		END


	IF(@habilitado = 0)
		BEGIN
			UPDATE [NONAME].Turno
			SET habilitado = @habilitado
			WHERE id_turno = @id_turno
		END

--Valida si cumple las restricciones antes de volver a habilitarlo
	IF(@habilitado = 1)
		BEGIN
			DECLARE @hora_inicio_ NUMERIC(18,0)
			DECLARE @hora_fin_ NUMERIC(18,0)

			SET @hora_inicio_ = (SELECT Turno.hora_inicio FROM NONAME.Turno WHERE id_turno = @id_turno)
			SET @hora_fin_ = (SELECT Turno.hora_fin FROM NONAME.Turno WHERE id_turno = @id_turno)
			
			IF((@hora_inicio_ < @hora_fin_) AND --el turno comienza y finaliza dentro del mismo dia y no excede las 24hs
				NONAME.seSuperponeConOtrosTurnos(@id_turno, @hora_inicio_, @hora_fin_) <> 1) --los turnos no se superponen
				BEGIN
					UPDATE [NONAME].Turno
					SET habilitado = @habilitado
					WHERE id_turno = @id_turno

					--SET @horarioCorrecto = 1
				END
		END

	SELECT @horarioCorrecto
	RETURN @horarioCorrecto
END
GO


CREATE PROCEDURE NONAME.sproc_chofer_alta
	@nombre VARCHAR(255),
	@apellido VARCHAR(255),
	@usuario_dni NUMERIC(18,0),
	@direccion VARCHAR(255),
	@telefono NUMERIC(18, 0),
	@mail VARCHAR(50),
	@fecha_nacimiento DATETIME,
	@habilitado BIT = 1

AS
BEGIN

	DECLARE @id_rol INT
	DECLARE @id_usuario INT

	SET @id_rol = (SELECT id_rol FROM NONAME.Rol WHERE UPPER(tipo) = 'CHOFER')

	INSERT INTO NONAME.Usuario (
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
		@usuario_dni,
		@nombre,
		@apellido,
		@telefono,
		@direccion,
		@mail,
		@fecha_nacimiento,
		@usuario_dni,
		HASHBYTES('SHA2_256', CAST(@usuario_dni as NVARCHAR(10))),
		@habilitado,
		0)

	
	SET @id_usuario = SCOPE_IDENTITY() --Capturo el último id_usuario auto-incrementado en Usuario

	INSERT INTO [NONAME].Chofer (
		id_chofer,
		cedula)
	VALUES (
		@id_usuario,
		NULL)


	IF EXISTS (SELECT 1 FROM NONAME.Rol WHERE id_rol = @id_rol AND habilitado = 1) --No está permitida la asignación de un rol inhabilitado a un usuario
		BEGIN
			INSERT INTO [NONAME].Rol_Usuario (
				id_rol,
				id_usuario)
			VALUES (
				@id_rol,
				@id_usuario) -- @id_usuario = último id_usuario auto-incrementado
		END
END

GO


CREATE PROCEDURE NONAME.sproc_chofer_baja
	@id_usuario INT -- (id_usuario = id_chofer)

/*	
	En el caso de tratarse de una baja, la misma deberá ser lógica. Cuando un chofer se inhabilita, 
	sus datos siguen existiendo en la base de datos, pero luego no pueden realizarse viajes bajo ese 
	chofer deshabilitado. Se debe poder volver a habilitar un chofer dado de baja desde la sección de 
	modificación y el mismo debe cumplir con las restricciones descriptas.
*/

AS
BEGIN

	UPDATE [NONAME].Usuario
	SET habilitado = 0
	WHERE id_usuario = @id_usuario

END

GO


CREATE PROCEDURE NONAME.sproc_chofer_modificacion
	@id_usuario INT, -- (id_usuario = id_chofer)
	@usuario_dni NUMERIC(18,0),
	@nombre VARCHAR(255),
	@apellido VARCHAR(255),
	@telefono NUMERIC(18, 0),
	@direccion VARCHAR(255),
	@mail VARCHAR(50),
	@fecha_nacimiento DATETIME,
	@habilitado BIT = NULL
--	,@cedula VARCHAR(10) = NULL

/*
Dichos datos pueden ser modificados en su totalidad y en el caso de tratarse de
una baja, la misma deberá ser lógica. Cuando un chofer se inhabilita, sus datos siguen
existiendo en la base de datos, pero luego no pueden realizarse viajes bajo ese chofer
deshabilitado. Se debe poder volver a habilitar un chofer dado de baja desde la sección
de modificación y el mismo debe cumplir con las restricciones descriptas.
*/

AS
BEGIN
	
	UPDATE [NONAME].Usuario
	SET	nombre = @nombre,
		apellido = @apellido,
		usuario_dni = @usuario_dni,
		mail = @mail,
		telefono = @telefono,
		direccion = @direccion,
		fecha_nacimiento = @fecha_nacimiento
	WHERE id_usuario = @id_usuario

/*	
	UPDATE NONAME.Chofer
	SET cedula = @cedula
	WHERE id_chofer = @id_usuario
*/

	IF(@habilitado IS NOT NULL)
		BEGIN
			UPDATE [NONAME].Usuario
			SET habilitado = @habilitado
			WHERE id_usuario = @id_usuario
		END

END

GO

-- quedo detelle 

CREATE PROCEDURE NONAME.sproc_login_usuario
	@nombre_de_usuario nvarchar(50),
	@contrasena varchar(50)

AS
BEGIN

  IF EXISTS (SELECT
      1
    FROM NONAME.Usuario
    WHERE nombre_de_usuario = @nombre_de_usuario
    AND [contrasena] = CAST(HASHBYTES('SHA2_256', CAST(@contrasena AS NVARCHAR(255))) AS NVARCHAR(255))
    AND habilitado = 1)
  BEGIN
    SELECT
      'Ingreso OK' resultado,
      id_usuario
    FROM NONAME.Usuario
    WHERE nombre_de_usuario = @nombre_de_usuario
  END
  ELSE
  BEGIN
    IF EXISTS (SELECT
        nombre_de_usuario,
        nombre_de_usuario
      FROM NONAME.Usuario
      WHERE nombre_de_usuario = @nombre_de_usuario)
    BEGIN
      IF ((SELECT
          intentos_fallidos
        FROM NONAME.Usuario
        WHERE nombre_de_usuario = @nombre_de_usuario)
        < 3)
      BEGIN
        UPDATE NONAME.Usuario
        SET intentos_fallidos = intentos_fallidos + 1
        WHERE nombre_de_usuario = @nombre_de_usuario

        SELECT
          'usuario o password invalido' resultado,
          0
      END
      ELSE
      BEGIN
        UPDATE NONAME.Usuario
        SET habilitado = 0
        WHERE nombre_de_usuario = @nombre_de_usuario

        SELECT
          'el usuario se encuentra bloqueado',
          -1
      END
    END
    ELSE
    BEGIN
      SELECT
        'usuario o password invalido' resultado,
        0
    END
  END
END

GO

-- quedo detelle
CREATE PROCEDURE NONAME.sp_detelle_rendicion
	@id_usuario int, -- (id_usuario = id_chofer)
	@id_turno int,
	@fecha datetime
AS
BEGIN
	SELECT DISTINCT renvi.id_viaje, v.cantidad_km, v.fecha_hora_inicio, r.rendida
	FROM [NONAME].Rendicion_Viaje renvi
	JOIN [NONAME].Viaje v ON renvi.id_viaje = v.id_viaje
	JOIN [NONAME].Rendicion r ON renvi.nro_rendicion = r.nro_rendicion
	where v.id_chofer = @id_usuario
	and v.fecha_hora_inicio >= @fecha
	and r.id_turno = @id_turno
END
GO


CREATE PROCEDURE NONAME.sp_importe_rendicion
	@id_usuario int, -- (id_usuario = id_chofer)
	@id_turno int,
	@fecha datetime
AS
BEGIN
	 DECLARE @valorTurno numeric(18,2) = (SELECT valor_km from NONAME.Turno where id_turno = @id_turno)
	SELECT sum((v.cantidad_km * @valorTurno)) as importe, r.nro_rendicion
	FROM [NONAME].Rendicion r
	join [NONAME].Rendicion_Viaje rv ON r.nro_rendicion = rv.nro_rendicion
	join [NONAME].Viaje v ON rv.id_viaje = v.id_viaje
	where r.id_chofer = @id_usuario
	and r.id_turno = @id_turno
	and r.fecha >= @fecha
	AND rendida = 0
	group by r.nro_rendicion
END
GO

CREATE PROCEDURE NONAME.sp_confirmacion_rendicion
	@nro_rendicion NUMERIC(18,0),
	@id_usuario int, -- (id_usuario = id_chofer)
	@id_turno int,
	@fecha datetime

AS
BEGIN
	DECLARE @valorTurno numeric(18,2) = (SELECT valor_km from NONAME.Turno where id_turno = @id_turno)
	DECLARE @importe numeric(18, 2) = (SELECT sum((v.cantidad_km * @valorTurno))
					FROM [NONAME].Rendicion r
					join [NONAME].Rendicion_Viaje rv ON r.nro_rendicion = rv.nro_rendicion
					join [NONAME].Viaje v ON rv.id_viaje = v.id_viaje
					where r.id_chofer = @id_usuario
					and r.id_turno = @id_turno
					and r.fecha >= @fecha
					and r.nro_rendicion = @nro_rendicion
					group by r.nro_rendicion)

	UPDATE [NONAME].Rendicion
	SET rendida = 1, 
	importe = @importe
	WHERE nro_rendicion = @nro_rendicion

	DECLARE @valorKM numeric (18,2) = (select valor_km from NONAME.Turno where id_turno = @id_turno)
	DECLARE @precioBase numeric (18,2) =  (select precio_base from NONAME.Turno where id_turno = @id_turno)
	DECLARE @viajeKM numeric(18, 0) = (select sum(v.cantidad_km) FROM [NONAME].Rendicion r
																 join [NONAME].Rendicion_Viaje rv ON r.nro_rendicion = rv.nro_rendicion
																 join [NONAME].Viaje v ON rv.id_viaje = v.id_viaje
																 and r.nro_rendicion = @nro_rendicion)

	UPDATE [NONAME].Rendicion_Viaje
	set porcentaje = (100*@importe/(@viajeKM * @valorKM + @precioBase)) where nro_rendicion = @nro_rendicion

END
GO

CREATE PROCEDURE NONAME.sp_detalle_facturacion
	@id_usuario int, -- (id_usuario = id_cliente)
	@fecha datetime
AS
BEGIN
	SELECT fv.id_viaje, v.cantidad_km, v.fecha_hora_inicio
	FROM Factura_Viaje fv
	JOIN Viaje v ON fv.id_viaje = v.id_viaje
	JOIN Factura f ON fv.nro_factura = f.nro_factura
	WHERE f.fecha_inicio <= @fecha and (f.fecha_fin >= @fecha or f.fecha_fin is null)
	and f.id_cliente = @id_usuario
	
END
GO


CREATE PROCEDURE NONAME.sp_importe_facturacion
	@id_usuario int, -- (id_usuario = id_cliente)
	@fecha datetime
AS
	DECLARE @nro_factura numeric(18, 0)
BEGIN
	set @nro_factura = (select nro_factura 
						from Factura where id_cliente = @id_usuario
						and fecha_fin is null)
END
BEGIN 
	SELECT sum(v.cantidad_km * t.valor_km) as  'Monto total', @nro_factura
	FROM Viaje v
	join Factura_Viaje fv ON v.id_viaje = fv.id_viaje
	join Turno t ON v.id_turno = t.id_turno 
	where fv.nro_factura = @nro_factura
END
GO


/*Para confirmar la facturacion se creo el sp_confirmacion_facturacion que recibe el nro_factura (el cual te doy 
en una columna con el sp_importe_facturacion) y tambien recibe la fecha del momento en el cual se confirmola facturacion,
para poder settear la fecha fin de la factura*/


CREATE PROCEDURE NONAME.sp_confirmacion_facturacion
	@fecha datetime,
	@nro_factura numeric(18, 0)
AS
BEGIN
	-- la fecha corresponde a l a creacion de la factura y esta coincide con fecha fin
	UPDATE NONAME.Factura 
	SET fecha_fin = @fecha , fecha = @fecha
	WHERE nro_factura = @nro_factura
	and fecha_fin is null and fecha is null

	UPDATE [NONAME].Factura
	SET facturada = 1
	WHERE nro_factura = @nro_factura
END
GO

CREATE PROCEDURE NONAME.sp_RegistroViaje
	@id_chofer int,
	@id_auto int,
	@id_turno int,
	@cant_km numeric(18,0),
	@fecha_inicio datetime,
	@fecha_fin datetime,
	@id_cliente int
AS
BEGIN
	DECLARE @id_viaje int

	INSERT INTO NONAME.Viaje (
		fecha_hora_inicio,
		fecha_hora_fin,
		cantidad_km,
		id_turno,
		id_chofer,
		id_cliente)
	VALUES (
		@fecha_inicio,
		@fecha_fin,
		@cant_km,
		@id_turno,
		@id_chofer,
		@id_cliente)

SET @id_viaje = SCOPE_IDENTITY()

 -- Si el id de una factura para ese mes ya esta creada la fecha de finalizacion se encuentra en null 
 -- hasta que a fin de mes la factura sea creada
 -- el administrad updetea la fecha fin de factura el dia que la crea
	IF NOT EXISTS (SELECT 1 FROM NONAME.Factura re WHERE re.fecha_fin is null and re.id_cliente = @id_cliente)
			BEGIN
					DECLARE @nro_factura INT
					
					INSERT INTO [NONAME].Factura 
					VALUES (
						@id_cliente,
						NULL,
						@fecha_inicio,
						NULL,
						0
					)

					SET @nro_factura = SCOPE_IDENTITY()

					INSERT INTO [NONAME].Factura_Viaje
					SELECT f.nro_factura, v.id_viaje
					FROM NONAME.Factura f, NONAME.Viaje v 
					WHERE f.nro_factura = @nro_factura and v.id_viaje = @id_viaje
				END
			ELSE
				BEGIN
					INSERT INTO [NONAME].Factura_Viaje
					SELECT f.nro_factura, v.id_viaje
					FROM NONAME.Factura f, NONAME.Viaje v 
					WHERE f.fecha_fin is null  and f.id_cliente = @id_cliente and v.id_viaje = @id_viaje	
				END


	IF NOT EXISTS (SELECT 1 FROM NONAME.Rendicion re WHERE re.fecha = @fecha_inicio and re.id_chofer = @id_chofer and re.id_turno = @id_turno)
			BEGIN

					DECLARE @nro_rendicion INT
					
					INSERT INTO [NONAME].Rendicion 
					VALUES (
						@id_chofer,
						@fecha_inicio,
						@id_turno,
						null,
						0)
						

						SET @nro_rendicion = SCOPE_IDENTITY()

					INSERT INTO [NONAME].Rendicion_Viaje 
					SELECT v.id_viaje, r.nro_rendicion, (100*r.importe/(v.cantidad_km * t.valor_km + t.precio_base))
					FROM NONAME.Rendicion r, NONAME.Viaje v, NONAME.Turno t
					WHERE v.id_viaje = @id_viaje and t.id_turno = @id_turno and r.nro_rendicion = @nro_rendicion
				END
			ELSE
				BEGIN
					INSERT INTO [NONAME].Rendicion_Viaje 
					SELECT v.id_viaje, r.nro_rendicion, null
					FROM NONAME.Rendicion r, NONAME.Viaje v, NONAME.Turno t
					WHERE v.id_viaje = @id_viaje and t.id_turno = @id_turno and r.id_chofer = @id_chofer 
					and r.fecha = @fecha_inicio and r.id_turno = @id_turno
				END
END
GO

-- Listado estadistico

CREATE PROCEDURE NONAME.sproc_top5_choferesConMayorRecaudacion
	@anio INT,
	@trimestre INT

AS
BEGIN

	SELECT TOP 5 (U.apellido + ', ' + U.nombre) AS Chofer, U.nombre_de_usuario AS 'Nombre De Usuario', sum(R.importe) AS 'Importe Total Recaudado ($)'
	FROM NONAME.Usuario AS U JOIN NONAME.Rendicion AS R ON U.id_usuario = R.id_chofer
	WHERE YEAR(R.fecha) = @anio AND DATEPART(QUARTER, R.fecha) = @trimestre
	GROUP BY u.id_usuario,(U.apellido + ', ' + U.nombre),U.nombre_de_usuario
	ORDER BY sum(R.importe) DESC

END
GO


CREATE PROCEDURE NONAME.sproc_top5_choferesConViajeMasLargoRealizado
	@anio INT,
	@trimestre INT

AS
BEGIN


	SELECT top 5 (U.apellido + ', ' + U.nombre) AS Chofer, V.id_viaje AS 'Nro. De Viaje', V.fecha_hora_inicio AS Fecha, V.cantidad_km AS 'Cantidad De Kms'
	FROM NONAME.Usuario AS U JOIN NONAME.Viaje AS V ON U.id_usuario = V.id_chofer
	WHERE YEAR(V.fecha_hora_inicio) = @anio AND DATEPART(QUARTER, V.fecha_hora_inicio) = @trimestre
	
	ORDER BY V.cantidad_km DESC

END
GO

-- arreglar esta estadistica, esta mal calculada la parte del monto maximo
CREATE PROCEDURE NONAME.sproc_top5_clientesConMayorConsumo
	@anio INT,
	@trimestre INT
	

AS
begin
 	SELECT  top 5 (C.apellido + ', ' + C.nombre) AS Cliente, F.nro_factura, (SELECT sum(v.cantidad_km * t.valor_km) 
																FROM NONAME.Factura ff
																join noname.Factura_Viaje fv ON fv.nro_factura = ff.nro_factura
																join noname.Viaje v ON fv.id_viaje = v.id_viaje
																join NONAME.Turno t on t.id_turno = v.id_turno
																where ff.nro_factura = F.nro_factura 

																
																) as Consumo
																
	FROM NONAME.Usuario as C join NONAME.Factura F on C.id_usuario = F.id_cliente
	where YEAR(F.fecha) = @anio AND DATEPART(QUARTER, f.fecha) = @trimestre
	order by Consumo Desc
	

end 

GO


CREATE PROCEDURE NONAME.sproc_top1_clienteQueUtilizoMasVecesMismoAuto
	@anio INT,
	@trimestre INT

AS

BEGIN

	SELECT TOP 5 (U.apellido + ', ' + U.nombre) AS 'Cliente', COUNT(patente_auto) AS 'Cantidad de Viajes', patente_auto AS 'Patente Auto', M.nombre AS 'Marca Auto', A.modelo AS 'Modelo Auto'
	FROM NONAME.Usuario U JOIN NONAME.Viaje V ON U.id_usuario = v.id_cliente
		JOIN NONAME.Auto_Chofer AC ON AC.id_chofer = v.id_chofer AND AC.id_turno = v.id_turno
		JOIN NONAME.Auto A ON A.id_auto = AC.id_auto 
		JOIN NONAME.Marca AS M ON M.id_marca = A.id_marca
	WHERE YEAR(v.fecha_hora_inicio) = @anio AND DATEPART(QUARTER, v.fecha_hora_inicio) = @trimestre
	GROUP BY (U.apellido + ', ' + U.nombre), patente_auto, M.nombre, A.modelo
	ORDER BY COUNT(patente_auto) DESC

END
GO


-- Datos iniciales

CREATE PROCEDURE NONAME.sp_migra_marca (@nombre_auto varchar(255), @id_marca int) 
AS
	INSERT INTO NONAME.Marca (nombre, id_marca)
	VALUES (@nombre_auto, @id_marca)
GO

EXEC NONAME.sp_migra_marca @nombre_auto = 'Fiat', @id_marca = 1;
EXEC NONAME.sp_migra_marca @nombre_auto = 'Peugeot', @id_marca = 2;
EXEC NONAME.sp_migra_marca @nombre_auto = 'Ford', @id_marca = 3;
EXEC NONAME.sp_migra_marca @nombre_auto = 'Renault', @id_marca = 4;
EXEC NONAME.sp_migra_marca @nombre_auto = 'Volkswagen', @id_marca = 5;
EXEC NONAME.sp_migra_marca @nombre_auto = 'Chevrolet', @id_marca = 6;
GO

CREATE PROCEDURE [NONAME].sp_migra_funcion (@id_funcion int, @descripcion varchar(255)) 
AS
	INSERT INTO [NONAME].Funcion
	VALUES (@id_funcion, @descripcion)
GO

EXEC [NONAME].sp_migra_funcion @id_funcion = 1, @descripcion = 'Alta Rol';
EXEC [NONAME].sp_migra_funcion @id_funcion = 2, @descripcion = 'Modificacion Rol';
EXEC [NONAME].sp_migra_funcion @id_funcion = 3, @descripcion = 'Baja Rol';
EXEC [NONAME].sp_migra_funcion @id_funcion = 4, @descripcion = 'Alta Cliente';
EXEC [NONAME].sp_migra_funcion @id_funcion = 5, @descripcion = 'Modificacion Cliente';
EXEC [NONAME].sp_migra_funcion @id_funcion = 6, @descripcion = 'Baja Cliente';
EXEC [NONAME].sp_migra_funcion @id_funcion = 7, @descripcion = 'Alta Chofer';
EXEC [NONAME].sp_migra_funcion @id_funcion = 8, @descripcion = 'Modificacion Chofer';
EXEC [NONAME].sp_migra_funcion @id_funcion = 9, @descripcion = 'Baja Chofer';
EXEC [NONAME].sp_migra_funcion @id_funcion = 10, @descripcion = 'Alta Auto';
EXEC [NONAME].sp_migra_funcion @id_funcion = 11, @descripcion = 'Modificacion Auto';
EXEC [NONAME].sp_migra_funcion @id_funcion = 12, @descripcion = 'Baja Auto';
EXEC [NONAME].sp_migra_funcion @id_funcion = 13, @descripcion = 'Alta Turno';
EXEC [NONAME].sp_migra_funcion @id_funcion = 14, @descripcion = 'Modificacion Turno';
EXEC [NONAME].sp_migra_funcion @id_funcion = 15, @descripcion = 'Baja Turno';
EXEC [NONAME].sp_migra_funcion @id_funcion = 16, @descripcion = 'Registro de Viajes';
EXEC [NONAME].sp_migra_funcion @id_funcion = 17, @descripcion = 'Pago al Chofer';
EXEC [NONAME].sp_migra_funcion @id_funcion = 18, @descripcion = 'Facturacion del Cliente';
EXEC [NONAME].sp_migra_funcion @id_funcion = 19, @descripcion = 'Listado Estadistico';
GO


SET IDENTITY_INSERT NONAME.Rol ON;

INSERT INTO [NONAME].Rol (tipo, id_rol, habilitado)
 VALUES 
		('Administrador', 1, 1),
		('Cliente', 2, 1),
		('Chofer', 3, 1)

SET IDENTITY_INSERT NONAME.Rol OFF;
GO

CREATE PROCEDURE [NONAME].sp_migra_funcion_rol (@id_rol int, @id_funcion int) 
AS
	INSERT INTO [NONAME].Funcion_Rol
	VALUES (@id_rol, @id_funcion)
GO

EXEC [NONAME].sp_migra_funcion_rol @id_rol = 1, @id_funcion = 1;
EXEC [NONAME].sp_migra_funcion_rol @id_rol = 1, @id_funcion = 2;
EXEC [NONAME].sp_migra_funcion_rol @id_rol = 1, @id_funcion = 3;
EXEC [NONAME].sp_migra_funcion_rol @id_rol = 1, @id_funcion = 4;
EXEC [NONAME].sp_migra_funcion_rol @id_rol = 1, @id_funcion = 5;
EXEC [NONAME].sp_migra_funcion_rol @id_rol = 1, @id_funcion = 6;
EXEC [NONAME].sp_migra_funcion_rol @id_rol = 1, @id_funcion = 7;
EXEC [NONAME].sp_migra_funcion_rol @id_rol = 1, @id_funcion = 8;
EXEC [NONAME].sp_migra_funcion_rol @id_rol = 1, @id_funcion = 9;
EXEC [NONAME].sp_migra_funcion_rol @id_rol = 1, @id_funcion = 10;
EXEC [NONAME].sp_migra_funcion_rol @id_rol = 1, @id_funcion = 11;
EXEC [NONAME].sp_migra_funcion_rol @id_rol = 1, @id_funcion = 12;
EXEC [NONAME].sp_migra_funcion_rol @id_rol = 1, @id_funcion = 13;
EXEC [NONAME].sp_migra_funcion_rol @id_rol = 1, @id_funcion = 14;
EXEC [NONAME].sp_migra_funcion_rol @id_rol = 1, @id_funcion = 15;
EXEC [NONAME].sp_migra_funcion_rol @id_rol = 1, @id_funcion = 16;
EXEC [NONAME].sp_migra_funcion_rol @id_rol = 1, @id_funcion = 17;
EXEC [NONAME].sp_migra_funcion_rol @id_rol = 1, @id_funcion = 18;
EXEC [NONAME].sp_migra_funcion_rol @id_rol = 1, @id_funcion = 19;
EXEC [NONAME].sp_migra_funcion_rol @id_rol = 2, @id_funcion = 16;
GO


SET IDENTITY_INSERT NONAME.Turno ON;
GO
INSERT INTO [NONAME].Turno (hora_inicio, hora_fin, descripcion, valor_km, precio_base, id_turno, habilitado)
 VALUES 
		(0, 8, 'Turno Mañna', 0.73, 7.30, 1, 1),
		(8, 16, 'Turno Tarde', 0.73, 7.30, 2, 1),
		(16, 24, 'Turno Noche', 0.85, 8.50, 3, 1)

SET IDENTITY_INSERT NONAME.Turno OFF;
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
	'Administrador',
	'General',
	0000000000000000,
	'N/A',
	'N/A',
	GETDATE(),
	'admin',
	HASHBYTES('SHA2_256', cast('w23e' as nvarchar(255))),
	1,
	0)
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
	SELECT DISTINCT
	m.Viaje_Fecha,
	m.Viaje_Fecha,
	m.Viaje_Cant_Kilometros,
	t.id_turno,
	ch.id_usuario,
	cl.id_usuario
	from [gd_esquema].[Maestra] m
	join [NONAME].Turno t ON m.Turno_Descripcion = t.descripcion
	join [NONAME].Usuario ch ON m.Chofer_Dni = ch.usuario_dni 
	join [NONAME].Usuario cl ON m.Cliente_Dni = cl.usuario_dni
	
GO


INSERT INTO [NONAME].Auto
	SELECT DISTINCT 
	m.Auto_Patente,
	m.Auto_Modelo,
	mar.id_marca,
	m.Auto_rodado,
	1,
	m.Auto_Licencia
	from [gd_esquema].[Maestra] m
	join [NONAME].Marca mar ON m.Auto_Marca = mar.nombre


INSERT INTO [NONAME].Auto_Chofer
	SELECT DISTINCT
	a.id_auto,
	c.id_usuario,
	t.id_turno
	from [gd_esquema].[Maestra] m
	join [NONAME].Turno t ON m.Turno_Descripcion = t.descripcion
	join [NONAME].Auto a ON m.Auto_Patente = a.patente_auto
	join [NONAME].Usuario c ON m.Chofer_Dni = c.usuario_dni 


INSERT INTO [NONAME].Rol_Usuario
  SELECT
	1,
    id_usuario
  FROM NONAME.Usuario
  WHERE Usuario.nombre = 'Administrador'

GO

INSERT INTO [NONAME].Rol_Usuario
  SELECT
    2,
    id_cliente
  FROM [NONAME].Cliente

GO

INSERT INTO [NONAME].Rol_Usuario
  SELECT
    3,
    id_chofer
  FROM [NONAME].Chofer

GO

SET IDENTITY_INSERT [NONAME].Factura ON;
GO

INSERT INTO [NONAME].Factura (nro_factura, id_cliente, fecha_fin, fecha_inicio, fecha, facturada)
SELECT DISTINCT
	m.Factura_Nro,
	c.id_usuario,
	m.Factura_Fecha_Fin,
	m.Factura_Fecha_Inicio,
	m.Factura_Fecha,
	1
	FROM [gd_esquema].[Maestra] m
	join [NONAME].Usuario c ON m.Cliente_Dni = c.usuario_dni
	where Factura_Nro is not null

SET IDENTITY_INSERT NONAME.Factura OFF;
GO

INSERT INTO [NONAME].Factura_Viaje
	SELECT DISTINCT
	f.nro_factura,
	v.id_viaje
	from [gd_esquema].[Maestra] m
	join [NONAME].Factura f ON m.Factura_Nro = f.nro_factura
	join noname.usuario c on c.usuario_dni = m.Cliente_Dni
	join noname.usuario ch on ch.usuario_dni = m.Chofer_Dni
	join [NONAME].Viaje v ON v.fecha_hora_inicio = m.Viaje_Fecha
	and c.id_usuario = v.id_cliente and ch.id_usuario = v.id_chofer			
												  
SET IDENTITY_INSERT NONAME.Rendicion ON;
GO

INSERT INTO [NONAME].Rendicion (nro_rendicion, id_chofer, fecha, id_turno, importe, rendida)
	SELECT DISTINCT
	m.Rendicion_Nro,
	c.id_usuario,
	m.Rendicion_Fecha,
	t.id_turno,
	sum(m.Rendicion_Importe),
	1 
	from [gd_esquema].[Maestra] m
	join [NONAME].Usuario c ON m.Chofer_Dni = c.usuario_dni 
	join [NONAME].Turno t ON m.Turno_Descripcion = t.descripcion
	where m.Rendicion_Nro is not null 
	group by m.Rendicion_Nro, c.id_usuario, m.Rendicion_Fecha, t.id_turno
	order by m.Rendicion_Nro
GO

SET IDENTITY_INSERT NONAME.Rendicion OFF;
GO

INSERT INTO [NONAME].Rendicion_Viaje
	SELECT DISTINCT
	id_viaje,
	m.Rendicion_Nro,
	(100*m.Rendicion_Importe/(m.Viaje_Cant_Kilometros * m.Turno_Valor_Kilometro + m.Turno_Precio_Base))
	from gd_esquema.Maestra m
	join [NONAME].Rendicion r on r.nro_rendicion = m.Rendicion_Nro
	join [NONAME].Viaje v on v.cantidad_km = m.Viaje_Cant_Kilometros
	and v.fecha_hora_inicio = m.Viaje_Fecha
	and v.id_chofer = r.id_chofer
	where Rendicion_Nro is not null

DBCC CHECKIDENT ('[NONAME].[Factura]', RESEED, 10700)
DBCC CHECKIDENT ('[NONAME].[Rendicion]', RESEED, 46500)

USE [GD1C2017]
GO

-- Validacion de existencia 

IF SCHEMA_ID('NONAME') IS NOT NULL
BEGIN


--tablas

  IF OBJECT_ID('NONAME.Factura') IS NOT NULL
    DROP TABLE [NONAME].Factura

  IF OBJECT_ID('NONAME.cliente') IS NOT NULL
    DROP TABLE [NONAME].cliente

  IF OBJECT_ID('NONAME.Usuario') IS NOT NULL
    DROP TABLE [NONAME].Usuario

  IF OBJECT_ID('NONAME.Viaje') IS NOT NULL
    DROP TABLE [NONAME].Viaje

  IF OBJECT_ID('NONAME.Rendicion_viaje') IS NOT NULL
    DROP TABLE [NONAME].Rendicion_viaje

  IF OBJECT_ID('NONAME.Rendicion') IS NOT NULL
    DROP TABLE [NONAME].Rendicion

  IF OBJECT_ID('NONAME.Chofer') IS NOT NULL
    DROP TABLE [NONAME].Chofer

  IF OBJECT_ID('NONAME.Auto_Chofer') IS NOT NULL
    DROP TABLE [NONAME].Auto_Chofer

  IF OBJECT_ID('NONAME.Auto') IS NOT NULL
    DROP TABLE [NONAME].Auto

 IF OBJECT_ID('NONAME.Marca') IS NOT NULL
    DROP TABLE [NONAME].Marca

  IF OBJECT_ID('NONAME.Rol_Usuario') IS NOT NULL
    DROP TABLE [NONAME].Rol_Usuario

  IF OBJECT_ID('NONAME.Rol') IS NOT NULL
    DROP TABLE [NONAME].Rol

  IF OBJECT_ID('NONAME.Funcion_Rol') IS NOT NULL
    DROP TABLE [NONAME].Funcion_Rol

  IF OBJECT_ID('NONAME.Funcion') IS NOT NULL
    DROP TABLE [NONAME].Funcion

END
GO
  
--Creacion de Esquema 

CREATE SCHEMA [NONAME] AUTHORIZATION [gd]
GO

CREATE TABLE [NONAME].[Factura](
	[nro_factura] [numeric](18, 0) NOT NULL,
	[id_cliente] [numeric](18, 0) NOT NULL,
	[id_viaje] [int] NOT NULL,
	[fecha_fin] [datetime] NOT NULL,
	[fecha_inicio] [datetime] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[importe] [numeric](18, 0) NOT NULL
)
GO

CREATE TABLE [NONAME].[Cliente](
	[id_cliente] [numeric](18, 0) NOT NULL,
	[codigo_postal] [varchar](50) NOT NULL
)
GO

CREATE TABLE [NONAME].[Usuario](
	[id_usuario_dni] [numeric](18, 0) NOT NULL,
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
	[id_viaje] [int] NOT NULL,
	[fecha_hora_inicio] [datetime] NOT NULL,
	[fecha_hora_fin] [datetime] NOT NULL,
	[cantidad_km] [numeric](18, 0) NOT NULL,
	[id_turno] [int] NOT NULL,
	[id_chofer] [numeric](18, 0) NOT NULL,
	[id_cliente] [numeric](18, 0) NOT NULL
)
GO


CREATE TABLE [NONAME].[Rendicion_Viaje](
	[id_viaje] [int] NOT NULL,
	[nro_rendicion] [numeric](18, 0) NOT NULL,
	[porcentaje] [numeric](18, 0) NOT NULL
)
GO

CREATE TABLE [NONAME].[Rendicion](
	[nro_rendicion] [int] NOT NULL,
	[id_chofer] [numeric](18, 0) NOT NULL,
	[id_viaje] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[id_turno] [int] NOT NULL,
	[importe] [numeric](18, 0) NOT NULL
)
GO

CREATE TABLE [NONAME].[Chofer](
	[id_chofer] [numeric](18, 0) NOT NULL,
	[patente_auto] [varchar](10) NOT NULL,
 )
 GO

CREATE TABLE [NONAME].[Auto_chofer](
	[patente_auto] [varchar](50) NOT NULL,
	[id_chofer] [numeric](18, 0) NOT NULL
)
GO

CREATE TABLE [NONAME].[Auto](
	[patente_auto] [varchar](10) NOT NULL,
	[modelo] [varchar](255) NOT NULL,
	[id_turno] [int] NOT NULL,
	[id_marca] [int] NOT NULL,
	[rodado] [varchar](10) NOT NULL,
	[habilitado] [bit] NOT NULL,
	[licencia] [varchar](26) NOT NULL
)
GO

CREATE TABLE [NONAME].[Marca](
	[id_marca] [int] NOT NULL,
	[nombre] [varchar](255) NOT NULL
)
GO

CREATE TABLE [NONAME].[Rol_Usuario](
	[id_rol] [int] NOT NULL,
	[id_usuario_dni] [numeric](18, 0) NOT NULL
)
GO

CREATE TABLE [NONAME].[Rol](
	[id_rol] [int] NOT NULL,
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

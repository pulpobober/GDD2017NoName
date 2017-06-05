USE [GD1C2017]
GO


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

IF TYPE_ID('NONAME.ListaFuncionalidadesRol') IS NOT NULL
	DROP TYPE NONAME.ListaFuncionalidadesRol
GO


CREATE TYPE NONAME.ListaFuncionalidadesRol
AS TABLE (
	id_funcion INT NOT NULL PRIMARY KEY);
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
		HASHBYTES('SHA2_256', CAST(@usuario_dni as NVARCHAR(10))),
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
	@id_usuario INT

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
	@id_turno INT,
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
		id_turno,
		id_marca,
		rodado,
		habilitado,
		licencia)
	VALUES (
		@patente_auto,
		@modelo,
		@id_turno,
		@id_marca,
		@rodado,
		@habilitado,
		@licencia)

	SET @id_auto = SCOPE_IDENTITY() --Capturo el último id_auto auto-incrementado en Auto

	IF NOT EXISTS (SELECT 1 FROM NONAME.Auto_Chofer WHERE id_auto = @id_auto AND id_chofer = @id_chofer)
		BEGIN
			INSERT INTO [NONAME].Auto_Chofer
			SELECT Auto.id_auto, Chofer.id_chofer
			FROM NONAME.Auto, NONAME.Chofer
			WHERE Auto.id_auto = @id_auto and Chofer.id_chofer = @id_chofer
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
	@id_turno INT,
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
	SET
		patente_auto = @patente_auto,
		modelo = @modelo,
		id_turno = @id_turno,
		id_marca = @id_marca
	WHERE id_auto = @id_auto

	
	UPDATE NONAME.Auto_Chofer
	SET id_chofer = @id_chofer
	WHERE id_auto = @id_auto

	
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


CREATE PROCEDURE NONAME.sproc_rol_alta
	@tipo VARCHAR(255),
	@ids_funciones AS NONAME.ListaFuncionalidadesRol READONLY,--Lista de tipo Tabla (Table-Valued Parameters) que contiene al menos un valor de id_funcion
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
	SELECT @id_rol, id_funcion
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
	@ids_funciones AS NONAME.ListaFuncionalidadesRol READONLY,--Lista opcional de tipo Tabla (Table-Valued Parameters) que contiene (o no) uno o más valores de id_funcion
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
Caso contrario, dejo todo igual */
	IF EXISTS (SELECT 1 FROM @ids_funciones) --Me llegó al menos un id_funcion ==> AGREGO Y/O QUITO FUNCIONALIDADES
		BEGIN
			
			DECLARE @id_funcion INT;
	
			--Asigno al Rol aquellas nuevas funcionalidades que no tenía asignadas previamente
			INSERT INTO NONAME.Funcion_Rol
			SELECT @id_rol, id_funcion
			FROM @ids_funciones
			WHERE NOT EXISTS (SELECT 1 FROM NONAME.Funcion_Rol WHERE id_rol = @id_rol AND id_funcion = @id_funcion)
			
			--Quito aquellas funcionalidades viejas que ya no le corresponden al Rol
			DELETE FROM NONAME.Funcion_Rol
			WHERE Funcion_Rol.id_rol = @id_rol AND Funcion_Rol.id_funcion NOT IN (SELECT * FROM @ids_funciones)

		END
		
END
GO
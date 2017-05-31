IF OBJECT_ID('NONAME.sproc_cliente_alta') IS NOT NULL
	DROP PROCEDURE NONAME.sproc_cliente_alta

IF OBJECT_ID('NONAME.sproc_cliente_baja') IS NOT NULL
	DROP PROCEDURE NONAME.sproc_cliente_baja

IF OBJECT_ID('NONAME.sproc_cliente_modificacion') IS NOT NULL
	DROP PROCEDURE NONAME.sproc_cliente_modificacion

GO

CREATE PROCEDURE NONAME.sproc_cliente_alta
	@nombre varchar(255),
	@apellido varchar(255),
	@dni numeric(18,0),
	@mail varchar(50),
	@telefono numeric(18, 0),
	@direccion varchar(255),
	@codigo_postal varchar(50),
	@fecha_nacimiento datetime

AS
BEGIN

	DECLARE @id_rol int
	DECLARE @iden int

	SET @id_rol = (SELECT id_rol FROM NONAME.Rol WHERE UPPER(tipo) = 'CLIENTE')

	INSERT INTO NONAME.Usuario (
		dni,
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
		@dni,
		@nombre,
		@apellido,
		@telefono,
		@direccion,
		@mail,
		@fecha_nacimiento,
		@dni,
		HASHBYTES('SHA2_256', CAST(@dni as nvarchar(10))),
		1,
		0)

	
	SET @iden = SCOPE_IDENTITY() --Capturo el último id_usuario auto-incrementado en Usuario

	INSERT INTO [NONAME].Cliente (
		id_cliente,
		codigo_postal)
	VALUES (
		@iden,
		@codigo_postal)


	INSERT INTO [NONAME].Rol_Usuario (
		id_rol,
		id_usuario)
	VALUES (
		@id_rol,
		@iden) -- @iden = último id_usuario auto-incrementado

END

GO


CREATE PROCEDURE NONAME.sproc_cliente_baja
	@id_usuario numeric(18,0)

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
	@id_usuario numeric(18,0), --chequear tipo de dato del PK auto-incremental
	@nombre varchar(255),
	@apellido varchar(255),
	@dni numeric(18,0),
	@mail varchar(50),
	@telefono numeric(18, 0),
	@direccion varchar(255),
	@codigo_postal varchar(50),
	@fecha_nacimiento datetime

AS
BEGIN
	
	UPDATE [NONAME].Usuario
	SET
		nombre = @nombre,
		apellido = @apellido,
		dni = @dni,
		mail = @mail,
		telefono = @telefono,
		direccion = @direccion,
		fecha_nacimiento = @fecha_nacimiento
	WHERE id_usuario = @id_usuario

	UPDATE NONAME.Cliente
	SET codigo_postal = @codigo_postal
	WHERE id_cliente = @id_usuario

END

GO
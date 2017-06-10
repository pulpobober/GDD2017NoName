use GD1C2017
go

--exec NONAME.sproc_cliente_alta @nombre ="nico",@apellido = "re nico",@usuario_dni =  '127',@mail = "ss",@telefono = 18297993 ,@direccion ="ss",@codigo_postal ='11',@fecha_nacimiento = '1/1/99',	@habilitado =  1

go	

exec NONAME.sproc_login_usuario @nombre_de_usuario='127',
@contrasena ='127'

go
go
ALTER PROCEDURE NONAME.sproc_login_usuario @nombre_de_usuario nvarchar(50),
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
ALTER PROCEDURE NONAME.sproc_cliente_alta
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
GO
SELECT
      cast(HASHBYTES('SHA2_256', '127') as nvarchar(255)),1
    FROM NONAME.Usuario
    WHERE nombre_de_usuario = '127'
 AND [contrasena] =  cast(HASHBYTES('SHA2_256', '127') as nvarchar(255))
   -- AND habilitado = 1

 
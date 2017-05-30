CREATE PROCEDURE NONAME.sproc_cliente_alta
@nombre varchar(255),
@apellido varchar(255),
@id_usuario_dni numeric(18,0),
@mail varchar(50),
@telefono numeric(18, 0),
@direccion varchar(255),
@codigo_postal varchar(50),
@fecha_nacimiento datetime

AS
BEGIN

  DECLARE @id_rol int

  SET @id_rol = (SELECT id_rol FROM NONAME.Rol WHERE UPPER(tipo) = 'CLIENTE')

  INSERT INTO NONAME.Usuario (
  id_usuario_dni,
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
    VALUES (@id_usuario_dni, @nombre, @apellido, @telefono, @direccion, @mail, @fecha_nacimiento, @id_usuario_dni, HASHBYTES('SHA2_256', @id_usuario_dni), 1, 0)


  INSERT INTO [NONAME].Cliente (
  id_cliente,
  codigo_postal)
    VALUES (@id_usuario_dni, @codigo_postal)


  INSERT INTO [NONAME].Rol_Usuario (
  id_rol,
  id_usuario_dni)
    VALUES (@id_rol, @id_usuario_dni)


END

GO
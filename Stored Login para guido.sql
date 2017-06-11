
CREATE PROCEDURE NONAME.sproc_login_usuario @nombre_de_usuario nvarchar(50),
@contrasena varchar(50)
AS
BEGIN
  IF EXISTS (SELECT
      1
    FROM NONAME.Usuario
    WHERE nombre_de_usuario = @nombre_de_usuario
    AND [contrasena] = HASHBYTES('SHA2_256', @contrasena)
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

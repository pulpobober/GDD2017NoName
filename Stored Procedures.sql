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

IF OBJECT_ID('NONAME.sproc_login_usuario') IS NOT NULL
	DROP PROCEDURE NONAME.sproc_login_usuario

IF OBJECT_ID('NONAME.sp_detelle_rendicion') IS NOT NULL
	DROP PROCEDURE NONAME.sp_detelle_rendicion
	
IF OBJECT_ID('NONAME.sp_importe_rendicion') IS NOT NULL
	DROP PROCEDURE NONAME.sp_importe_rendicion

IF OBJECT_ID('NONAME.sp_importe_facturacion') IS NOT NULL
	DROP PROCEDURE NONAME.sp_importe_facturacion	

IF OBJECT_ID('NONAME.sp_detalle_facturacion') IS NOT NULL
	DROP PROCEDURE NONAME.sp_detalle_facturacion	

IF TYPE_ID('NONAME.ListaFuncionalidadesRol') IS NOT NULL
	DROP TYPE NONAME.ListaFuncionalidadesRol
IF OBJECT_ID('NONAME.sp_RegistroViaje') IS NOT NULL
	DROP PROCEDURE NONAME.sp_RegistroViaje	
GO  


CREATE TYPE NONAME.ListaFuncionalidadesRol
AS TABLE (
	id_funcion INT NOT NULL PRIMARY KEY);
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
			SELECT Auto.id_auto, Chofer.id_chofer, Turno.id_turno
			FROM NONAME.Auto, NONAME.Chofer, NONAME.Turno
			WHERE Auto.id_auto = @id_auto AND Chofer.id_chofer = @id_chofer AND Turno.id_turno = @id_turno
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
	SET	patente_auto = @patente_auto,
		modelo = @modelo,
		id_marca = @id_marca
	WHERE id_auto = @id_auto

	
	UPDATE NONAME.Auto_Chofer
	SET id_chofer = @id_chofer,
		id_turno = @id_turno
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


CREATE PROCEDURE NONAME.sproc_turno_alta
	@hora_inicio NUMERIC(18, 0),
	@hora_fin NUMERIC(18, 0),
	@descripcion VARCHAR(255),
	@valor_km NUMERIC(18,0),
	@precio_base NUMERIC(18,0),
	@habilitado BIT

AS
BEGIN

	IF((@hora_inicio < @hora_fin) AND --el turno comienza y finaliza dentro del mismo dia y no excede las 24hs
		NOT EXISTS (SELECT 1  --los turnos no se superponen
					FROM NONAME.Turno
					WHERE (@hora_inicio > Turno.hora_inicio AND @hora_inicio < Turno.hora_fin) OR (@hora_fin > Turno.hora_inicio AND @hora_fin < Turno.hora_fin) AND (Turno.habilitado = 1)))
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
	@valor_km NUMERIC(18,0) = NULL,
	@precio_base NUMERIC(18,0) = NULL,
	@habilitado BIT = NULL

/*
Se debe poder volver a habilitar un turno inhabilitado desde la sección de 
modificación y el mismo debe cumplir con las mismas restricciones:
Bajo ninguna circunstancia las franjas horarias pueden superponerse entre sí.
Un turno no debe exceder las 24hs y además debe comenzar y finalizar dentro del mismo día.
*/

AS
BEGIN

--se precisa modificar tanto hora_inicio como hora_fin	
	IF((@hora_inicio IS NOT NULL) AND (@hora_fin IS NOT NULL))
		BEGIN
			IF((@hora_inicio < @hora_fin) AND --el turno comienza y finaliza dentro del mismo dia y no excede las 24hs
				NOT EXISTS (SELECT 1  --los turnos no se superponen
							FROM NONAME.Turno
							WHERE ((@hora_inicio > Turno.hora_inicio AND @hora_inicio < Turno.hora_fin) OR (@hora_fin > Turno.hora_inicio AND @hora_fin < Turno.hora_fin)) AND (Turno.id_turno <> @id_turno) AND (Turno.habilitado = 1)))
				BEGIN
					UPDATE [NONAME].Turno
					SET hora_inicio = @hora_inicio,
						hora_fin = @hora_fin
					WHERE id_turno = @id_turno
				END
		END
	

--se precisa modificar hora_inicio unicamente
	IF((@hora_inicio IS NOT NULL) AND (@hora_fin IS NULL))
		BEGIN
			DECLARE @hora_fin_orig NUMERIC(18,0)
			SET @hora_fin_orig = (SELECT Turno.hora_fin FROM NONAME.Turno WHERE id_turno = @id_turno)
			
			IF((@hora_inicio < @hora_fin_orig) AND --el turno comienza y finaliza dentro del mismo dia y no excede las 24hs
				NOT EXISTS (SELECT 1  --los turnos no se superponen
							FROM NONAME.Turno
							WHERE (@hora_inicio > Turno.hora_inicio AND @hora_inicio < Turno.hora_fin) AND (Turno.id_turno <> @id_turno) AND (Turno.habilitado = 1)))
				BEGIN
					UPDATE [NONAME].Turno
					SET hora_inicio = @hora_inicio
					WHERE id_turno = @id_turno
				END
		END


--se precisa modificar hora_fin unicamente
	IF((@hora_inicio IS NULL) AND (@hora_fin IS NOT NULL))
		BEGIN
			DECLARE @hora_inicio_orig NUMERIC(18,0)
			SET @hora_inicio_orig = (SELECT Turno.hora_inicio FROM NONAME.Turno WHERE id_turno = @id_turno)
			
			IF((@hora_inicio_orig < @hora_fin) AND --el turno comienza y finaliza dentro del mismo dia y no excede las 24hs
				NOT EXISTS (SELECT 1  --los turnos no se superponen
							FROM NONAME.Turno
							WHERE (@hora_fin > Turno.hora_inicio AND @hora_fin < Turno.hora_fin) AND (Turno.id_turno <> @id_turno) AND (Turno.habilitado = 1)))
				BEGIN
					UPDATE [NONAME].Turno
					SET hora_fin = @hora_fin
					WHERE id_turno = @id_turno
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
				NOT EXISTS (SELECT 1  --los turnos no se superponen
							FROM NONAME.Turno
							WHERE ((@hora_inicio_ > Turno.hora_inicio AND @hora_inicio_ < Turno.hora_fin) OR (@hora_fin_ > Turno.hora_inicio AND @hora_fin_ < Turno.hora_fin)) AND (Turno.id_turno <> @id_turno) AND (Turno.habilitado = 1)))
				BEGIN
					UPDATE [NONAME].Turno
					SET habilitado = @habilitado
					WHERE id_turno = @id_turno
				END
		END

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


CREATE PROCEDURE NONAME.sp_detelle_rendicion
	@id_usuario int, -- (id_usuario = id_chofer)
	@id_turno int,
	@fecha datetime
AS
BEGIN
	SELECT DISTINCT renvi.id_viaje
	FROM [NONAME].Rendicion_Viaje renvi
	JOIN [NONAME].Viaje v ON renvi.id_viaje = v.id_viaje
	JOIN [NONAME].Rendicion r ON renvi.nro_rendicion = r.nro_rendicion
	where v.id_chofer = @id_usuario
	and v.fecha_hora_inicio = @fecha
END
GO


CREATE PROCEDURE NONAME.sp_importe_rendicion
	@id_usuario int, -- (id_usuario = id_chofer)
	@id_turno int,
	@fecha datetime
AS
BEGIN
	SELECT importe
	FROM [NONAME].Rendicion 
	where id_chofer = @id_usuario
	and id_turno = @id_turno
	and fecha = @fecha
END
GO


CREATE PROCEDURE NONAME.sp_detalle_facturacion
	@id_usuario int, -- (id_usuario = id_cliente)
	@fecha datetime
AS
BEGIN
	SELECT fv.id_viaje
	FROM Factura_Viaje fv
	JOIN Viaje v ON fv.id_viaje = v.id_viaje
	JOIN Factura f ON fv.nro_factura = f.nro_factura
	WHERE f.fecha = @fecha 
	and f.id_cliente = @id_usuario
	
END
GO


CREATE PROCEDURE NONAME.sp_importe_facturacion
	@id_usuario int, -- (id_usuario = id_cliente)
	@fecha datetime
AS
BEGIN
	SELECT f.importe
	FROM NONAME.Factura f
	where f.id_cliente = @id_usuario
	and f.fecha = @fecha
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

	IF NOT EXISTS (SELECT 1 FROM NONAME.Factura_Viaje WHERE id_viaje = @id_viaje)
		BEGIN
			IF NOT EXISTS (SELECT 1 FROM NONAME.Factura re WHERE re.fecha = @fecha_inicio and re.id_cliente = @id_cliente)
				BEGIN
					DECLARE @nro_factura INT
					SET @nro_factura = SCOPE_IDENTITY()
					INSERT INTO [NONAME].Factura (nro_factura, id_cliente, fecha_fin, fecha_inicio, fecha, importe)
					VALUES (
						@nro_factura,
						@id_cliente,
						@fecha_fin,
						@fecha_inicio,
						@fecha_inicio,
						(@cant_km * (SELECT valor_km from NONAME.Turno where id_turno = @id_turno)))
				
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
					WHERE f.fecha = @fecha_fin and f.id_cliente = @id_cliente and v.id_viaje = @id_viaje	
				END
		END


	IF NOT EXISTS (SELECT 1 FROM NONAME.Rendicion_Viaje WHERE id_viaje = @id_viaje)
		BEGIN
			IF NOT EXISTS (SELECT 1 FROM NONAME.Rendicion re WHERE re.fecha = @fecha_inicio and re.id_chofer = @id_chofer)
				BEGIN
					DECLARE @nro_rendicion INT
					SET @nro_rendicion = SCOPE_IDENTITY()
					INSERT INTO [NONAME].Rendicion (nro_rendicion, id_chofer, fecha, id_turno, importe)
					VALUES (
						@nro_rendicion,
						@id_chofer,
						@fecha_inicio,
						@id_turno,
						(@cant_km * (SELECT valor_km from NONAME.Turno where id_turno = @id_turno)))

					INSERT INTO [NONAME].Rendicion_Viaje 
					SELECT v.id_viaje, r.nro_rendicion, (100*r.importe/(v.cantidad_km * t.valor_km + t.precio_base))
					FROM NONAME.Rendicion r, NONAME.Viaje v, NONAME.Turno t
					WHERE v.id_viaje = @id_viaje and t.id_turno = @id_turno and r.nro_rendicion = @nro_rendicion
				END
			ELSE
				BEGIN
					INSERT INTO [NONAME].Rendicion_Viaje 
					SELECT v.id_viaje, r.nro_rendicion, (100*r.importe/(v.cantidad_km * t.valor_km + t.precio_base))
					FROM NONAME.Rendicion r, NONAME.Viaje v, NONAME.Turno t
					WHERE v.id_viaje = @id_viaje and t.id_turno = @id_turno and r.id_chofer = @id_chofer 
					and r.fecha = @fecha_inicio and r.id_turno = @id_turno
				END
		END
END
GO
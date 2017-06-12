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

IF TYPE_ID('NONAME.ListaFuncionalidadesRol') IS NOT NULL
	DROP TYPE NONAME.ListaFuncionalidadesRol
GO


CREATE TYPE NONAME.ListaFuncionalidadesRol
AS TABLE (
	id_funcion INT NOT NULL PRIMARY KEY);
GO





-----------------------------

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


CREATE PROCEDURE NONAME.sproc_top5_clientesConMayorConsumo
	@anio INT,
	@trimestre INT
	

AS
begin
 	SELECT  top 5 (C.apellido + ', ' + C.nombre) AS Cliente, sum(f.importe) as Consumo
	FROM NONAME.Usuario as C join NONAME.Factura F on C.id_usuario = F.id_cliente
	where YEAR(F.fecha) = @anio AND DATEPART(QUARTER, f.fecha) = @trimestre
	group by (C.apellido + ', ' + C.nombre)
	

end 

GO


CREATE PROCEDURE NONAME.sproc_top1_clienteQueUtilizoMasVecesMismoAuto
	@anio INT,
	@trimestre INT

AS
BEGIN
SELECT TOP 5 (U.apellido + ', ' + U.nombre) as 'Nombre Cliente', count(patente_auto) as 'Mas veces mismo automobil', patente_auto as 'Patente auto'
FROM NONAME.Usuario U join NONAME.Viaje V on U.id_usuario = v.id_cliente
join NONAME.Auto_Chofer AC on AC.id_chofer = v.id_chofer AND AC.id_turno = v.id_turno
join NONAME.Auto A on A.id_auto = AC.id_auto
where YEAR(v.fecha_hora_inicio) = @anio AND DATEPART(QUARTER, f.fecha) = @trimestre
group by (U.apellido + ', ' + U.nombre), patente_auto
order by count(patente_auto) desc
END
GO
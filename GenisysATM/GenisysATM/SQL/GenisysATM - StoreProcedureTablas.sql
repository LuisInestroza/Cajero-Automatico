USE GenisysATM_V2
GO

--------------------------------------------------------------------------
-- STORE PROCEDURE TABLAS
---------------------------------------------------------------------------

-- CLIENTES

CREATE PROCEDURE sp_EliminarCliente
(
	@identidad char(3)

)
AS 
DELETE FROM ATM.Cliente
WHERE identidad = @identidad
GO

CREATE PROCEDURE sp_ActualizarCliente
(
	
	@nombres NVARCHAR(100), 
	@apellidos NVARCHAR(100), 
	@identidad CHAR(13), 
	@direccion NVARCHAR(2000), 
	@telefono CHAR(9),
	@celular CHAR(9) 
)
AS BEGIN
UPDATE ATM.Cliente
SET nombres=@nombres,
	apellidos=@apellidos,
	direccion=@direccion,
	telefono=@telefono,
	celular=@celular
WHERE identidad=@identidad
END
GO

-- SERVICIO PUBLICO

CREATE PROCEDURE sp_EliminarServicioPublico
(
	@id int

)
AS 
DELETE FROM ATM.ServicioPublico
WHERE id = @id
GO

CREATE PROCEDURE sp_ActualizarServicioPulico
(
	
	@id int,
	@descripcion NVARCHAR(100)
	
)
AS BEGIN
UPDATE ATM.ServicioPublico
SET descripcion=@descripcion
WHERE id=@id
END
GO

-- TARJETA CREDITO
CREATE PROCEDURE sp_EliminarTarjetaCredito
(
	@id int

)
AS 
DELETE FROM ATM.TarjetaCredito
WHERE id = @id
GO


CREATE PROCEDURE sp_ActualizarTarjetaCredito
(
	
	@id INT, 
	@descripcion NVARCHAR(100), 
	@monto DECIMAL(12,2),
	@limite DECIMAL(12,2)

	
)
AS BEGIN
UPDATE ATM.TarjetaCredito
SET descripcion=@descripcion,
	monto=@monto,
	limite=@limite
WHERE id=@id
END
GO

-- CONFIGURACION

CREATE PROCEDURE sp_EliminarConfiguracion
(
	@appkey NCHAR(50)

)
AS 
DELETE FROM ATM.Configuracion
WHERE  @appkey=appKey
GO

CREATE PROCEDURE sp_ActualizarConfiguracion
(
	
	@appKey NCHAR(50),
	@valor NCHAR(50), 
	@descripcion NVARCHAR(2000)


	
)
AS BEGIN
UPDATE ATM.Configuracion
SET valor=@valor,
	descripcion=@descripcion
WHERE appKey=@appKey
END
GO

-- CUENTA CLIENTE
CREATE PROCEDURE sp_EliminarCuentaClient
(
	@numero CHAR(14)

)
AS 
DELETE FROM ATM.CuentaCliente
WHERE  @numero=numero
GO


CREATE PROCEDURE sp_ActualizarCuentaCliente
(
	
	@numero CHAR(14),
	@idCliente INT ,
	@saldo DECIMAL(12,2),
	@pin CHAR(4)


	
)
AS BEGIN
UPDATE ATM.CuentaCliente
SET idCliente=@idCliente,
	saldo=@saldo,
	pin=@pin
WHERE numero=@numero
END
GO


-- SERVICIO CLIENTE
CREATE PROCEDURE sp_EliminaRServicioCliente
(
	@id INT

)
AS 
DELETE FROM ATM.ServicioCliente
WHERE  @id=id
GO



CREATE PROCEDURE sp_ActualizarServicioCliente
(
	
	@id INT ,
	@idCliente INT,
	@idServicio INT,
	@saldo DECIMAL(12,2)


	
)
AS BEGIN
UPDATE ATM.ServicioCliente
SET idCliente=@idCliente,
	idServicio=@idServicio,
	saldo=@saldo
WHERE id=@id
END
GO


--PROCEDIMIENTO MODIFICAR CLIENTES
CREATE PROCEDURE ModificarCliente
@IDCLIENTE varchar(5),
@APELLIDOS varchar(30),
@NOMBRES varchar(30)
AS
UPDATE CLIENTE
SET 
IDCLIENTE=@IDCLIENTE,
APELLIDOS=@APELLIDOS,
NOMBRES=@NOMBRES
WHERE NOMBRES=@NOMBRES

EXEC ModificarCliente 'ARMAD','VALDECILLA','MIGUEL';
CREATE PROCEDURE EliminarCliente
@Nombre varchar(50)
AS
DELETE FROM CLientes
WHERE @Nombre=Nombre

EXEC EliminarCliente 'PEPE'
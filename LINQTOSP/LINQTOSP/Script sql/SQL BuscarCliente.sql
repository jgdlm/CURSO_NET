CREATE PROCEDURE Buscarcliente
@Nombre varchar(50)
AS
SELECT *
FROM CLientes
WHERE Nombre LIKE '%' +@Nombre+'%'

EXEC Buscarcliente 'JUAN'
CREATE PROCEDURE Modificarcliente
@Nombre varchar(50),
@Apellido1 varchar(50),
@Apellido2 varchar(50),
@telefono varchar(50)
AS
UPDATE CLientes
SET 
Nombre=@Nombre,
Apellido1=@Apellido1,
Apellido2=@Apellido2,
Telefono=@telefono
WHERE Nombre=@Nombre

EXEC Modificarcliente 'PEPE','EL','GRIS','XXXXXXXXX'
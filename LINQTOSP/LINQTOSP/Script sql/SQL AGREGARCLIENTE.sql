CREATE PROCEDURE insertarcliente
@Nombre varchar(50),
@Apellido1 varchar(50),
@Apellido2 varchar(50),
@telefono varchar(50)
AS
INSERT INTO CLientes(Nombre,Apellido1,Apellido2,Telefono)
VALUES(@Nombre,@Apellido1,@Apellido2,@Telefono)

EXEC insertarcliente 'PEPE','PEREZ','PERNIA','661660330';
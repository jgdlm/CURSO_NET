--1º Consulta que muestre aquellos domicilios de los socios que empiezan por “S”.

SELECT domicilio
FROM Socios
WHERE domicilio LIKE 'S%';

--2º Se desea saber el deporte de Alberto y su domicilio
SELECT deporte,domicilio
FROM Socios INNER JOIN inscritos
ON socios.numero=inscritos.numerosocio
WHERE nombre LIKE '%Alberto%';

--3º Consulta que muestre toda la información referente a los socios y sus subscripciones.
SELECT *
FROM Socios INNER JOIN inscritos
ON socios.numero=inscritos.numerosocio;

--4º Contar todos los socios inscritos en Tenis.
SELECT COUNT(socios.nombre)
FROM Socios INNER JOIN inscritos
ON socios.numero=inscritos.numerosocio
WHERE inscritos.deporte='Tenis';

--5º Emplea una subconsulta con el operador "exists" para devolver la lista de socios que se inscribieron en un determinado deporte.
SELECT nombre
FROM socios s
WHERE exists (SELECT * FROM inscritos i
WHERE deporte='Natacion' AND s.numero=i.numerosocio);

--6º Busca los socios que NO se han inscripto en un deporte determinado empleando "not exists".
SELECT nombre
FROM socios s
WHERE not exists (SELECT * FROM inscritos i
WHERE deporte='Natacion' AND s.numero=i.numerosocio);


--7º Muestra todos los datos de los socios que han pagado todas las cuotas (subconsulta).
SELECT *
FROM socios s
WHERE exists (SELECT * FROM inscritos i
WHERE cuotas= 10 AND s.numero=i.numerosocio);


--8º- Obten el mismo resultado de la consulta anterior pero esta vez emplea una combinación (join).
SELECT s.* 
FROM inscritos i INNER JOIN socios s
ON s.numero=i.numerosocio
WHERE cuotas= 10;




--9º Se desean hacer los siguientes procedimientos almacenados:
--a) Un procedimiento que pueda insertar tanto un socio como un deporte vinculado a un socio
CREATE PROCEDURE INSERTASOCIOS
@NUM int,
@DOC CHAR(8),
@NOMBRE VARCHAR(30),
@DOMICILIO VARCHAR(30)
AS
INSERT INTO SOCIOS(numero,documento,nombre,domicilio)
VALUES(@NUM,@DOC,@NOMBRE,@DOMICILIO)

EXEC INSERTASOCIOS

--b) Un procedimiento para modificar un socio o un deporte asignado (osea que se pueda cambiar el deporte de un socio).
CREATE PROCEDURE MODIFICASOCIO
@NUMSOCIO int,
@DEPORTE VARCHAR(20)
AS
UPDATE inscritos
SET deporte=@DEPORTE
WHERE @NUMSOCIO=numerosocio


--c) Un procedimiento que pueda eliminar un Socio cuyo id se introduce por teclado
CREATE PROCEDURE ELIMINASOCIO
@IDSOCIO int
AS
DELETE FROM SOCIOS
WHERE numero=@IDSOCIO;
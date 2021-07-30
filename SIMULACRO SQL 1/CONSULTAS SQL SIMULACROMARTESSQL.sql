--CONSULTAS SQL
--CONSULTAS SOBRE UNA TABLA
USE SIMULACROMARTESSQL;
GO
--1. Devuelve un listado con todos los pedidos que se han realizado. Los pedidos deben estar ordenados por la fecha de realización, mostrando en primer lugar los pedidos más recientes.
SELECT *
FROM pedido
ORDER BY fecha DESC;

--2. Devuelve todos los datos de los dos pedidos de mayor valor(los dos mayores).
SELECT TOP (2) *
FROM pedido
ORDER BY cantidad DESC; 


--3. Devuelve un listado con los identificadores de los clientes que han realizado algún pedido. Tenga en cuenta que no debe mostrar identificadores que estén repetidos.
SELECT DISTINCT id_cliente
FROM pedido;


--4. Devuelve un listado de todos los pedidos que se realizaron durante el año 2017, cuya cantidad total sea superior a 500€.
SELECT *
FROM pedido
WHERE YEAR(fecha)=2017 AND cantidad>500; --devuelve un año de un formato fecha. Metdodo 1
--WHERE fecha BETWEEN '20170101' AND '20171230' Metodo 2
--WHERE fecha >= '20170101' AND fecha <='20171230' Metodo 3

--5. Devuelve un listado con el nombre y los apellidos de los comerciales que tienen una comisión entre 0.05 y 0.11.
SELECT nombre, apellido1, apellido2
FROM comercial
WHERE comision BETWEEN 0.05 AND 0.11;


--6. Devuelve el valor de la comisión de mayor valor que existe en la tabla comercial.
SELECT TOP 1 comision
FROM comercial;

--7. Devuelve el identificador, nombre y primer apellido de aquellos clientes cuyo segundo apellido no es NULL. El listado deberá estar ordenado alfabéticamente por apellidos y nombre.
SELECT id,nombre,apellido1,apellido2
FROM cliente
WHERE apellido2 IS NOT NULL
ORDER BY apellido1,apellido2,nombre


--8. Devuelve un listado de los nombres de los clientes que empiezan por A y terminan por n y también los nombres que empiezan por P. El listado deberá estar ordenado alfabéticamente.
SELECT nombre
FROM cliente
WHERE nombre LIKE 'A%n' OR nombre LIKE 'P%'
ORDER BY nombre ASC;

--9. Devuelve un listado de los nombres de los clientes que no empiezan por A. El listado deberá estar ordenado alfabéticamente.
SELECT nombre
FROM cliente
WHERE nombre NOT LIKE 'A%'
ORDER BY nombre ASC;

--10. Devuelve un listado con los nombres de los comerciales que terminan por el o. Tenga en cuenta que se deberán eliminar los nombres repetidos.
SELECT DISTINCT nombre
FROM comercial
WHERE nombre LIKE '%O';



--CONSULTAS MULTITABLA (COMPOSICION INTERNA)

--1. Devuelve un listado con el identificador, nombre y los apellidos de todos los clientes que han realizado algún pedido. El listado debe estar ordenado alfabéticamente y se deben eliminar los elementos repetidos.
SELECT DISTINCT cliente.id,nombre, apellido1, apellido2
FROM cliente INNER JOIN pedido
ON cliente.id=pedido.id_cliente
ORDER BY apellido1, nombre;

--2. Devuelve un listado que muestre todos los pedidos que ha realizado cada cliente. El resultado debe mostrar todos los datos de los pedidos y del cliente. El listado debe mostrar los datos de los clientes ordenados alfabéticamente.
SELECT DISTINCT *
FROM cliente INNER JOIN pedido
ON cliente.id=pedido.id_cliente
ORDER BY apellido1, nombre;


--3. Devuelve un listado que muestre todos los pedidos en los que ha participado un comercial. El resultado debe mostrar todos los datos de los pedidos y de los comerciales. El listado debe mostrar los datos de los comerciales ordenados alfabéticamente.
SELECT *
FROM comercial INNER JOIN pedido
ON comercial.id=pedido.id_comercial
ORDER BY nombre;


--4. Devuelve un listado que muestre todos los clientes, con todos los pedidos que han realizado y con los datos de los comerciales asociados a cada pedido.
SELECT *
FROM comercial INNER JOIN pedido
ON pedido.id_comercial=comercial.id
INNER JOIN cliente
ON pedido.id_cliente=cliente.id



--5. Devuelve un listado de todos los clientes que realizaron un pedido durante el año 2017, cuya cantidad esté entre 300 € y 1000 €.
SELECT cliente.*,pedido.cantidad, pedido.fecha
FROM pedido INNER JOIN cliente
ON pedido.id_cliente=cliente.id
WHERE cantidad BETWEEN 300 AND 1000 AND YEAR(fecha)=2017


--6. Devuelve el nombre y los apellidos de todos los comerciales que ha participado en algún pedido realizado por María Santana Moreno.
SELECT DISTINCT comercial.apellido1,comercial.apellido2,comercial.nombre
FROM pedido INNER JOIN comercial
ON pedido.id_comercial=comercial.id
INNER JOIN cliente
ON cliente.id=pedido.id_cliente
WHERE cliente.nombre='María' AND cliente.apellido1='Santana' AND cliente.apellido2='Moreno';


--7. Devuelve el nombre de todos los clientes que han realizado algún pedido con el comercial Daniel Sáez Vega.
SELECT DISTINCT cliente.apellido1,cliente.apellido2,cliente.nombre
FROM pedido INNER JOIN comercial
ON pedido.id_comercial=comercial.id
INNER JOIN cliente
ON cliente.id=pedido.id_cliente
WHERE comercial.nombre='Daniel' AND comercial.apellido1='Sáez' AND comercial.apellido2='Vega';



--CONSULTAS RESUMEN

--1. Calcula la cantidad total que suman todos los pedidos que aparecen en la tabla pedido.
SELECT 'UN TOTAL DE:', SUM(Cantidad) AS Sumatotal
FROM pedido;


--2. Calcula la cantidad media de todos los pedidos que aparecen en la tabla pedido.
SELECT 'UN TOTAL DE:', CAST(AVG(Cantidad) AS decimal(18,2))AS Sumatotal
FROM pedido;


--3. Calcula el número total de comerciales distintos que aparecen en la tabla pedido.
SELECT COUNT (DISTINCT id_comercial) AS NUMERO_COMERCIALES
FROM pedido;


--4. Calcula el número total de clientes que aparecen en la tabla cliente.
SELECT COUNT(id) AS NUMERO_CLIENTES
FROM pedido;

--5. Calcula cuál es la mayor cantidad que aparece en la tabla pedido.
SELECT MAX(Cantidad)AS NUMERO_CLIENTES
FROM pedido;

--6. Calcula cuál es la menor cantidad que aparece en la tabla pedido.
SELECT MIN(Cantidad)AS NUMERO_CLIENTES
FROM pedido;


--7. Calcula cuál es el valor máximo de categoría para cada una de las ciudades que aparece en la tabla cliente.
SELECT MAX(categoria),ciudad
FROM cliente
GROUP BY ciudad;


--8. Calcula cuál es el máximo valor de los pedidos realizados durante el mismo día para cada uno de los clientes. Es decir, el mismo cliente puede haber realizado varios pedidos de diferentes cantidades el mismo día. Se pide que se calcule cuál es el pedidode máximo valor para cada uno de los días en los que un cliente ha realizado un pedido. Muestra el identificador del cliente, nombre, apellidos, la fecha y el valor de la cantidad.
SELECT DISTINCT MAX(Cantidad) AS MAYOR, cliente.id,nombre,apellido1, apellido2, fecha
FROM cliente INNER JOIN pedido
ON cliente.id=pedido.id_cliente
GROUP BY cliente.id,nombre,apellido1, apellido2, fecha
ORDER BY nombre;


--9. Calcula cuál es el máximo valor de los pedidos realizados durante el mismo día para cada uno de los clientes, teniendo en cuenta que sólo queremos mostrar aquellos pedidos que superen la cantidad de 2000 €.
SELECT MAX(Cantidad) AS MAYOR, cliente.id,nombre,apellido1, apellido2, fecha
FROM cliente INNER JOIN pedido
ON cliente.id=pedido.id_cliente
GROUP BY cliente.id,nombre,apellido1, apellido2, fecha,Cantidad
HAVING  MAX(Cantidad)>2000;


--10. Calcula el máximo valor de los pedidos realizados para cada uno de los comerciales durante la fecha 2016-08-17. Muestra el identificador del comercial, nombre, apellidos y total.
SELECT MAX(Cantidad) AS MAXIMO,comercial.id,nombre,apellido1, apellido2
FROM comercial INNER JOIN pedido
ON comercial.id=pedido.id_comercial
WHERE fecha='20160817'
GROUP BY comercial.id,nombre,apellido1, apellido2


--11. Devuelve un listado con el identificador de cliente, nombre y apellidos y el número total de pedidos que ha realizado cada uno de clientes. Tenga en cuenta que pueden existir clientes que no han realizado ningún pedido. Estos clientes también deben aparecer en el listado indicando que el número de pedidos realizados es 0.
SELECT cliente.id,nombre,apellido1,COUNT(id_cliente) AS NUMERO_PEDIDO
FROM cliente LEFT JOIN pedido
ON cliente.id=pedido.id_cliente
GROUP BY cliente.id,nombre,apellido1;



--12. Devuelve un listado con el identificador de cliente, nombre y apellidos y el número total de pedidos que ha realizado cada uno de clientes durante el año 2017.
SELECT nombre,apellido1,COUNT(cliente.id) AS NUMERO_PEDIDO
FROM cliente LEFT JOIN pedido
ON cliente.id=pedido.id_cliente
WHERE YEAR(fecha)=2017
GROUP BY nombre,apellido1;


--13. Devuelve un listado que muestre el identificador de cliente, nombre, primer apellido y el valor de la máxima cantidad del pedido realizado por cada uno de los clientes. El resultado debe mostrar aquellos clientes que no han realizado ningún pedido indicando que la máxima cantidad de sus pedidos realizados es 0. Puede hacer uso de la función IFNULL(0).
SELECT cliente.id,nombre,apellido1,apellido2,MAX(Cantidad) AS MAXIMO
FROM cliente LEFT JOIN pedido
ON cliente.id=pedido.id_cliente
GROUP BY Cantidad,cliente.id,nombre,apellido1,apellido2
HAVING Cantidad IS NULL;

--14. Devuelve cuál ha sido el pedido de máximo valor que se ha realizado cada año.
SELECT MAX(Cantidad),YEAR(fecha) AS FECHA
FROM pedido
GROUP BY YEAR(fecha);

--15. Devuelve el número total de pedidos que se han realizado cada año
SELECT COUNT(id),YEAR(fecha) AS FECHA
FROM pedido
GROUP BY YEAR(fecha);


--SUBCONSULTAS

--1. Devuelve un listado con todos los pedidos que ha realizado Adela Salas Díaz. (Sin utilizar INNER JOIN).
SELECT *
FROM pedido
WHERE pedido.id_cliente=(SELECT id
FROM cliente
WHERE nombre='Adela' AND apellido1='Salas')


--2. Devuelve el número de pedidos en los que ha participado el comercial Daniel Sáez Vega. (Sin utilizar INNER JOIN)
SELECT 'PEDIDOS DE ADELA->',COUNT(*)
FROM pedido
WHERE pedido.id_comercial=(SELECT id
FROM comercial
WHERE nombre='Daniel' AND apellido1='Sáez')

--3. Devuelve los datos del cliente que realizó el pedido más caro en el año 2019. (Sin utilizar INNER JOIN)
SELECT *
FROM cliente
WHERE id=(SELECT TOP 1 id_cliente FROM pedido
WHERE YEAR(fecha)=2019
ORDER BY Cantidad DESC)


--4. Devuelve la fecha y la cantidad del pedido de menor valor realizado por el cliente Pepe Ruiz Santana.
SELECT TOP 1 fecha,cantidad
FROM pedido
INNER JOIN cliente
ON pedido.id_cliente=cliente.id
WHERE cliente.nombre='Pepe' AND apellido1='Ruiz'
ORDER BY cantidad ASC;


--5. Devuelve un listado con los datos de los clientes y los pedidos, de todos los clientes que han realizado un pedido durante el año 2017 con un valor mayor o igual al valor medio de los pedidos realizados durante ese mismo año.
SELECT *
FROM cliente INNER JOIN pedido
ON pedido.id_cliente=cliente.id
WHERE YEAR(fecha)=2017 AND cantidad>=(
SELECT AVG(cantidad)
FROM pedido 
WHERE YEAR(fecha)=2017);


--PROCEDIMIENTOS ALMACENADOS SOBRE LA BASE DE DATOS SIMUACROMARTESSQL
--REPASANDO STORED PROCEDURES
--4 PRCEDIMIENTOS ALMACENADOS, ALTAS, BAJAS, MODIFICACIONES, CONSULTAS

--PROCEDIMIENTO ALMACENADO ALTA
CREATE PROCEDURE SP_ALTACLIENTE
@id int,
@nombre varchar(100),
@apellido1 varchar(100),
@apellido2 varchar(100),
@ciudad varchar(100),
@categoria int
AS
INSERT INTO cliente(id,nombre,apellido1,apellido2,ciudad,categoria)
VALUES(@id,@nombre,@apellido1,@apellido2,@ciudad,@categoria);
GO
--ESTA LINEA PARA PROBAR EL PROCEDIMIENTO
EXECUTE  SP_ALTACLIENTE 99,'KIKE','PEREZ','DIAZ','GIJON',300


--PROCEDIMIENTO ALMACENADO BAJA
CREATE PROCEDURE SP_ELIMINARCLIENTE
@id int
AS
DELETE 
FROM cliente
WHERE id=@id

EXECUTE  SP_ELIMINARCLIENTE 99;
--CON ALTER PRECEDURE SP_ELIMINARCLIENTE(PARA MODFICAR UN CAMPO NEVO EN LA TABLA)



--PROCEDIMIENTO ALMACENADO MODIFICACIÓN
CREATE PROCEDURE SP_MODIFICACLIENTE
@id int,
@nombre varchar(100),
@apellido1 varchar(100),
@apellido2 varchar(100),
@ciudad varchar(100),
@categoria int
AS
UPDATE cliente
SET
id=@id,
nombre=@nombre,
apellido1=@apellido1,
apellido2=@apellido2,
ciudad=@ciudad,
categoria=@categoria
WHERE id=@id;

EXECUTE SP_MODIFICACLIENTE 1,'Wee','ee','yy','hh',200;

--PROCEDIMIENTO ALMACENADO CONSULTAR POR ID
CREATE PROCEDURE SP_CONSULTACLIENTE
@id int
AS
SELECT *
FROM cliente
WHERE id=@id;



--PROCEDIMIENTO ALMACENADO CONSULTAR POR NOMBRE
CREATE PROCEDURE SP_CONSULTACLIENTE
@nombre varchar(100),
AS
SELECT *
FROM cliente
WHERE nombre LIKE '%Nombre%';
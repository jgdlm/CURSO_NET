--CONSULTAS
--1�) Consultar las Cuentas de los clientes cuyo Apellido empiece por A
SELECT *
FROM CUENTA INNER JOIN CLIENTE
ON CUENTA.IDCLIENTE = CLIENTE.IDCLIENTE
WHERE APELLIDOS LIKE 'A%'


--2�)Consultar todos los movimientos de las Cuentas en Divisa EURO del Cliente cuyos APELLIDOS es PEREZ
SELECT *
FROM MOVIMIENTO INNER JOIN CUENTA
ON MOVIMIENTO.IDCUENTA=CUENTA.IDCUENTA
INNER JOIN CLIENTE 
ON CUENTA.IDCLIENTE=CLIENTE.IDCLIENTE
WHERE APELLIDOS LIKE 'PEREZ'

--3�)Consultar todos los movimientos de las Cuentas del Cliente PEREZ en EUROS(Aunque tenga cuentas en otras divisas) Ordenados por el n�mero de Cuenta
SELECT *




--4�)Consultar los Movimientos de PEREZ y los de RODRIGUEZ



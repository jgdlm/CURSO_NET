--PROCEDIMIENTO ALMACENADO BUSCA POR C�DIGO DE ALUMNO
ALTER PROCEDURE buscaCodigo
@C�digo int
AS
SELECT *
FROM Alumno
WHERE @C�digo = C�digo;

EXEC buscaCodigo 12;
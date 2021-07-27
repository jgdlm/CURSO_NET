--CREO LAS TABLAS CON SUS PRIMARY KEY
CREATE TABLE Alumno(
Código int PRIMARY KEY Identity NOT NULL,
Nombre nvarchar(30) NULL,
DNI nvarchar(10) NOT NULL,
Turno nvarchar(10) NULL, 
Sexo nvarchar(10) NULL,
Repetidor bit,
Modulo nvarchar(10) NOT NULL,
Especialidad  nvarchar(25) NULL
)

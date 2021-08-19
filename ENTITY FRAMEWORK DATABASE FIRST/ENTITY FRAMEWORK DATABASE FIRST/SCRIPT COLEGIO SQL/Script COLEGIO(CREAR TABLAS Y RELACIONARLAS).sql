USE COLEGIO
GO

CREATE TABLE Alumnos(
Id int PRIMARY KEY NOT NULL,
Nombre varchar(50) NULL,
Edad varchar(50) NULL,
Nota varchar(50)NULL,
Idprofesor int NULL
);
GO

CREATE TABLE Profesores(
Id int PRIMARY KEY NOT NULL,
Nombre varchar(50) NULL,
Especialidad varchar(50) NULL
);
GO

--RELACIONES ENTRE LAS TABLAS
-- ALUMNOS CON PROFESORES
ALTER TABLE Alumnos ADD CONSTRAINT fk_Alumnos
FOREIGN KEY (Idprofesor)
REFERENCES Profesores (Id);

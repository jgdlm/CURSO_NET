USE [HUCANET2]
GO

CREATE TABLE [dbo].[Enfermo](
	[Inscripcion] [int] PRIMARY KEY NOT NULL,
	[Nombre y Apellido] [varchar](50) NULL,
	[Sexo] [varchar](6) NULL,
	[Fecha] [datetime] NULL,
	[Direccion] [varchar](50) NULL,
	[Numero de la SS] [int] NULL,
	CONSTRAINT chk_Sexo CHECK(Sexo='Hombre' OR Sexo='Mujer')
); 
GO

INSERT INTO Enfermo
VALUES
(1,'Rosa García','Mujer','19840313','Gijón',09431305),
(2,'Juan De La Cruz','Hombre','19661021','La Corredoria',10431309);
GO



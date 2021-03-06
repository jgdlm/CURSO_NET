USE [LINQSQL]
GO
/****** Object:  Table [dbo].[CLientes]    Script Date: 22/07/2021 16:25:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLientes](
	[Nombre] [varchar](50) NOT NULL,
	[Apellido1] [varchar](50) NOT NULL,
	[Apellido2] [varchar](50) NOT NULL,
	[Telefono] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Buscarcliente]    Script Date: 22/07/2021 16:25:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Buscarcliente]
@Nombre varchar(50)
AS
SELECT *
FROM CLientes
WHERE Nombre LIKE '%' +@Nombre+'%'
GO
/****** Object:  StoredProcedure [dbo].[EliminarCliente]    Script Date: 22/07/2021 16:25:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarCliente]
@Nombre varchar(50)
AS
DELETE FROM CLientes
WHERE @Nombre=Nombre
GO
/****** Object:  StoredProcedure [dbo].[insertarcliente]    Script Date: 22/07/2021 16:25:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertarcliente]
@Nombre varchar(50),
@Apellido1 varchar(50),
@Apellido2 varchar(50),
@telefono varchar(50)
AS
INSERT INTO CLientes(Nombre,Apellido1,Apellido2,Telefono)
VALUES(@Nombre,@Apellido1,@Apellido2,@Telefono)
GO
/****** Object:  StoredProcedure [dbo].[ListarClientes]    Script Date: 22/07/2021 16:25:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarClientes]
AS
SELECT * FROM CLientes;
GO
/****** Object:  StoredProcedure [dbo].[Modificarcliente]    Script Date: 22/07/2021 16:25:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Modificarcliente]
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
GO

USE [SIMULACROMARTESSQL]
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 29/07/2021 20:14:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cliente](
	[id] [int] NOT NULL,
	[nombre] [varchar](100) NULL,
	[apellido1] [varchar](100) NULL,
	[apellido2] [varchar](100) NULL,
	[ciudad] [varchar](100) NULL,
	[categoria] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[comercial]    Script Date: 29/07/2021 20:14:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[comercial](
	[id] [int] NOT NULL,
	[nombre] [varchar](100) NULL,
	[apellido1] [varchar](100) NULL,
	[apellido2] [varchar](100) NULL,
	[ciudad] [varchar](100) NULL,
	[comision] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pedido]    Script Date: 29/07/2021 20:14:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pedido](
	[id] [int] NOT NULL,
	[cantidad] [decimal](18, 2) NULL,
	[fecha] [date] NULL,
	[id_cliente] [int] NULL,
	[id_comercial] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[cliente] ([id], [nombre], [apellido1], [apellido2], [ciudad], [categoria]) VALUES (1, N'Wee', N'ee', N'yy', N'hh', 200)
INSERT [dbo].[cliente] ([id], [nombre], [apellido1], [apellido2], [ciudad], [categoria]) VALUES (2, N'Adela', N'Salas', N'Díaz', N'Granada', 200)
INSERT [dbo].[cliente] ([id], [nombre], [apellido1], [apellido2], [ciudad], [categoria]) VALUES (3, N'Adolfo', N'Rubio', N'Flores', N'Sevilla', NULL)
INSERT [dbo].[cliente] ([id], [nombre], [apellido1], [apellido2], [ciudad], [categoria]) VALUES (4, N'Adrián', N'Suárez', NULL, N'Jaén', 300)
INSERT [dbo].[cliente] ([id], [nombre], [apellido1], [apellido2], [ciudad], [categoria]) VALUES (5, N'Marcos', N'Loyola', N'Méndez', N'Almería', 200)
INSERT [dbo].[cliente] ([id], [nombre], [apellido1], [apellido2], [ciudad], [categoria]) VALUES (6, N'María', N'Santana', N'Moreno', N'Cádiz', 100)
INSERT [dbo].[cliente] ([id], [nombre], [apellido1], [apellido2], [ciudad], [categoria]) VALUES (7, N'Pilar', N'Ruiz', NULL, N'Sevilla', 300)
INSERT [dbo].[cliente] ([id], [nombre], [apellido1], [apellido2], [ciudad], [categoria]) VALUES (8, N'Pepe', N'Ruiz', N'Santana', N'Huelva', 200)
INSERT [dbo].[cliente] ([id], [nombre], [apellido1], [apellido2], [ciudad], [categoria]) VALUES (9, N'Guillermo', N'López', N'Gómez', N'Granada', 225)
INSERT [dbo].[cliente] ([id], [nombre], [apellido1], [apellido2], [ciudad], [categoria]) VALUES (10, N'Daniel', N'Santana', N'Loyola', N'Sevilla', 125)
GO
INSERT [dbo].[comercial] ([id], [nombre], [apellido1], [apellido2], [ciudad], [comision]) VALUES (1, N'Daniel', N'Sáez', N'Vega', N'Almería', CAST(0.15 AS Decimal(18, 2)))
INSERT [dbo].[comercial] ([id], [nombre], [apellido1], [apellido2], [ciudad], [comision]) VALUES (2, N'Juan', N'Gómez', N'López', N'Granada', CAST(0.13 AS Decimal(18, 2)))
INSERT [dbo].[comercial] ([id], [nombre], [apellido1], [apellido2], [ciudad], [comision]) VALUES (3, N'Diego', N'Flores', N'Salas', N'Sevilla', CAST(0.11 AS Decimal(18, 2)))
INSERT [dbo].[comercial] ([id], [nombre], [apellido1], [apellido2], [ciudad], [comision]) VALUES (4, N'Marta', N'Herrera', N'Gil', N'Jaén', CAST(0.14 AS Decimal(18, 2)))
INSERT [dbo].[comercial] ([id], [nombre], [apellido1], [apellido2], [ciudad], [comision]) VALUES (5, N'Antonio', N'Carretero', N'Ortega', N'Cádiz', CAST(0.12 AS Decimal(18, 2)))
INSERT [dbo].[comercial] ([id], [nombre], [apellido1], [apellido2], [ciudad], [comision]) VALUES (6, N'Manuel', N'Domínguez', N'Hernández', N'Huelva', CAST(0.13 AS Decimal(18, 2)))
INSERT [dbo].[comercial] ([id], [nombre], [apellido1], [apellido2], [ciudad], [comision]) VALUES (7, N'Antonio', N'Vega', N'Hernández', N'Salamanca', CAST(0.11 AS Decimal(18, 2)))
INSERT [dbo].[comercial] ([id], [nombre], [apellido1], [apellido2], [ciudad], [comision]) VALUES (8, N'Alfredo', N'Ruiz', N'Flores', N'Oviedo', CAST(0.05 AS Decimal(18, 2)))
GO
INSERT [dbo].[pedido] ([id], [cantidad], [fecha], [id_cliente], [id_comercial]) VALUES (1, CAST(150.50 AS Decimal(18, 2)), CAST(N'2017-10-05' AS Date), 5, 2)
INSERT [dbo].[pedido] ([id], [cantidad], [fecha], [id_cliente], [id_comercial]) VALUES (2, CAST(270.65 AS Decimal(18, 2)), CAST(N'2016-09-10' AS Date), 1, 5)
INSERT [dbo].[pedido] ([id], [cantidad], [fecha], [id_cliente], [id_comercial]) VALUES (3, CAST(65.26 AS Decimal(18, 2)), CAST(N'2017-10-05' AS Date), 2, 1)
INSERT [dbo].[pedido] ([id], [cantidad], [fecha], [id_cliente], [id_comercial]) VALUES (4, CAST(110.50 AS Decimal(18, 2)), CAST(N'2016-08-17' AS Date), 8, 3)
INSERT [dbo].[pedido] ([id], [cantidad], [fecha], [id_cliente], [id_comercial]) VALUES (5, CAST(948.50 AS Decimal(18, 2)), CAST(N'2017-09-10' AS Date), 5, 2)
INSERT [dbo].[pedido] ([id], [cantidad], [fecha], [id_cliente], [id_comercial]) VALUES (6, CAST(2400.60 AS Decimal(18, 2)), CAST(N'2016-07-27' AS Date), 7, 1)
INSERT [dbo].[pedido] ([id], [cantidad], [fecha], [id_cliente], [id_comercial]) VALUES (7, CAST(5760.00 AS Decimal(18, 2)), CAST(N'2015-09-10' AS Date), 2, 1)
INSERT [dbo].[pedido] ([id], [cantidad], [fecha], [id_cliente], [id_comercial]) VALUES (8, CAST(1983.43 AS Decimal(18, 2)), CAST(N'2017-10-10' AS Date), 4, 6)
INSERT [dbo].[pedido] ([id], [cantidad], [fecha], [id_cliente], [id_comercial]) VALUES (9, CAST(2480.40 AS Decimal(18, 2)), CAST(N'2016-10-10' AS Date), 8, 3)
INSERT [dbo].[pedido] ([id], [cantidad], [fecha], [id_cliente], [id_comercial]) VALUES (10, CAST(250.45 AS Decimal(18, 2)), CAST(N'2015-06-27' AS Date), 8, 2)
INSERT [dbo].[pedido] ([id], [cantidad], [fecha], [id_cliente], [id_comercial]) VALUES (11, CAST(75.29 AS Decimal(18, 2)), CAST(N'2016-08-17' AS Date), 3, 7)
INSERT [dbo].[pedido] ([id], [cantidad], [fecha], [id_cliente], [id_comercial]) VALUES (12, CAST(3045.60 AS Decimal(18, 2)), CAST(N'2017-04-25' AS Date), 2, 1)
INSERT [dbo].[pedido] ([id], [cantidad], [fecha], [id_cliente], [id_comercial]) VALUES (13, CAST(545.75 AS Decimal(18, 2)), CAST(N'2019-01-25' AS Date), 6, 1)
INSERT [dbo].[pedido] ([id], [cantidad], [fecha], [id_cliente], [id_comercial]) VALUES (14, CAST(145.82 AS Decimal(18, 2)), CAST(N'2017-02-02' AS Date), 6, 1)
INSERT [dbo].[pedido] ([id], [cantidad], [fecha], [id_cliente], [id_comercial]) VALUES (15, CAST(370.85 AS Decimal(18, 2)), CAST(N'2019-03-11' AS Date), 1, 5)
INSERT [dbo].[pedido] ([id], [cantidad], [fecha], [id_cliente], [id_comercial]) VALUES (16, CAST(2389.23 AS Decimal(18, 2)), CAST(N'2019-03-11' AS Date), 1, 5)
GO
ALTER TABLE [dbo].[pedido]  WITH CHECK ADD  CONSTRAINT [fk_Ped] FOREIGN KEY([id_comercial])
REFERENCES [dbo].[comercial] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[pedido] CHECK CONSTRAINT [fk_Ped]
GO
ALTER TABLE [dbo].[pedido]  WITH CHECK ADD  CONSTRAINT [fk_Pedido] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[cliente] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[pedido] CHECK CONSTRAINT [fk_Pedido]
GO
/****** Object:  StoredProcedure [dbo].[SP_ALTACLIENTE]    Script Date: 29/07/2021 20:14:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ALTACLIENTE]
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
/****** Object:  StoredProcedure [dbo].[SP_CONSULTACLIENTE]    Script Date: 29/07/2021 20:14:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONSULTACLIENTE]
@id int
AS
SELECT *
FROM cliente
WHERE id=@id;
GO
/****** Object:  StoredProcedure [dbo].[SP_ELIMINARCLIENTE]    Script Date: 29/07/2021 20:14:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ELIMINARCLIENTE]
@id int
AS
DELETE 
FROM cliente
WHERE id=@id
GO
/****** Object:  StoredProcedure [dbo].[SP_MODIFICACLIENTE]    Script Date: 29/07/2021 20:14:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_MODIFICACLIENTE]
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
GO

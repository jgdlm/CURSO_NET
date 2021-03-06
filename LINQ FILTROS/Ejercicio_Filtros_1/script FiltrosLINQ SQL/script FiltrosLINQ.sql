USE [FiltrosLINQ]
GO
/****** Object:  Table [dbo].[datosjueves]    Script Date: 06/08/2021 16:59:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[datosjueves](
	[Id] [int] NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Apellido] [nvarchar](50) NULL,
	[Fecha_Insc] [datetime] NULL,
	[Fecha_Cont] [datetime] NULL,
	[Curso] [nvarchar](50) NULL,
 CONSTRAINT [PK_datosjueves] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[datosjueves] ([Id], [Nombre], [Apellido], [Fecha_Insc], [Fecha_Cont], [Curso]) VALUES (1, N'Manuel', N'Gonzalez', CAST(N'2021-01-01T00:00:00.000' AS DateTime), CAST(N'2020-12-31T00:00:00.000' AS DateTime), N'Programacion de automatas')
INSERT [dbo].[datosjueves] ([Id], [Nombre], [Apellido], [Fecha_Insc], [Fecha_Cont], [Curso]) VALUES (2, N'Vanesa', N'Gonzalez Rodriguez', CAST(N'2019-01-01T00:00:00.000' AS DateTime), CAST(N'2019-06-01T00:00:00.000' AS DateTime), N'JAVA')
INSERT [dbo].[datosjueves] ([Id], [Nombre], [Apellido], [Fecha_Insc], [Fecha_Cont], [Curso]) VALUES (3, N'Saul', N'Otero', CAST(N'2020-05-01T00:00:00.000' AS DateTime), CAST(N'2020-12-31T00:00:00.000' AS DateTime), N'UNITY')
INSERT [dbo].[datosjueves] ([Id], [Nombre], [Apellido], [Fecha_Insc], [Fecha_Cont], [Curso]) VALUES (4, N'Aleida', N'Rodriguez Garcia', CAST(N'2018-01-01T00:00:00.000' AS DateTime), CAST(N'2018-05-01T00:00:00.000' AS DateTime), N'ARDUINO')
INSERT [dbo].[datosjueves] ([Id], [Nombre], [Apellido], [Fecha_Insc], [Fecha_Cont], [Curso]) VALUES (5, N'Ines', N'Mallada', CAST(N'2021-03-01T00:00:00.000' AS DateTime), CAST(N'2020-05-07T00:00:00.000' AS DateTime), N'Sumiller')
GO

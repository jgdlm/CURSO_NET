USE [HOSPITAL SQL]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 02/08/2021 17:14:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[Id] [int] NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
	[Apellido] [varchar](20) NOT NULL,
	[Edad] [int] NOT NULL,
	[Casado] [bit] NOT NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Empleados] ([Id], [Nombre], [Apellido], [Edad], [Casado]) VALUES (1, N'JUAN', N'GONZALEZ', 34, 0)
INSERT [dbo].[Empleados] ([Id], [Nombre], [Apellido], [Edad], [Casado]) VALUES (2, N'MANUELA', N'CABAL', 44, 1)
INSERT [dbo].[Empleados] ([Id], [Nombre], [Apellido], [Edad], [Casado]) VALUES (3, N'MARTA', N'GARCIA', 43, 1)
GO

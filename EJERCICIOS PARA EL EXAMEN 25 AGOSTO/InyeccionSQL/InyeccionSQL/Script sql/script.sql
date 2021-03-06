USE [PruebaINyeccionsql]
GO
/****** Object:  Table [dbo].[PERSONAS]    Script Date: 26/07/2021 18:41:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PERSONAS](
	[ID] [int] NOT NULL,
	[NOMBRE] [varchar](50) NULL,
	[EDAD] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

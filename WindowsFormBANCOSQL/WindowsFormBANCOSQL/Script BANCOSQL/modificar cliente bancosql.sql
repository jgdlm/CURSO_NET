USE [BANCOSQL]
GO
/****** Object:  StoredProcedure [dbo].[ModificarCliente]    Script Date: 23/07/2021 18:19:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ModificarCliente]
@IDCLIENTE varchar(5),
@APELLIDOS varchar(30),
@NOMBRES varchar(30)
AS
UPDATE CLIENTE
SET 
IDCLIENTE=@IDCLIENTE,
APELLIDOS=@APELLIDOS,
NOMBRES=@NOMBRES
WHERE NOMBRES=@NOMBRES

EXEC ModificarCliente 'fffffffff','ffffffffff','r';
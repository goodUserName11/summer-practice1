USE [DataStotageAndExchangeDB]
GO

/****** Object:  UserDefinedFunction [dbo].[GetFilesFunc]    Script Date: 05.07.2021 13:56:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[GetFilesFunc] 
(	
	@fileName nvarchar(20) = ''
)

RETURNS TABLE 
AS
RETURN 
(
	SELECT * FROM UsersFiles
	WHERE FileName LIKE '%'+ @fileName +'%'
)
GO


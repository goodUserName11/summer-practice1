USE [DataStotageAndExchangeDB]
GO

/****** Object:  UserDefinedFunction [dbo].[GetUsersFunc]    Script Date: 05.07.2021 13:58:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[GetUsersFunc] 
(	
		@nickname nvarchar(20) = ''
)

RETURNS TABLE 
AS
RETURN 
(
	SELECT * FROM SimpleUsers
	WHERE Nickname LIKE '%'+ @nickname +'%'
)
GO


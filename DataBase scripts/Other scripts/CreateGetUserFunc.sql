USE [DataStotageAndExchangeDB]
GO

/****** Object:  UserDefinedFunction [dbo].[GetUserFunc]    Script Date: 05.07.2021 13:57:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[GetUserFunc] 
(	
	-- Add the parameters for the function here
	@login nvarchar(20),
	@password nvarchar(20)
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT ID,Nickname 
	FROM Users
	WHERE [Login] = @login AND [Password] = @password
	COLLATE SQL_Latin1_General_CP1_CS_AS
)
GO


USE [DataStotageAndExchangeDB]
GO

/****** Object:  UserDefinedFunction [dbo].[GetUserInfoFunc]    Script Date: 05.07.2021 13:57:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[GetUserInfoFunc] 
(	
	-- Add the parameters for the function here
	@userId int
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT * 
	FROM [PublicUsersData]
	WHERE ID = @userId
)
GO


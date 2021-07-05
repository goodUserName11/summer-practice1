USE [DataStotageAndExchangeDB]
GO

/****** Object:  UserDefinedFunction [dbo].[GetFileData]    Script Date: 05.07.2021 13:56:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[GetFileData]
(
	@id int
)
RETURNS varbinary(max)
AS
BEGIN
	-- Declare the return variable here
	DECLARE @binData varbinary(max)

	-- Add the T-SQL statements to compute the return value here
	SELECT @binData = FileData 
	FROM Files
	WHERE ID = @id

	-- Return the result of the function
	RETURN @binData

END
GO


USE [DataStotageAndExchangeDB]
GO

/****** Object:  StoredProcedure [dbo].[AddStartRoles]    Script Date: 09.07.2021 12:28:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AddStartRoles] 
	-- Add the parameters for the stored procedure here
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO UserRoles
		(RoleName)
	VALUES
		('Admin'), ('User')
END
GO


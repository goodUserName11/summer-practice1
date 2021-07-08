USE [DataStotageAndExchangeDB]
GO
/****** Object:  StoredProcedure [dbo].[AddFile]    Script Date: 08.07.2021 23:36:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddRole] 
	-- Add the parameters for the stored procedure here
	@roleName nvarchar(20)
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO UserRoles
		(RoleName)
	VALUES
		(@roleName)
END
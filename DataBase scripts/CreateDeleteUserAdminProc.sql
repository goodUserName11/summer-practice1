USE [DataStotageAndExchangeDB]
GO

/****** Object:  StoredProcedure [dbo].[DeleteUserAdmin]    Script Date: 05.07.2021 13:55:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DeleteUserAdmin] 
	-- Add the parameters for the stored procedure here
	@deleteUserId int,
	@userId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @roleId int

	SELECT @roleId = RoleID FROM Users
	WHERE ID = @userId

    -- Insert statements for procedure here
	DELETE Users
	WHERE ID = @deleteUserId AND @roleId = 1
END
GO


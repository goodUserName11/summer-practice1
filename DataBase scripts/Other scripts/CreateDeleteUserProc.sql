USE [DataStotageAndExchangeDB]
GO
/****** Object:  StoredProcedure [dbo].[DeleteUser]    Script Date: 05.07.2021 19:12:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[DeleteUser] 
	-- Add the parameters for the stored procedure here
	@userId int,
	@deleterId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @roleId int
	SELECT @roleId = RoleID FROM PublicUsersData
	WHERE ID = @deleterId

    -- Insert statements for procedure here
	DELETE Users
	WHERE ID = @userId AND (@deleterId = @userId OR @roleId = 1)
END

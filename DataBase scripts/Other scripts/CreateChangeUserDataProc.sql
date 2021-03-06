USE [DataStotageAndExchangeDB]
GO

/****** Object:  StoredProcedure [dbo].[ChangeUserData]    Script Date: 08.07.2021 22:03:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ChangeUserData] 
	-- Add the parameters for the stored procedure here
	@userId int,
	@changerId int,
	@firstname nvarchar(15),
	@lastname nvarchar(15),
	@newNickname nvarchar(20),
	@description nvarchar(max)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	-- SET NOCOUNT ON;

	DECLARE @roleId int
	SELECT @roleId = RoleID FROM PublicUsersData
	WHERE ID = @changerId

    -- Insert statements for procedure here
	UPDATE Users
	SET Nickname = @newNickname,
		FirstName = @firstname,
		LastName = @lastname,
		UserDescription = @description
	WHERE ID = @userId AND (@userId = @changerId OR @roleId = 1)
END
GO


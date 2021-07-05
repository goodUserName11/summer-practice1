USE [DataStotageAndExchangeDB]
GO
/****** Object:  StoredProcedure [dbo].[ChangeUserPassword]    Script Date: 05.07.2021 19:13:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ChangeUserPassword] 
	-- Add the parameters for the stored procedure here
	@userId int,
	@changerId int,
	@newPassword nvarchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Users
	SET [Password] = @newPassword
	WHERE ID = @userId AND @changerId = @userId
END

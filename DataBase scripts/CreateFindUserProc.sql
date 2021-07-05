USE [DataStotageAndExchangeDB]
GO

/****** Object:  StoredProcedure [dbo].[FindUser]    Script Date: 05.07.2021 13:59:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[FindUser] 
	-- Add the parameters for the stored procedure here
	@login nvarchar(20),
	@password nvarchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @user int
    -- Insert statements for procedure here
	SELECT @user = COUNT([Login]) 
	FROM Users
	WHERE [Login] = @login AND [Password] = @password

	RETURN @user
END
GO


USE [DataStotageAndExchangeDB]
GO

/****** Object:  StoredProcedure [dbo].[AddUser]    Script Date: 05.07.2021 13:52:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AddUser] 
	-- Add the parameters for the stored procedure here
	@login nvarchar(20),
	@nickname nvarchar(20),
	@password nvarchar(20)
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO Users
		([Login], nickname, [password])
	VALUES
		(@login,@nickname,@password)
END
GO


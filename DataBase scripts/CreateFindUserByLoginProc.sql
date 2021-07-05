USE [DataStotageAndExchangeDB]
GO

/****** Object:  StoredProcedure [dbo].[FindUserByLogin]    Script Date: 05.07.2021 14:00:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[FindUserByLogin] 
	-- Add the parameters for the stored procedure here
	@login nvarchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	--DECLARE @user int;

    -- Insert statements for procedure here
	SELECT COUNT([Login]) 
	FROM Users
	WHERE [Login] = @login
	COLLATE SQL_Latin1_General_CP1_CS_AS

	--RETURN @user
END
GO


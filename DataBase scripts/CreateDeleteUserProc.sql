USE [DataStotageAndExchangeDB]
GO

/****** Object:  StoredProcedure [dbo].[DeleteUser]    Script Date: 05.07.2021 13:55:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DeleteUser] 
	-- Add the parameters for the stored procedure here
	@userId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE Users
	WHERE ID = @userId
END
GO


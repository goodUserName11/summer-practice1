USE [DataStotageAndExchangeDB]
GO

/****** Object:  StoredProcedure [dbo].[DeleteFile]    Script Date: 05.07.2021 13:55:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DeleteFile] 
	-- Add the parameters for the stored procedure here
	@fileId int,
	@userId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @roleId int
    -- Insert statements for procedure here
	SELECT @roleId = RoleID FROM Users
	WHERE ID = @userId

	DELETE Files
	WHERE ID = @fileId AND (CreatorID = @userId OR @roleId = 1)
END
GO


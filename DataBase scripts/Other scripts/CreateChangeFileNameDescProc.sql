USE [DataStotageAndExchangeDB]
GO

/****** Object:  StoredProcedure [dbo].[ChangeFileNameDesc]    Script Date: 08.07.2021 22:03:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ChangeFileNameDesc] 
	-- Add the parameters for the stored procedure here
	@fileId int,
	@userId int,
	@fileName nvarchar(20),
	@description nvarchar(200)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	-- SET NOCOUNT ON;

	DECLARE @roleId int
    -- Insert statements for procedure here
	SELECT @roleId = RoleID FROM Users
	WHERE ID = @userId

    -- Insert statements for procedure here
	UPDATE Files
	SET FileName = @fileName,
		FileDescription = @description
	WHERE ID = @fileId AND (CreatorID = @userId OR @roleId = 1)
END
GO


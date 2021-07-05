USE [DataStotageAndExchangeDB]
GO

/****** Object:  StoredProcedure [dbo].[AddFile]    Script Date: 05.07.2021 13:53:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AddFile] 
	-- Add the parameters for the stored procedure here
	@fileName nvarchar(20),
	@fileData varbinary(MAX),
	@fileDescription nvarchar(200),
	@creatorID int
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO Files
		([FileName], FileData, FileDescription, CreatorID)
	VALUES
		(@fileName,@fileData,@fileDescription,@creatorID)
END
GO


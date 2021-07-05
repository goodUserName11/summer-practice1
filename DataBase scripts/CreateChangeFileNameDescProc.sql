USE [DataStotageAndExchangeDB]
GO

/****** Object:  StoredProcedure [dbo].[ChangeFileNameDesc]    Script Date: 05.07.2021 13:53:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ChangeFileNameDesc] 
	-- Add the parameters for the stored procedure here
	@fileId int,
	@fileName nvarchar(20),
	@description nvarchar(200)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Files
	SET FileName = @fileName,
		FileDescription = @description
	WHERE ID = @fileId
END
GO


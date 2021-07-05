USE [DataStotageAndExchangeDB]
GO

/****** Object:  View [dbo].[UsersFiles]    Script Date: 05.07.2021 13:51:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[UsersFiles]
AS
SELECT Files.ID, FileName, Users.Nickname AS Adder, Users.ID AS AdderID, Files.FileDescription AS Description,
Files.AddingDate
FROM Files
JOIN Users
	ON Users.ID = Files.CreatorID
GO


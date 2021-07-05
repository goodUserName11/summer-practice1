USE [DataStotageAndExchangeDB]
GO

/****** Object:  View [dbo].[SimpleUsers]    Script Date: 05.07.2021 13:51:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[SimpleUsers]
AS
SELECT ID,Nickname
FROM PublicUsersData
GO


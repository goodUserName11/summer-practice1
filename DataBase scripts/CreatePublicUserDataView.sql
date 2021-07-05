USE [DataStotageAndExchangeDB]
GO

/****** Object:  View [dbo].[PublicUsersData]    Script Date: 05.07.2021 13:49:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[PublicUsersData]
AS
SELECT Users.ID, Nickname, FirstName, LastName,
UserDescription AS Description,
RegistrationDate, RoleID
FROM Users
JOIN UserRoles
	ON Users.RoleID = UserRoles.ID
GO


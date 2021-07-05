USE [DataStotageAndExchangeDB]
GO

/****** Object:  View [dbo].[RolesUsers]    Script Date: 05.07.2021 13:50:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[RolesUsers]
AS
SELECT Users.ID,RoleID,RoleName
FROM Users
JOIN UserRoles
	ON Users.RoleID = UserRoles.ID
GO


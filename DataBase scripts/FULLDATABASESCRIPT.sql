USE [master]
GO
/****** Object:  Database [DataStotageAndExchangeDB]    Script Date: 09.07.2021 12:30:59 ******/
CREATE DATABASE [DataStotageAndExchangeDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DataStotageAndExchange_var4', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DataStotageAndExchange_var4.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DataStotageAndExchange_var4_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DataStotageAndExchange_var4_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DataStotageAndExchangeDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DataStotageAndExchangeDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DataStotageAndExchangeDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DataStotageAndExchangeDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DataStotageAndExchangeDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DataStotageAndExchangeDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DataStotageAndExchangeDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [DataStotageAndExchangeDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DataStotageAndExchangeDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DataStotageAndExchangeDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DataStotageAndExchangeDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DataStotageAndExchangeDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DataStotageAndExchangeDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DataStotageAndExchangeDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DataStotageAndExchangeDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DataStotageAndExchangeDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DataStotageAndExchangeDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DataStotageAndExchangeDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DataStotageAndExchangeDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DataStotageAndExchangeDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DataStotageAndExchangeDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DataStotageAndExchangeDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DataStotageAndExchangeDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DataStotageAndExchangeDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DataStotageAndExchangeDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DataStotageAndExchangeDB] SET  MULTI_USER 
GO
ALTER DATABASE [DataStotageAndExchangeDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DataStotageAndExchangeDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DataStotageAndExchangeDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DataStotageAndExchangeDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DataStotageAndExchangeDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DataStotageAndExchangeDB] SET QUERY_STORE = OFF
GO
USE [DataStotageAndExchangeDB]
GO
/****** Object:  UserDefinedFunction [dbo].[GetFileData]    Script Date: 09.07.2021 12:30:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetFileData]
(
	@id int
)
RETURNS varbinary(max)
AS
BEGIN
	-- Declare the return variable here
	DECLARE @binData varbinary(max)

	-- Add the T-SQL statements to compute the return value here
	SELECT @binData = FileData 
	FROM Files
	WHERE ID = @id

	-- Return the result of the function
	RETURN @binData

END
GO
/****** Object:  Table [dbo].[UserRoles]    Script Date: 09.07.2021 12:30:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRoles](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_UsersRoles] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 09.07.2021 12:30:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](20) NOT NULL,
	[Nickname] [nvarchar](20) NOT NULL,
	[FirstName] [nvarchar](15) NULL,
	[LastName] [nvarchar](15) NULL,
	[Password] [nvarchar](20) NOT NULL,
	[UserDescription] [nvarchar](max) NULL,
	[RegistrationDate] [date] NOT NULL,
	[RoleID] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_Users_Login] UNIQUE NONCLUSTERED 
(
	[Login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[PublicUsersData]    Script Date: 09.07.2021 12:30:59 ******/
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
/****** Object:  View [dbo].[SimpleUsers]    Script Date: 09.07.2021 12:30:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[SimpleUsers]
AS
SELECT ID,Nickname
FROM PublicUsersData
GO
/****** Object:  UserDefinedFunction [dbo].[GetUsersFunc]    Script Date: 09.07.2021 12:30:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetUsersFunc] 
(	
		@nickname nvarchar(20) = ''
)

RETURNS TABLE 
AS
RETURN 
(
	SELECT * FROM SimpleUsers
	WHERE Nickname LIKE '%'+ @nickname +'%'
)
GO
/****** Object:  Table [dbo].[Files]    Script Date: 09.07.2021 12:30:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Files](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FileName] [nvarchar](20) NOT NULL,
	[FileData] [varbinary](max) NULL,
	[FileDescription] [nvarchar](200) NULL,
	[AddingDate] [datetime] NOT NULL,
	[CreatorID] [int] NOT NULL,
 CONSTRAINT [PK_Files] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[UsersFiles]    Script Date: 09.07.2021 12:30:59 ******/
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
/****** Object:  UserDefinedFunction [dbo].[GetFilesFunc]    Script Date: 09.07.2021 12:30:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetFilesFunc] 
(	
	@fileName nvarchar(20) = ''
)

RETURNS TABLE 
AS
RETURN 
(
	SELECT * FROM UsersFiles
	WHERE FileName LIKE '%'+ @fileName +'%'
)
GO
/****** Object:  UserDefinedFunction [dbo].[GetUserFunc]    Script Date: 09.07.2021 12:30:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetUserFunc] 
(	
	-- Add the parameters for the function here
	@login nvarchar(20),
	@password nvarchar(20)
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT ID,Nickname 
	FROM Users
	WHERE [Login] = @login AND [Password] = @password
	COLLATE SQL_Latin1_General_CP1_CS_AS
)
GO
/****** Object:  View [dbo].[RolesUsers]    Script Date: 09.07.2021 12:30:59 ******/
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
/****** Object:  UserDefinedFunction [dbo].[GetUserInfoFunc]    Script Date: 09.07.2021 12:30:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetUserInfoFunc] 
(	
	-- Add the parameters for the function here
	@userId int
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT * 
	FROM [PublicUsersData]
	WHERE ID = @userId
)
GO
/****** Object:  UserDefinedFunction [dbo].[GetUserInfoFunc1]    Script Date: 09.07.2021 12:30:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetUserInfoFunc1] 
(	
	-- Add the parameters for the function here
	@userId int,
	@getterId int
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT * 
	FROM [PublicUsersData]
	WHERE ID = @userId AND (ID = @getterId OR 1 = (
		SELECT PUD.RoleID FROM PublicUsersData AS PUD
		WHERE PUD.ID = @getterId))
)
GO
ALTER TABLE [dbo].[Files] ADD  CONSTRAINT [DF_Files_CreationDate]  DEFAULT (getdate()) FOR [AddingDate]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_UserDescription]  DEFAULT ('Empty') FOR [UserDescription]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_RegistrationDate]  DEFAULT (getdate()) FOR [RegistrationDate]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_RoleID]  DEFAULT ((2)) FOR [RoleID]
GO
ALTER TABLE [dbo].[Files]  WITH CHECK ADD  CONSTRAINT [FK_Files_Users] FOREIGN KEY([CreatorID])
REFERENCES [dbo].[Users] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Files] CHECK CONSTRAINT [FK_Files_Users]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_UsersRoles] FOREIGN KEY([RoleID])
REFERENCES [dbo].[UserRoles] ([ID])
ON UPDATE CASCADE
ON DELETE SET DEFAULT
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_UsersRoles]
GO
/****** Object:  StoredProcedure [dbo].[AddFile]    Script Date: 09.07.2021 12:30:59 ******/
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
/****** Object:  StoredProcedure [dbo].[AddStartRoles]    Script Date: 09.07.2021 12:30:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddStartRoles] 
	-- Add the parameters for the stored procedure here
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO UserRoles
		(RoleName)
	VALUES
		('Admin'), ('User')
END
GO
/****** Object:  StoredProcedure [dbo].[AddUser]    Script Date: 09.07.2021 12:30:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddUser] 
	-- Add the parameters for the stored procedure here
	@login nvarchar(20),
	@nickname nvarchar(20),
	@password nvarchar(20)
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO Users
		([Login], nickname, [password])
	VALUES
		(@login,@nickname,@password)
END
GO
/****** Object:  StoredProcedure [dbo].[ChangeFileNameDesc]    Script Date: 09.07.2021 12:30:59 ******/
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
/****** Object:  StoredProcedure [dbo].[ChangeUserData]    Script Date: 09.07.2021 12:30:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ChangeUserData] 
	-- Add the parameters for the stored procedure here
	@userId int,
	@changerId int,
	@firstname nvarchar(15),
	@lastname nvarchar(15),
	@newNickname nvarchar(20),
	@description nvarchar(max)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	-- SET NOCOUNT ON;

	DECLARE @roleId int
	SELECT @roleId = RoleID FROM PublicUsersData
	WHERE ID = @changerId

    -- Insert statements for procedure here
	UPDATE Users
	SET Nickname = @newNickname,
		FirstName = @firstname,
		LastName = @lastname,
		UserDescription = @description
	WHERE ID = @userId AND (@userId = @changerId OR @roleId = 1)
END
GO
/****** Object:  StoredProcedure [dbo].[ChangeUserPassword]    Script Date: 09.07.2021 12:30:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ChangeUserPassword] 
	-- Add the parameters for the stored procedure here
	@userId int,
	@changerId int,
	@newPassword nvarchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	-- SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Users
	SET [Password] = @newPassword
	WHERE ID = @userId AND @changerId = @userId
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteFile]    Script Date: 09.07.2021 12:30:59 ******/
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
	-- SET NOCOUNT ON;

	DECLARE @roleId int
    -- Insert statements for procedure here
	SELECT @roleId = RoleID FROM Users
	WHERE ID = @userId

	DELETE Files
	WHERE ID = @fileId AND (CreatorID = @userId OR @roleId = 1)
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteUser]    Script Date: 09.07.2021 12:30:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteUser] 
	-- Add the parameters for the stored procedure here
	@userId int,
	@deleterId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	-- SET NOCOUNT ON;

	DECLARE @roleId int
	SELECT @roleId = RoleID FROM PublicUsersData
	WHERE ID = @deleterId

    -- Insert statements for procedure here
	DELETE Users
	WHERE ID = @userId AND (@deleterId = @userId OR @roleId = 1)
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteUserAdmin]    Script Date: 09.07.2021 12:30:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteUserAdmin] 
	-- Add the parameters for the stored procedure here
	@deleteUserId int,
	@userId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	-- SET NOCOUNT ON;

	DECLARE @roleId int

	SELECT @roleId = RoleID FROM Users
	WHERE ID = @userId

    -- Insert statements for procedure here
	DELETE Users
	WHERE ID = @deleteUserId AND @roleId = 1
END
GO
/****** Object:  StoredProcedure [dbo].[FindUser]    Script Date: 09.07.2021 12:30:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FindUser] 
	-- Add the parameters for the stored procedure here
	@login nvarchar(20),
	@password nvarchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @user int
    -- Insert statements for procedure here
	SELECT @user = COUNT([Login]) 
	FROM Users
	WHERE [Login] = @login AND [Password] = @password

	RETURN @user
END
GO
/****** Object:  StoredProcedure [dbo].[FindUserByLogin]    Script Date: 09.07.2021 12:30:59 ******/
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
USE [master]
GO
ALTER DATABASE [DataStotageAndExchangeDB] SET  READ_WRITE 
GO

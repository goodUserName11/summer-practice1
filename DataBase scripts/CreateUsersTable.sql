USE [DataStotageAndExchangeDB]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 05.07.2021 13:12:57 ******/
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

ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_UserDescription]  DEFAULT ('Empty') FOR [UserDescription]
GO

ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_RegistrationDate]  DEFAULT (getdate()) FOR [RegistrationDate]
GO

ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_RoleID]  DEFAULT ((2)) FOR [RoleID]
GO

ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_UsersRoles] FOREIGN KEY([RoleID])
REFERENCES [dbo].[UserRoles] ([ID])
ON UPDATE CASCADE
ON DELETE SET DEFAULT
GO

ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_UsersRoles]
GO


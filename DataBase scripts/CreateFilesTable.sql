USE [DataStotageAndExchangeDB]
GO

/****** Object:  Table [dbo].[Files]    Script Date: 05.07.2021 13:03:01 ******/
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

ALTER TABLE [dbo].[Files] ADD  CONSTRAINT [DF_Files_CreationDate]  DEFAULT (getdate()) FOR [AddingDate]
GO

ALTER TABLE [dbo].[Files]  WITH CHECK ADD  CONSTRAINT [FK_Files_Users] FOREIGN KEY([CreatorID])
REFERENCES [dbo].[Users] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Files] CHECK CONSTRAINT [FK_Files_Users]
GO



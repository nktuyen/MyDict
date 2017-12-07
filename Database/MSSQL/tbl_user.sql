USE [mydict]
GO

/****** Object:  Table [dbo].[tbl_user]    Script Date: 12/7/2017 1:43:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_user](
	[id] [bigint] NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[password] [nvarchar](255) NOT NULL,
	[email] [nvarchar](255) NOT NULL,
	[first_name] [nvarchar](255) NOT NULL,
	[last_name] [nvarchar](255) NULL,
	[birth_day] [smallint] NULL,
	[birth_month] [smallint] NULL,
	[birth_year] [int] NULL,
	[registered_date] [timestamp] NULL,
	[type] [bigint] NOT NULL,
 CONSTRAINT [PK_tbl_user] PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


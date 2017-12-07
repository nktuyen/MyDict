USE [mydict]
GO

/****** Object:  Table [dbo].[tbl_favorite]    Script Date: 12/7/2017 1:43:17 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_favorite](
	[id] [bigint] NOT NULL,
	[vocabulary_id] [bigint] NOT NULL,
	[user_id] [bigint] NOT NULL,
 CONSTRAINT [PK_tbl_favorite] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


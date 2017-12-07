USE [mydict]
GO

/****** Object:  Table [dbo].[tbl_translation]    Script Date: 12/7/2017 1:43:51 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_translation](
	[id] [bigint] NOT NULL,
	[example_id] [bigint] NOT NULL,
	[translation] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_tbl_translation] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [mydict]
GO

/****** Object:  Table [dbo].[tbl_category]    Script Date: 12/7/2017 1:42:14 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_category](
	[id] [bigint] NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[title] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_tbl_category] PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


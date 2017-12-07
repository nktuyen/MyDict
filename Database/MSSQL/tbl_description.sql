USE [mydict]
GO

/****** Object:  Table [dbo].[tbl_description]    Script Date: 12/7/2017 1:42:47 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_description](
	[id] [bigint] NOT NULL,
	[phonetic_id] [bigint] NOT NULL,
	[description] [nvarchar](1024) NOT NULL,
 CONSTRAINT [PK_tbl_description] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


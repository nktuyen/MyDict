USE [mydict]
GO

/****** Object:  Table [dbo].[tbl_example]    Script Date: 12/7/2017 1:43:10 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_example](
	[id] [bigint] NOT NULL,
	[description_id] [bigint] NOT NULL,
	[example] [nvarchar](1024) NOT NULL,
 CONSTRAINT [PK_tbl_example] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


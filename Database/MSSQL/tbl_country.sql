USE [mydict]
GO

/****** Object:  Table [dbo].[tbl_country]    Script Date: 12/8/2017 11:05:38 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_country](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[country_code] [nvarchar](50) NOT NULL,
	[iso_code] [nvarchar](50) NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[title] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_tbl_country_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[iso_code] ASC,
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


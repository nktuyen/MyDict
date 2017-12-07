USE [mydict]
GO

/****** Object:  Table [dbo].[tbl_right]    Script Date: 12/7/2017 1:43:44 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_right](
	[user_id] [bigint] NOT NULL,
	[entity_id] [bigint] NOT NULL,
	[permission_id] [bigint] NOT NULL
) ON [PRIMARY]
GO


/* ---------------------------------------------------- */
/*  Generated by Enterprise Architect Version 12.1 		*/
/*  Created On : 19-Oct-2017 12:12:55 AM 				*/
/*  DBMS       : SQL Server 2012 						*/
/* ---------------------------------------------------- */

/* Drop Tables */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[Phonetic]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [dbo].[Phonetic]
GO

/* Create Tables */

CREATE TABLE [dbo].[Phonetic]
(
	[vocabulary_id] bigint NOT NULL IDENTITY (1, 1),
	[class_id] bigint NOT NULL,
	[phonetic] nvarchar(255) NOT NULL,
	[id] bigint NOT NULL
)
GO

/* Create Primary Keys, Indexes, Uniques, Checks */

ALTER TABLE [dbo].[Phonetic] 
 ADD CONSTRAINT [PK_Phonetic]
	PRIMARY KEY CLUSTERED ([id] ASC)
GO

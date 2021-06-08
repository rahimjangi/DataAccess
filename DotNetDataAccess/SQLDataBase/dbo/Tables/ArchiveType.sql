﻿CREATE TABLE [dbo].[ArchiveType]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Archive] VARCHAR(10) NOT NULL,
	[InsertDate] DATETIME2 NOT NULL DEFAULT GETDATE(), 
    [LastChange] DATETIME2 NULL, 
)
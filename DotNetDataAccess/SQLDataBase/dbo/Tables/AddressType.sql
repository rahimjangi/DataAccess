﻿CREATE TABLE [dbo].[AddressType]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [TypeName] VARBINARY(50) NOT NULL,
	[InsertDate] DATETIME2 NOT NULL DEFAULT GETDATE(), 
    [LastChange] DATETIME2 NULL, 
 
	

)

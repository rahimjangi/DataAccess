CREATE TABLE [dbo].[DeliveryStatus]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[StatusType] VARCHAR(50) NOT NULL,
	[InsertDate]  DATETIME2 (7) DEFAULT (getdate()) NOT NULL,
    [LastChange]  DATETIME2 (7) NULL, 
)

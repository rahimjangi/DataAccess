CREATE TABLE [dbo].[PaymentOptions]
(
	[Id] INT NOT NULL PRIMARY KEY,
    [Brand] NVARCHAR(50) NOT NULL,
    [InsertDate]  DATETIME2 (7) DEFAULT (getdate()) NOT NULL,
    [LastChange]  DATETIME2 (7) NULL, 
)

CREATE TABLE [dbo].[Categories]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CategoryName] NVARCHAR(50) NOT NULL UNIQUE,
	[InsertDate] DATETIME2 NOT NULL DEFAULT GETDATE(), 
    [ModifiedDate] DATETIME2 NULL
)

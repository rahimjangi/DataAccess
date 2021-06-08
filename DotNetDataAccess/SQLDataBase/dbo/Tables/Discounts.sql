CREATE TABLE [dbo].[Discounts]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Description] VARBINARY(50) NOT NULL, 
    [DiscountRate] FLOAT NOT NULL, 
    [InsertDate] DATETIME2 NOT NULL DEFAULT GETDATE(), 
    [ModifiedDate] DATETIME2 NULL
)

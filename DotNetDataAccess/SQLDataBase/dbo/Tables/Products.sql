CREATE TABLE [dbo].[Products]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProductName] VARCHAR(255) NOT NULL, 
    [Description] VARCHAR(255),
    [BrandId] INT NOT NULL, 
    [PriceId] INT NOT NULL, 
    [AvailableCount] INT NOT NULL DEFAULT 0,
    [InsertDate] DATETIME2 NOT NULL DEFAULT GETDATE(), 
    [LastChange] DATETIME2 NULL, 
    CONSTRAINT [FK_Products_Brand] FOREIGN KEY ([BrandId]) REFERENCES [dbo].[Brand]([Id]), 
    CONSTRAINT [FK_Products_Prices] FOREIGN KEY ([PriceId]) REFERENCES [dbo].[Prices]([Id])
)

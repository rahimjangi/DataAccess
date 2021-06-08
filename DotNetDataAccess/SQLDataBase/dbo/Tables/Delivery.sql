CREATE TABLE [dbo].[Delivery]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
    [ShoppingCartId] INT NOT NULL,
    [Status] INT NOT NULL,
    [InsertDate]  DATETIME2 (7) DEFAULT (getdate()) NOT NULL,
    [LastChange]  DATETIME2 (7) NULL, 
    CONSTRAINT [FK_Delivery_ShoppingCart] FOREIGN KEY ([ShoppingCartId]) REFERENCES [ShoppingCart]([Id]), 
    CONSTRAINT [FK_Delivery_DeliveryStatus] FOREIGN KEY ([Status]) REFERENCES [DeliveryStatus]([Id])
)

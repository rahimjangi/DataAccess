CREATE TABLE [dbo].[ShoppingCart]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [OrderId] INT NOT NULL,
    [InsertDate]  DATETIME2 (7) DEFAULT (getdate()) NOT NULL,
    [LastChange]  DATETIME2 (7) NULL,    
    CONSTRAINT [FK_ShoppingCart_Orders] FOREIGN KEY ([OrderId]) REFERENCES [Orders]([Id])
)

CREATE TABLE [dbo].[Orders]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
    [ProductId]int not null,
    [NumberOfItems]int not null,
    [InsertDate]  DATETIME2 (7) DEFAULT (getdate()) NOT NULL,
    [LastChange]  DATETIME2 (7) NULL, 
    CONSTRAINT [FK_Orders_Products] FOREIGN KEY ([ProductId]) REFERENCES [Products]([Id])
)

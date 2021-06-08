CREATE TABLE [dbo].[WatchedList]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[ProductId] INT NOT NULL,
    [InsertDate]  DATETIME2 (7) DEFAULT (getdate()) NOT NULL,
    [LastChange]  DATETIME2 (7) NULL, 
    CONSTRAINT [FK_WatchedLista_Products] FOREIGN KEY ([ProductId]) REFERENCES [Products]([Id]),
)

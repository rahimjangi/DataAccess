CREATE TABLE [dbo].[Brand]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CategoryID] INT NOT NULL , 
    [BrandName] VARCHAR(50) NOT NULL,
    [InsertDate]  DATETIME2 (7) DEFAULT (getdate()) NOT NULL,
    [LastChange]  DATETIME2 (7) NULL,    
    CONSTRAINT [FK_Brand_Categories] FOREIGN KEY ([CategoryID]) REFERENCES [Categories]([Id])

)

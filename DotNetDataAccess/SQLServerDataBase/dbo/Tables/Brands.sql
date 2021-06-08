CREATE TABLE [dbo].[Brands]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CategoryID] INT NOT NULL , 
    [Name] VARCHAR(50) NOT NULL, 
    CONSTRAINT [FK_Brand_Categories] FOREIGN KEY ([CategoryID]) REFERENCES [Categories]([Id])

)

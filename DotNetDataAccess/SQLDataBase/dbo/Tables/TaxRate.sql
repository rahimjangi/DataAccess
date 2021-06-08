CREATE TABLE [dbo].[TaxRate]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[CountryId] INT NOT NULL,
	[CategoryId] INT NOT NULL,
	[Rate] float not null,
	[InsertDate] DATETIME2 NOT NULL DEFAULT GETDATE(), 
    [ModifiedDate] DATETIME2 NULL, 
    CONSTRAINT [FK_TaxRate_Country] FOREIGN KEY ([CountryId]) REFERENCES [Country]([Id]), 
    CONSTRAINT [FK_TaxRate_Categories] FOREIGN KEY ([CategoryId]) REFERENCES [Categories]([Id]), 
)

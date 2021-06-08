CREATE TABLE [dbo].[City]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
    [CountryId]int not null,
    [CityName] varchar(50) not null,
    [InsertDate]  DATETIME2 (7) DEFAULT (getdate()) NOT NULL,
    [LastChange]  DATETIME2 (7) NULL, 
    CONSTRAINT [FK_City_Country] FOREIGN KEY ([CountryId]) REFERENCES [Country]([Id]),
)

CREATE TABLE [dbo].[Country]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	[CountryName]Varchar(50)not null,
	[AreaCode] varchar(10) not null,
	[Abbreviation] varchar(5),
    [InsertDate]  DATETIME2 (7) DEFAULT (getdate()) NOT NULL,
    [LastChange]  DATETIME2 (7) NULL,
)

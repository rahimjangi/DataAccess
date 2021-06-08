CREATE TABLE [dbo].[Addresses]
(
	[Id] INT NOT NULL PRIMARY KEY,
    [FileinformationId] INT NOT NULL,
    [CityId] INT NOT NULL, 
    [Address] VARCHAR(100) NOT NULL, 
    [No] NCHAR(10) NULL, 
    [PostCode] NCHAR(10) NULL, 
    [AddressTypeId] INT NOT NULL, 
    [Archive] INT NOT NULL DEFAULT 0,
    [InsertDate]  DATETIME2 (7) DEFAULT (getdate()) NOT NULL,
    [LastChange]  DATETIME2 (7) NULL,
    CONSTRAINT [FK_Addresses_AddressType] FOREIGN KEY ([AddressTypeId]) REFERENCES [AddressType]([Id]), 
    CONSTRAINT [FK_Addresses_Fileinformations] FOREIGN KEY ([FileinformationId]) REFERENCES [Fileinformations]([Id]),
    CONSTRAINT [FK_Addresses_ArchiveType] FOREIGN KEY ([Archive]) REFERENCES [ArchiveType]([Id]), 
    CONSTRAINT [FK_Addresses_City] FOREIGN KEY ([CityId]) REFERENCES [City]([Id]),
)

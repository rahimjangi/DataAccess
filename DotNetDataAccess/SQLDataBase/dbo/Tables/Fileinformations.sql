CREATE TABLE [dbo].[Fileinformations]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [EmailAddress] NVARCHAR(50) NOT NULL, 
    [PhoneNumber] NVARCHAR(15) NOT NULL, 
    [CityId] INT NOT NULL,
    [MobileNumber] NCHAR(15) NOT NULL, 
    [InsertDate] DATETIME2 NOT NULL DEFAULT GETDATE(), 
    [ModifiedDate] DATETIME2 NULL, 
    CONSTRAINT [FK_Fileinformations_City] FOREIGN KEY ([CityId]) REFERENCES [City]([Id]), 
)

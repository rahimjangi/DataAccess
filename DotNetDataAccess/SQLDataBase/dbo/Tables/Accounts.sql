CREATE TABLE [dbo].[Accounts]
(
	[Id] INT NOT NULL PRIMARY KEY Identity,
	[FileinformationId] INT NOT NULL,
	[CreditAndDebitCardsId] int,
	[UserId] NVARCHAR(20) NOT NULL,
	[TockenString] NVARCHAR(500) NOT NULL,
	[TockenKey] NVARCHAR(500) NOT NULL,
	[TockenVaue]NVARCHAR(500) NOT NULL,
	[InsertDate] DATETIME2 NOT NULL DEFAULT GETDATE(), 
    [ModifiedDate] DATETIME2 NULL, 
    CONSTRAINT [FK_Accounts_Fileinformations] FOREIGN KEY ([FileinformationId]) REFERENCES [Fileinformations]([Id]), 
    CONSTRAINT [FK_Accounts_CreditAndDebitCards] FOREIGN KEY ([CreditAndDebitCardsId]) REFERENCES [CreditAndDebitCards]([Id])
)

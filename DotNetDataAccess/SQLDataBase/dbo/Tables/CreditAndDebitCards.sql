CREATE TABLE [dbo].[CreditAndDebitCards]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[PaymentOptionId] INT NOT NULL,
	[CardNumber]NVARCHAR(16) NOT NULL,
	[ExpirationYear] NVARCHAR(4) NOT NULL,
	[ExpirationMonth] NVARCHAR(2) NOT NULL,
	[InsertDate] DATETIME2 NOT NULL DEFAULT GETDATE(), 
    [ModifiedDate] DATETIME2 NULL, 
    CONSTRAINT [FK_CreditAndDebitCards_PaymentOptions] FOREIGN KEY ([PaymentOptionId]) REFERENCES [PaymentOptions]([Id]), 
)

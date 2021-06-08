CREATE TABLE [dbo].[Prices]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[PurchasePrice] money not null, 
    [TaxRateId] INT NOT NULL, 
    [BenefitRate] FLOAT NOT NULL DEFAULT 0.2, 
    [DiscountId] INT NOT NULL  ,
    [InsertDate] DATETIME2 NOT NULL DEFAULT GETDATE(), 
    [ModifiedDate] DATETIME2 NULL, 
    CONSTRAINT [FK_Prices_Discounts] FOREIGN KEY ([DiscountId]) REFERENCES [Discounts]([Id]), 
    CONSTRAINT [FK_Prices_TaxRate] FOREIGN KEY ([TaxRateId]) REFERENCES [TaxRate]([Id])
)

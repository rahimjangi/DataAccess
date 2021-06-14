using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDataAccess.Models
{
    public class Prices
    {
        public int Id { get; set; }
        public double PurchasePrice { get; set; }
        public int TaxRateId { get; set; }
        public float BenefitRate { get; set; }
        public int DiscountId { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        //[Id] INT NOT NULL PRIMARY KEY,
        //[PurchasePrice]money not null,
        //[TaxRateId] INT NOT NULL, 
        //[BenefitRate] FLOAT NOT NULL DEFAULT 0.2,
        //[DiscountId] INT NOT NULL  ,
        //[InsertDate] DATETIME2 NOT NULL DEFAULT GETDATE(), 
        //[ModifiedDate] DATETIME2 NULL,

        //CONSTRAINT[FK_Prices_Discounts] FOREIGN KEY([DiscountId]) REFERENCES[Discounts] ([Id]), 
        //CONSTRAINT[FK_Prices_TaxRate] FOREIGN KEY([TaxRateId]) REFERENCES[TaxRate] ([Id])
    }
}

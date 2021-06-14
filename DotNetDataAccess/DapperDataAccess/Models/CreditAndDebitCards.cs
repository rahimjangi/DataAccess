using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDataAccess.Models
{
    public class CreditAndDebitCards
    {
        public int Id { get; set; }
        public int PaymentOptionId { get; set; }
        public string CardNumber { get; set; }
        public string ExpirationYear { get; set; }
        public string ExpirationMonth { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        //[Id] INT NOT NULL PRIMARY KEY IDENTITY,
        //[PaymentOptionId] INT NOT NULL,
        //[CardNumber] NVARCHAR(16) NOT NULL,
        //[ExpirationYear] NVARCHAR(4) NOT NULL,
        //[ExpirationMonth] NVARCHAR(2) NOT NULL,
        //[InsertDate] DATETIME2 NOT NULL DEFAULT GETDATE(), 
        //[ModifiedDate] DATETIME2 NULL,

        //CONSTRAINT[FK_CreditAndDebitCards_PaymentOptions] FOREIGN KEY([PaymentOptionId]) REFERENCES[PaymentOptions] ([Id])
    }
}

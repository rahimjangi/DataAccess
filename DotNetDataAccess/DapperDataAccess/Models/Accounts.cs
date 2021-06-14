using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDataAccess.Models
{
    public class Accounts
    {


        public int Id { get; set; }
        public int FileinformationId { get; set; }
        public int UserId { get; set; }
        public string TockenString { get; set; }
        public string TockenKey { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        //[Id] INT NOT NULL PRIMARY KEY Identity,
        //[FileinformationId] INT NOT NULL,
        //[CreditAndDebitCardsId] int,
        //[UserId] NVARCHAR(20) NOT NULL,
        //[TockenString] NVARCHAR(500) NOT NULL,
        //[TockenKey] NVARCHAR(500) NOT NULL,
        //[TockenVaue]NVARCHAR(500) NOT NULL,
        //[InsertDate] DATETIME2 NOT NULL DEFAULT GETDATE(), 
        //[ModifiedDate] DATETIME2 NULL,

        //CONSTRAINT[FK_Accounts_Fileinformations] FOREIGN KEY([FileinformationId]) REFERENCES[Fileinformations] ([Id]), 
        //CONSTRAINT[FK_Accounts_CreditAndDebitCards] FOREIGN KEY([CreditAndDebitCardsId]) REFERENCES[CreditAndDebitCards] ([Id])
        
    }
}

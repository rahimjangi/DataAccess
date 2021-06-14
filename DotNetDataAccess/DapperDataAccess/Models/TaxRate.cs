using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDataAccess.Models
{
    public class TaxRate
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public int CategoryId { get; set; }
        public float Rate { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        //[Id] INT NOT NULL PRIMARY KEY IDENTITY,
        //[CountryId] INT NOT NULL,
        //CategoryId] INT NOT NULL,
        //[Rate]float not null,
        //[InsertDate] DATETIME2 NOT NULL DEFAULT GETDATE(), 
        //[ModifiedDate] DATETIME2 NULL,

        //CONSTRAINT[FK_TaxRate_Country] FOREIGN KEY([CountryId]) REFERENCES[Country] ([Id]), 
        //CONSTRAINT[FK_TaxRate_Categories] FOREIGN KEY([CategoryId]) REFERENCES[Categories] ([Id])
    }
}

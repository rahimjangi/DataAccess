using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDataAccess.Models
{
    public class City
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string CityName { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime LastChange { get; set; }

        //[Id] INT NOT NULL PRIMARY KEY identity,
        //[CountryId]int not null,
        //[CityName] varchar(50) not null,
        //[InsertDate] DATETIME2(7) DEFAULT(getdate()) NOT NULL,
        //[LastChange]  DATETIME2(7) NULL, 

        //CONSTRAINT[FK_City_Country] FOREIGN KEY([CountryId]) REFERENCES[Country] ([Id])
    }
}

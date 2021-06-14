using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDataAccess.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public string Abbreviation { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime LastChange { get; set; }

        //[Id] INT NOT NULL PRIMARY KEY identity,
        //[CountryName]Varchar(50)not null,
        //[AreaCode] varchar(10) not null,
        //[Abbreviation] varchar(5),
        //[InsertDate] DATETIME2(7) DEFAULT(getdate()) NOT NULL,
        //[LastChange]  DATETIME2(7) NULL
    }
}

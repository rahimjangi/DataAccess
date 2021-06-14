using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDataAccess.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public int CategoryID { get; set; }
        public string BrandName { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime LastChange { get; set; }

        //[Id] INT NOT NULL PRIMARY KEY IDENTITY,
        //[CategoryID] INT NOT NULL , 
        //[BrandName] VARCHAR(50) NOT NULL,
        //[InsertDate]  DATETIME2(7) DEFAULT(getdate()) NOT NULL,
        //[LastChange]  DATETIME2(7) NULL,    

        //CONSTRAINT[FK_Brand_Categories] FOREIGN KEY([CategoryID]) REFERENCES[Categories] ([Id])
    }
}

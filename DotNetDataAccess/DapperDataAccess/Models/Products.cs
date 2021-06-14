using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDataAccess.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int BrandId { get; set; }
        public int PriceId { get; set; }
        public int AvailableCount { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime LastChange { get; set; }

        //[Id] INT NOT NULL PRIMARY KEY IDENTITY,
        //[ProductName] VARCHAR(255) NOT NULL,
        //[Description] VARCHAR(255),
        //[BrandId] INT NOT NULL, 
        //[PriceId] INT NOT NULL, 
        //[AvailableCount] INT NOT NULL DEFAULT 0,
        //[InsertDate] DATETIME2 NOT NULL DEFAULT GETDATE(), 
        //[LastChange] DATETIME2 NULL,

        //CONSTRAINT[FK_Products_Brand] FOREIGN KEY([BrandId]) REFERENCES[dbo].[Brand] ([Id]), 
        //CONSTRAINT[FK_Products_Prices] FOREIGN KEY([PriceId]) REFERENCES[dbo].[Prices] ([Id])
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDataAccess.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int NumberOfItems { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime LastChange { get; set; }

        //[Id] INT NOT NULL PRIMARY KEY identity,
        //[ProductId]int not null,
        //[NumberOfItems]int not null,
        //[InsertDate]  DATETIME2(7) DEFAULT(getdate()) NOT NULL,
        //[LastChange]  DATETIME2(7) NULL, 

        //CONSTRAINT[FK_Orders_Products] FOREIGN KEY([ProductId]) REFERENCES[Products] ([Id])
    }
}

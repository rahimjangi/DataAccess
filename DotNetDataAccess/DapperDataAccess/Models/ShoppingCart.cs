using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDataAccess.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime LastChange { get; set; }

        //[Id] INT NOT NULL PRIMARY KEY, 
        //[OrderId] INT NOT NULL,
        //[InsertDate] DATETIME2(7) DEFAULT(getdate()) NOT NULL,
        //[LastChange]  DATETIME2(7) NULL,
        
        //CONSTRAINT[FK_ShoppingCart_Orders] FOREIGN KEY([OrderId]) REFERENCES[Orders] ([Id])
    }
}

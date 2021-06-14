using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDataAccess.Models
{
    public class Delivery
    {
        public int Id { get; set; }
        public int ShoppingCartId { get; set; }
        public int Status { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime LastChange { get; set; }

        //[Id] INT NOT NULL PRIMARY KEY IDENTITY,
        //[ShoppingCartId] INT NOT NULL,
        //[Status] INT NOT NULL,
        //[InsertDate] DATETIME2(7) DEFAULT(getdate()) NOT NULL,
        //[LastChange]  DATETIME2(7) NULL, 

        //CONSTRAINT[FK_Delivery_ShoppingCart] FOREIGN KEY([ShoppingCartId]) REFERENCES[ShoppingCart] ([Id]), 
        //CONSTRAINT[FK_Delivery_DeliveryStatus] FOREIGN KEY([Status]) REFERENCES[DeliveryStatus] ([Id])
    }
}

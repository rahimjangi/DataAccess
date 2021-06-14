using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDataAccess.Models
{
    public class WishList
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime LastChange { get; set; }

        //[Id] INT NOT NULL PRIMARY KEY IDENTITY,
        //[ProductId] INT NOT NULL,
        //[InsertDate] DATETIME2(7) DEFAULT(getdate()) NOT NULL,
        // [LastChange]  DATETIME2(7) NULL, 

        //CONSTRAINT[FK_WishLista_Products] FOREIGN KEY([ProductId]) REFERENCES[Products] ([Id])
    }
}

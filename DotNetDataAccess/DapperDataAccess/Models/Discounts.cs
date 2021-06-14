using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDataAccess.Models
{
    public class Discounts
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double DiscountRate { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        //[Id] INT NOT NULL PRIMARY KEY IDENTITY,
        //[Description] VARBINARY(50) NOT NULL,
        //[DiscountRate] FLOAT NOT NULL, 
        //[InsertDate] DATETIME2 NOT NULL DEFAULT GETDATE(), 
        //[ModifiedDate] DATETIME2 NULL
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDataAccess.Models
{
    public class PaymentOptions
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime LastChange { get; set; }

        //[Id] INT NOT NULL PRIMARY KEY,
        //[Brand] NVARCHAR(50) NOT NULL,
        //[InsertDate]  DATETIME2(7) DEFAULT(getdate()) NOT NULL,
        //[LastChange]  DATETIME2(7) NULL
    }
}

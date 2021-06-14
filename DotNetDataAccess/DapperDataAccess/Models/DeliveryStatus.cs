using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDataAccess.Models
{
    public class DeliveryStatus
    {
        public int Id { get; set; }
        public string StatusType { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime LastChange { get; set; }

        //[Id] INT NOT NULL PRIMARY KEY IDENTITY,
        //[StatusType] VARCHAR(50) NOT NULL,
        //[InsertDate]  DATETIME2(7) DEFAULT(getdate()) NOT NULL,
        //[LastChange]  DATETIME2(7) NULL
    }
}

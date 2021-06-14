using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDataAccess.Models
{
    public class AddressType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime LastChange { get; set; }

        //[Id] INT NOT NULL PRIMARY KEY, 
        //[TypeName] VARBINARY(50) NOT NULL,
        //[InsertDate] DATETIME2 NOT NULL DEFAULT GETDATE(), 
        //[LastChange] DATETIME2 NULL
    }
}

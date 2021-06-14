using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDataAccess.Models
{
    class Categories
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        //[Id] INT NOT NULL PRIMARY KEY IDENTITY,
        //[CategoryName] NVARCHAR(50) NOT NULL UNIQUE,
        //[InsertDate] DATETIME2 NOT NULL DEFAULT GETDATE(), 
        //[ModifiedDate] DATETIME2 NULL
    }
}

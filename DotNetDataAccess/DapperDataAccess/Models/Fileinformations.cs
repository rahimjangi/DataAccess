using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDataAccess.Models
{
    public class Fileinformations
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public int CityId { get; set; }
        public string MobileNumber { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        //[Id] INT NOT NULL PRIMARY KEY identity,
        //[FirstName] NVARCHAR(50) NOT NULL,
        //[LastName] NVARCHAR(50) NOT NULL,
        //[EmailAddress] NVARCHAR(50) NOT NULL,
        //[PhoneNumber] NVARCHAR(15) NOT NULL,
        //[CityId] INT NOT NULL,
        //[MobileNumber] NCHAR(15) NOT NULL,
        //[InsertDate] DATETIME2 NOT NULL DEFAULT GETDATE(), 
        //[ModifiedDate] DATETIME2 NULL,

        //CONSTRAINT[FK_Fileinformations_City] FOREIGN KEY([CityId]) REFERENCES[City] ([Id])
    }
}

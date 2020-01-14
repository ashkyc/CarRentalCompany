using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentalCarCompany.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Made { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public CarType CarType { get; set; }
        public byte CarTypeId { get; set; }
    }
}
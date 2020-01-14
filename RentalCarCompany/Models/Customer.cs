using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentalCarCompany.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public int Age { get; set; }
        public string DriverLicense { get; set; }
        public MembershipTier MembershipTier { get; set; }
        public byte MembershipTierId { get; set; }
    }
}
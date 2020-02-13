using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentalCarCompany.Models
{
    public class MembershipTier
    {
        public byte Id { get; set; }
        public string Tier { get; set; }
        public byte DiscountRate { get; set; }
    }
}
using RentalCarCompany.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentalCarCompany.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipTier> MembershipTiers { get; set; }
        public Customer Customer { get; set; }

    }
}
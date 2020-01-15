using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentalCarCompany.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Display (Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Date of Birth")]
        [Min18YearsOfAge]
        public DateTime Birthdate { get; set; }
        public int Age { get; set;}
        [Required]
        [StringLength(10)]
        [Display(Name = "Driver License")]
        public string DriverLicense { get; set; }
        public MembershipTier MembershipTier { get; set; }
        [Required]
        [Display(Name = "Membership Tire")]
        public byte MembershipTierId { get; set; }
    }
}
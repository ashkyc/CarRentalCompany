using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentalCarCompany.Models
{
    public class Min18YearsOfAge: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            var age = DateTime.Today.Year - customer.Birthdate.Year;

            return(age >= 18 ? ValidationResult.Success : new ValidationResult("Customer must be at least 18 years old."));

        }
    }
}
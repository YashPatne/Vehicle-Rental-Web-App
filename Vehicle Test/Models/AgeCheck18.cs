using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vehicle_Test.Models
{
    public class AgeCheck18:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            if (customer.BirthDate == null)
            {
                return new ValidationResult("Birth Date is Required");
            }
            var dob = customer.BirthDate.Value;
            var age = DateTime.Now.Year - dob.Year;
            if (DateTime.Now.DayOfYear < dob.DayOfYear)
                age = age - 1;
            return (age >= 18) ? ValidationResult.Success : new ValidationResult("Customer Should be 18 Years of Age");
        }
    }
}
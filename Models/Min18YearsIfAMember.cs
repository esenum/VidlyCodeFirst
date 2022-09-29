using System;
using System.ComponentModel.DataAnnotations;

namespace VidlyCF.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer =(Customer) validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.Unknown ||
                customer.MembershipTypeId == MembershipType.PayAsYouGo) /*customer.MembershipTypeId == 0 || customer.MembershipTypeId == 1*/
                return ValidationResult.Success;
  
            if ( customer.Birthdate == null)          
                return new ValidationResult("Birthdate is required.");

            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            return (age >= 18)
                ? ValidationResult.Success
                : new ValidationResult("Customer should at least 18 years old to go on a membership.");
            
        }
        
    }
}
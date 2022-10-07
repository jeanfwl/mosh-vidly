﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.Unknow ||
                customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;

            if (!customer.Birthdate.HasValue)
                return new ValidationResult("Birthdate is required.");

            var age = DateTime.Now.Year - customer.Birthdate.Value.Year;

            return (age < 18)
                ? new ValidationResult("Customer age must be at least 18 years old to go a membership.")
                : ValidationResult.Success;
        }
    }
}
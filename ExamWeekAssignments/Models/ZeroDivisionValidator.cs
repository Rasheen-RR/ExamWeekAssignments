using System;
using System.ComponentModel.DataAnnotations;

namespace ExamWeekAssignments.Models
{
    public class ZeroDivisionValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var equaltion = (CalculatorModel)validationContext.ObjectInstance;

            if (equaltion.operat.Equals("/") && equaltion.rightNumber == 0)
            {
                return new ValidationResult("Divsion cannot be done by 0");
            }

            return ValidationResult.Success;
        }
    }
}

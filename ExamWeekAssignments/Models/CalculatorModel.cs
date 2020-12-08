using System;
using System.ComponentModel.DataAnnotations;

namespace ExamWeekAssignments.Models
{
    public class CalculatorModel
    {
        public double leftNumber { get; set; }

        [ZeroDivisionValidator]
        public double rightNumber { get; set; }

        [RegularExpression("([+*/-])", ErrorMessage = "Enter a valid operator (+,-,*,/)")]
        public string operat { get; set; }

        public double result { get; set; }

    }

}


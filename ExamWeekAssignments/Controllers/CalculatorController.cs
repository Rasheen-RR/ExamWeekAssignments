using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculatorLibrary;
using ExamWeekAssignments.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExamWeekAssignments.Controllers
{
    public class CalculatorController : Controller
    {

        SimpleCalc simpleCalc = new SimpleCalc();

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ActionName("Index")]
        public IActionResult IndexPost([Bind("leftNumber,rightNumber,operat")] CalculatorModel calculator)
        {

            CalculatorModel cm = new CalculatorModel();
            cm.rightNumber = calculator.rightNumber;
            cm.leftNumber = calculator.leftNumber;
            cm.operat = calculator.operat;
            cm.result = simpleCalc.OperatorSwitch(calculator.leftNumber, calculator.rightNumber, calculator.operat);

            return View("Index", cm);
        }


        
    }
}

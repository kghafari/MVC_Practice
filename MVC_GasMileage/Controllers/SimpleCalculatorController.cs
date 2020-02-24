using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_GasMileage.Models;

namespace MVC_GasMileage.Controllers
{
    public class SimpleCalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CalculatorForm()
        {
            return View();
        }

        public IActionResult CalculatorResult(SimpleCalculator calculator)
        {
            //do stuff
            calculator.DoMath();
            return View(calculator); //feed results. don't forget about string/namespace nonsense
        }
    }
}
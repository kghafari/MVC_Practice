using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_GasMileage.Models;

namespace MVC_GasMileage.Controllers
{
    public class FuelCalcController : Controller
    {
        public IActionResult MileageForm()
        {
            return View();
        }

        public IActionResult DisplayResult(FuelCalculator calculator)
        {
            calculator.CalculateMiles();
            calculator.Trip();
            return View(calculator);
        }
    }
}
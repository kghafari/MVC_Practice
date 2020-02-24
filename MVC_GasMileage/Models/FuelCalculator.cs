using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_GasMileage.Models
{
    public class FuelCalculator
    {
        public double MPG { get; set; }
        public double FuelRemaining { get; set; }

        public double TripDistance { get; set; }
        public double Result { get; set; }

        public string ResultString { get; set; }

        public FuelCalculator() { }

        public FuelCalculator(double mpg, double fuelRemaining)
        {
            MPG = mpg;
            FuelRemaining = fuelRemaining;
        }

        public void CalculateMiles()
        {
            Result = MPG * FuelRemaining;
        }

        public void Trip()
        {
            if (TripDistance > Result )
            {
                ResultString = "You need more gas!";
            }
            else
            {
                ResultString = "You have enough gas!";
            }
        }

    }
}

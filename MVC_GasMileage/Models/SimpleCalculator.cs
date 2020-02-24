using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_GasMileage.Models
{
    public class SimpleCalculator
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public double Result { get; set; }

        public string Operator { get; set; } 

        public string Error { get; set; }

        public SimpleCalculator() { }

        public void DoMath()
        {
            if(Operator == "+")
            {
                Result = Num1 + Num2;
            }
            else if(Operator == "-")
            {
                Result = Num1 - Num2;
            }
            else if(Operator == "*")
            {
                Result = Num1 * Num2;
            }
            else if(Operator == "/")
            {
                Result = Num1 / Num2;
            }
            else
            {
                Error = "Uh oh...";              
            }
        }

    }
}

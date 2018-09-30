using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLib.Swabhav
{
    public class Calculator
    {
        public Double CubeEvenNumber(double number)
        {
            if (number % 2 == 0)
            {
                return number * number * number;
            }
            else
            {
                throw new Exception("Not an Even NUmber");
                return 5;
            }
        }

    }
}

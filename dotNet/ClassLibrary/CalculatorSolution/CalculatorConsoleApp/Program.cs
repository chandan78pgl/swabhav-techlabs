using CalculatorLib.Swabhav;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            double number = calculator.CubeEvenNumber(5);

            Console.WriteLine("Answer = {0}",number);
        }
    }
}

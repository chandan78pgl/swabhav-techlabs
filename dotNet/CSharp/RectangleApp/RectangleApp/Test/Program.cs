using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleApp.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

            rectangle.Height = 5;
            rectangle.Width = 4;
            rectangle.Color = "red";

            Console.WriteLine(rectangle);
            Console.WriteLine("Area: {0}", rectangle.CalculateArea());
        }
    }
}

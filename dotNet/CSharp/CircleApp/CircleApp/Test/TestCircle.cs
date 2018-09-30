using System;

namespace CircleApp.Test
{
    class TestCircle
    {
        static void Main(string[] args)
        {
            Circle[] circles = new Circle[3];

            circles[0]= new Circle(2, BorderType.DOUBLE);
            circles[1]= new Circle(5, BorderType.DOTTED);
            circles[2]= new Circle(10, BorderType.SINGLE);

            Console.WriteLine(circles[0]);
            Console.WriteLine(circles[1]);
            Console.WriteLine(circles[2]);

            Console.WriteLine("Sum = {0}", circles[0].Area() + circles[1].Area() + circles[2].Area());
        }
    }
}

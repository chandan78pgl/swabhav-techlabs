using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionApp
{
    class PrintApp
    {
        public void print(string name)
        {
            Console.WriteLine("Calling String Print: {0}",name);
        }

        public void print(bool name)
        {
            Console.WriteLine("Calling Bool Print {0}", name);
        }

        public void print(char name)
        {
            Console.WriteLine("Calling char Print {0}", name);
        }
        public void print(decimal name)
        {
            Console.WriteLine("Calling decimal Print {0}", name);

        }
        public void print(double name)
        {
            Console.WriteLine("Calling double Print {0}", name);
        }
        public void print(float name)
        {
            Console.WriteLine("Calling float Print {0}", name);
        }
        public void print(int name)
        {
            Console.WriteLine("Calling int Print {0}", name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PrintApp p = new PrintApp();

            bool value = true;
            int val = 4;
            float flo = 6.0005F;
            double dou = 7.03333;
            decimal dec = 7.5698M;

            p.print(val);
            p.print(value);
            p.print(flo);
            p.print(dou);
            p.print("Chandan");
            p.print(dec);
        }
    }
}

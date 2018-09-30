using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuiltInDelegateApp
{
    
    public class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static void ConsolePrint(int result)
        {
            Console.WriteLine("Result = {0}",result);
        }

        static void Main(string[] args)
        {
            Func<int, int, int> Sum = Add;
            Action<int> Print = ConsolePrint;

            Predicate<int> result = a => { return a > 5; };
            
            Console.WriteLine(result(7));

            Print(Sum(5, 10));
        }
    }
}

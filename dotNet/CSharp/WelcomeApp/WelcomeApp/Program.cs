using System;

namespace WelcomeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            
            foreach(string name in args)
            {
                Console.WriteLine("Hello {0} ", name);
            }
        }
    }
}
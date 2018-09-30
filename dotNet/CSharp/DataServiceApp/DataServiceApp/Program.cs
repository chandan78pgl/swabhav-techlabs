using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataServiceApp
{
    public class Program
    {
        public static void Error(int number)
        {
            Console.WriteLine("Error: {0}", number);
        }

        public static void Success(int number)
        {
            Console.WriteLine("Success: {0}", number);
        }

        static void Main(string[] args)
        {
            DataService dataService=new DataService();

            dataService.OnSuccess += Success;
            dataService.OnError += Error;

            dataService.GetData();
        }
    }
}

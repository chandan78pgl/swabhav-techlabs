using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerApp.Test
{
    public class TestCustomer
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer("Chandan", "Maharana", "25/11/1995");
            Customer customer2 = new Customer("Dharmesh", "Nayak", "22/12/1996");

            Console.WriteLine(customer1);
            Console.WriteLine(customer2);
        }
    }
}

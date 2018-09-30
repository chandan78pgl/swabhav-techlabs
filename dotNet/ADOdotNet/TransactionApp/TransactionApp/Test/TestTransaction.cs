using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionApp.Test
{
    public class TestTransaction
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer(1,"chandan",18000);
            Merchant merchant1 = new Merchant(103, "Smith", 12000);

            customer1.Purchase(merchant1, 5000);

            Console.WriteLine("Customer balance = {0}", customer1.CustomerBalance);
            Console.WriteLine("Merchant balance = {0}", merchant1.MerchantBalance);
        }
    }
}

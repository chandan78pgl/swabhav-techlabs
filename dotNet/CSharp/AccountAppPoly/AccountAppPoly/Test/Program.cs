using System;
using System.Collections.Generic;
using System.Text;

namespace AccountAppPoly.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new SavingsAccount(101, "Chandan", 5000);
            Account account2 = new CurrentAccount(101, "Chandan", 5000);

            account1.Withdraw(5000);
            Console.WriteLine(account1);
            account1.Withdraw(4500);
            Console.WriteLine(account1);

            account2.Withdraw(15000);
            Console.WriteLine(account2);
            account2.Withdraw(10000);
            Console.WriteLine(account2);
        }
    }
}

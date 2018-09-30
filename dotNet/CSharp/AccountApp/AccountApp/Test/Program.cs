using System;
using System.Collections.Generic;
using System.Text;

namespace AccountApp.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(101,"Chandan",1000);
            account.Deposit(1000);
            account.Withdraw(100);
            Console.WriteLine(account);
        }
    }
}

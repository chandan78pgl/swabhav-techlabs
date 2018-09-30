using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventApp.Test
{
    class TestAccount
    {
        public static void SendEmail(Account account)
        {
            Console.WriteLine("Email is Sent for {0} account", account);
        }

        public static void SendSMS(Account account)
        {
            Console.WriteLine("SMS is sent for {0} account", account);
        }

        static void Main(string[] args)
        {
            Account account = new Account("Chandan", 10000);
            account.OnBalanceChanged += SendEmail;
            account.OnBalanceChanged += SendSMS;

            account.Deposit(1000);
            account.Withdraw(500);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AccountAppWithCustomException.Test
{
    class TestAccount
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(101, "chandan", 1000);

            try
            {
                account1.Withdraw(600);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

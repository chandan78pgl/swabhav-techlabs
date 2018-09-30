using System;
using System.Collections.Generic;
using System.Text;

namespace AccountAppPoly
{
    class CurrentAccount : Account
    {
        public CurrentAccount(int accNo, string name, double balance) : base(accNo, name, balance)
        {
        }

        public override void Withdraw(double amount)
        {
            if (ValidateWithdraw(amount))
            {
                this.Balance -= amount;
            }
            else
            {
                Console.WriteLine("Cannot Withdraw Minimum Balance has to be maintained to 5000 Rs");
            }
        }

        private Boolean ValidateWithdraw(double amount)
        {
            if ((this.Balance - amount) <-5000)
            {
                return false;
            }
            return true;
        }
    }
}

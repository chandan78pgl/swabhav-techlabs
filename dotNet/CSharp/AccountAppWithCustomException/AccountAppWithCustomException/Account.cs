using System;
using System.Collections.Generic;
using System.Text;

namespace AccountAppWithCustomException
{
    class Account
    {
        private int _accNo;
        private string _name;
        private double _balance = 500.0;
        private static int count;

        static Account()
        {
            count = 100;
            Console.WriteLine("Inside Static");
        }

        public Account(int accNo, string name, double balance) : this(accNo, name)
        {
            this._balance = balance;
        }

        public Account(int accNo, string name) : this()
        {
            this._accNo = accNo;
            this._name = name;
        }

        public Account()
        {
            count++;
            Console.WriteLine("Object Created {0}", count);
        }

        public void Deposit(double amount)
        {
            this._balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (ValidateWithdraw(amount))
            {
                this._balance -= amount;
            }
            else
            {
                throw new InsufficientFundException("Cannot withdraw InsufficientFundException",this);
            }
        }

        private Boolean ValidateWithdraw(double amount)
        {
            if ((this._balance - amount) < 500)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Int32 AccountNo
        {
            get
            {
                return this._accNo;
            }
        }

        public String Name
        {
            get
            {
                return this._name;
            }
        }

        public Double Balance
        {
            get
            {
                return this._balance;
            }
        }

        public override string ToString()
        {
            return "Account No: " + this._accNo
                + "\n Name: " + this._name
                + "\n Balance: " + this._balance;
        }
    }
}

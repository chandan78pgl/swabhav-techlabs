using System;
using System.Collections.Generic;
using System.Text;

namespace AccountAppPoly
{
    abstract class Account
    {
        private int _accNo;
        private string _name;
        private double _balance;

        public Account(int accNo,string name,double balance)
        {
            this._accNo = accNo;
            this._name = name;
            this._balance = balance;
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
            set
            {
                this._balance = value;
            }
        }

        public void Deposit(double amount)
        {
            this._balance += amount;
        }

        public abstract void Withdraw(double amount);

        public override string ToString()
        {
            return "Account No: "+this.AccountNo
                + "\n Name: " + this.Name
                + "\n Balance: " + this.Balance;
        }
    }
}

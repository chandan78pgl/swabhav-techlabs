using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventApp
{
    public delegate void DBalanceChanged(Account account);
    public class Account
    {
        private string _name;
        private double _balance;
        public event DBalanceChanged OnBalanceChanged;

        public Account(string name,double balance)
        {
            _name = name;
            _balance = balance;
        }

        public String Name
        {
            get
            {
                return _name;
            }
        }

        public Double Balance
        {
            get
            {
                return _balance;
            }
        }

        public void Deposit(double amount)
        {
            _balance += amount;

            if (OnBalanceChanged!=null)
            {
                OnBalanceChanged(this);
            }
        }

        public void Withdraw(double amount)
        {
            _balance -= amount;

            if (OnBalanceChanged != null)
            {
                OnBalanceChanged(this);
            }
        }

        public override string ToString()
        {
            return "\nName: "+_name
                +"\n Balance: "+_balance;
        }
    }
}

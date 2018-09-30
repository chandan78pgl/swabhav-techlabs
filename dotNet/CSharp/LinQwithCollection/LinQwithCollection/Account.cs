using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQwithCollection
{
    public class Account:IComparable
    {
        private int _accountNo;
        private string _accountName;
        private double _accountBalance;

        public int AccountNo
        {
            get
            {
                return _accountNo;
            }

            set
            {
                _accountNo = value;
            }
        }

        public string AccountName
        {
            get
            {
                return _accountName;
            }

            set
            {
                _accountName = value;
            }
        }

        public double AccountBalance
        {
            get
            {
                return _accountBalance;
            }

            set
            {
                _accountBalance = value;
            }
        }

        public int CompareTo(object obj)
        {
            Account account = (Account)obj;
            return AccountBalance.CompareTo(account.AccountBalance);
        }
    }
}

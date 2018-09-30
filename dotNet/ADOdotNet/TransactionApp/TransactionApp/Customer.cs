using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionApp
{
    public class Customer
    {
        private int _customerId;
        private string _customerName;
        private int _customerBalance;

        public Customer(int id,string name,int balance)
        {
            _customerId = id;
            _customerName = name;
            _customerBalance = balance;
        }

        public Int32 CustomerId
        {
            get
            {
                return _customerId;
            }
        }

        public String CustomerName
        {
            get
            {
                return _customerName;
            }
        }

        public Int32 CustomerBalance
        {
            set
            {
                _customerBalance = value;

            }
            get
            {
                return _customerBalance;
            }
        }

        public void Purchase(Merchant merchant,int amount)
        {
            Transaction transaction = new Transaction();
            transaction.DoTransaction(this, merchant,amount);
        }
    }
}

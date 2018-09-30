using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionApp
{
    public class Merchant
    {
        private int _merchantId;
        private string _merchantName;
        private int _merchantBalance;

        public Merchant(int id,string name,int balance)
        {
            _merchantId = id;
            _merchantName = name;
            _merchantBalance = balance;
        }

        public int MerchantId
        {
            get
            {
                return _merchantId;
            }
        }

        public string MerchantName
        {
            get
            {
                return _merchantName;
            }
        }

        public int MerchantBalance
        {
            set
            {
                _merchantBalance = value;
            }
            get
            {
                return _merchantBalance;
            }
        }
    }
}

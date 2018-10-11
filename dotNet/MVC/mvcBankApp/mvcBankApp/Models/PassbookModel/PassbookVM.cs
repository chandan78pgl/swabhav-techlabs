using mvcBankApp.Models.TransactionModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcBankApp.Models.PassbookModel
{
    public class PassbookVM
    {
        public int AccountNo { set; get; }
        public List<AccountTransaction> accountTransactions { set; get; }
    }
}
using mvcBankApp.Models.RegistrationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcBankApp.Models.TransactionModel
{
    public class TransactionVM
    {
        public double Amount { set; get; }
        public List<string> Type { set; get; }
        public int AccountHolderId { set; get; }
        public string SelectedType { set; get; }

        public TransactionVM()
        {
            Type = new List<string>();
            Type.Add("Deposit");
            Type.Add("Withdraw");
        }
    }
}
using mvcBankApp.Models.RegistrationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcBankApp.Models.TransactionModel
{
    public class AccountTransaction
    {
        public Guid Id { get; set; }
        public string TransactionType { get; set;}
        public double TransactionAmount { get; set; }
        public DateTime TransactionDate { get; set; }

        public virtual Account acnt { get; set; }

        public AccountTransaction()
        {
            Id = Guid.NewGuid();
        }
    }
}
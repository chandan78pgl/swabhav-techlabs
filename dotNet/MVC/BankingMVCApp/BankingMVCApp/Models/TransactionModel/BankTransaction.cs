using BankingMVCApp.Models.RegistrationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingMVCApp.Models.TransactionModel
{
    public class BankTransaction
    {
        public Guid Id { set; get; }
        public String TransactionType { set; get; }
        public Double Amount { set; get; }
        public DateTime TransactionDate { set; get; }

        public virtual BankAccount Account { set; get; }

        public BankTransaction()
        {
            Id = Guid.NewGuid();
        }
    }
}
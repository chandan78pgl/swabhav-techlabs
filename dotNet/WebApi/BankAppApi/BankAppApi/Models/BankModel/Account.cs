using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BankAppApi.Models.BankModel
{
    public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AccountNo { get; set; }

        public string AccountHolderName { get; set; }
        public double AccountBalance { get; set; }
        public string AccountPassword { get; set; }
        public DateTime AccountCreatedDate { get; set; }

        public virtual List<AccountTransaction> TransactionList { get; set; }
    }
}
using BankingMVCApp.Models.TransactionModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BankingMVCApp.Models.RegistrationModel
{
    public class BankAccount
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AccountNo { set; get; }
        public String Name { set; get; }
        public Double Balance { set; get; }
        public String Password { set; get; }
        public DateTime DateCreated { set; get; } 

        public virtual List<BankTransaction> BankTransactions { set; get; }
    }
}
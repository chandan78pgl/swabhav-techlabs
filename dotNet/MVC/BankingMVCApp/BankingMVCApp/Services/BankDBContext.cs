using BankingMVCApp.Models.RegistrationModel;
using BankingMVCApp.Models.TransactionModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BankingMVCApp.Services
{
    public class BankDBContext:DbContext
    {
        public DbSet<BankAccount> BankAccounts { set; get; }
        public DbSet<BankTransaction> BankTransactions { set; get; }
    }
}
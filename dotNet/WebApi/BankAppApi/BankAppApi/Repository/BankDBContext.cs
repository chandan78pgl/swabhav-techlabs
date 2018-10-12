using BankAppApi.Models.BankModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BankAppApi.Repository
{
    public class BankDBContext:DbContext
    {
        public DbSet<Account> BankAccounts { set; get; }
        public DbSet<AccountTransaction> AccountTransactions { set; get; }
    }
}
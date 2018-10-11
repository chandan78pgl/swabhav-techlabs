using mvcBankApp.Models.RegistrationModel;
using mvcBankApp.Models.TransactionModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvcBankApp.Models.Services
{
    public class BankingServices
    {
        private BankDbContext _dbContext;
        public Account _currentAcntHolder { get; set; }

        public BankingServices(BankDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void RegisterAccount(Account acnt)
        {
            _dbContext.BankAccounts.Add(acnt);
            _dbContext.SaveChanges();
        }

        public List<Account> GetAllAccounts()
        {
            return _dbContext.BankAccounts.ToList();
        }

        public void DoTransaction(AccountTransaction accountTransaction, int AccountNo)
        {
            using (DbContextTransaction dbTransaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    Account account = _dbContext.BankAccounts.Where((a) => a.AccountNo == AccountNo).Single();

                    if (accountTransaction.TransactionType == "Deposit")
                    {
                        account.AccountBalance = account.AccountBalance + accountTransaction.TransactionAmount;
                    }
                    else if (accountTransaction.TransactionType == "Withdraw")
                    {
                        account.AccountBalance = account.AccountBalance - accountTransaction.TransactionAmount;
                    }

                    accountTransaction.acnt = account;
                    _dbContext.AccountTransactions.Add(accountTransaction);
                    _dbContext.SaveChanges();
                    dbTransaction.Commit();
                }
                catch (Exception e)
                {
                    dbTransaction.Rollback();
                    throw e;
                }
            }
        }

        public List<AccountTransaction> GetAllTransactions()
        {
            return _dbContext.AccountTransactions.ToList();
        }

        public bool AuthenticateUser(int acntno,string pass)
        {
           Account acnt= _dbContext.BankAccounts.Where((a) => a.AccountNo == acntno && a.AccountPassword==pass).Select((a) => a).SingleOrDefault();
            if (acnt == null)
            {
                return false;
            }
            _currentAcntHolder = acnt;
            return true;
        }

        public List<AccountTransaction> GetSingleAccountTransaction(int accountNo)
        {
            return _dbContext.AccountTransactions.Where((a)=>a.acnt.AccountNo==accountNo).ToList();
        }
    }
}
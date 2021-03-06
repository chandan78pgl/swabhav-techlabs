﻿using BankAppApi.Models.BankModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BankAppApi.Repository
{
    public class BankRepository:IBankRepository<Account,AccountTransaction>
    {
        private BankDBContext _bankDBContext = new BankDBContext();
        public Account _accountHolder { set; get; }

        public bool AuthenticateUser(int accountNo, string password)
        {
            Account account = _bankDBContext.BankAccounts.Where((a) => a.AccountNo == accountNo && a.AccountPassword == password).SingleOrDefault();
            if (account == null)
            {
                return false;
            }
            _accountHolder = account;
            return true;
        }

        public void DoTransaction(AccountTransaction transaction, int accountNo)
        {
            using (DbContextTransaction dbTransaction = _bankDBContext.Database.BeginTransaction())
            {
                try
                {
                    Account account = _bankDBContext.BankAccounts.Where((a) => a.AccountNo == accountNo).Single();

                    if (transaction.TransactionType == "Deposit")
                    {
                        account.AccountBalance = account.AccountBalance + transaction.TransactionAmount;
                    }
                    else if (transaction.TransactionType == "Withdraw")
                    {
                        account.AccountBalance = account.AccountBalance - transaction.TransactionAmount;
                    }

                    transaction.account = account;
                    _bankDBContext.AccountTransactions.Add(transaction);
                    _bankDBContext.SaveChanges();
                    dbTransaction.Commit();
                }
                catch (Exception e)
                {
                    dbTransaction.Rollback();
                    throw e;
                }
            }
        }

        public List<Account> GetAllAccounts()
        {
            return _bankDBContext.BankAccounts.ToList();
        }

        public List<AccountTransaction> GetAllTransactions()
        {
            return _bankDBContext.AccountTransactions.ToList();
        }

        public List<AccountTransaction> GetSingleAccountTransactions(int accountNo)
        {
            return _bankDBContext.AccountTransactions.Where((a) => a.account.AccountNo == accountNo).ToList();
        }

        public void RegisterAccount(Account entity)
        {
            entity.AccountCreatedDate = DateTime.Now;
            _bankDBContext.BankAccounts.Add(entity);
            _bankDBContext.SaveChanges();
        }
    }
}
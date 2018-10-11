using BankingMVCApp.Models.RegistrationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingMVCApp.Services
{
    public class BankService
    {
        private BankDBContext _bankDBContext;
        private static BankService _bankService;

        public static BankService GetInstance()
        {
            if (_bankService==null)
            {
                return _bankService = new BankService();
            }
            return _bankService;
        }
        public BankService()
        {
            _bankDBContext = new BankDBContext();
        }

        public void AddAccount(BankAccount account)
        {
            _bankDBContext.BankAccounts.Add(account);
            _bankDBContext.SaveChanges();
        }

      

        public BankAccount SearchAccount(int accountNo)
        {
            return null;
        }

        public bool AuthenticateUser(int accountNo, string password)
        {
            BankAccount account = _bankDBContext.BankAccounts.Where((a) => a.AccountNo == accountNo && a.Password==password).Select((a)=>a).SingleOrDefault();

            if (account != null)
            {
                return true;
            }
            return false;
        }
    }
}
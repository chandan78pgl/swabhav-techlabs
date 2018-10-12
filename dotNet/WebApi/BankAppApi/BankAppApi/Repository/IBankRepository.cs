using BankAppApi.Models.BankModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankAppApi.Repository
{
    public interface IBankRepository<T,V>
    {
        void RegisterAccount(T entity);
        void DoTransaction(V transaction,int accountNo);
        bool AuthenticateUser(int accountNo,string password);

        List<V> GetSingleAccountTransactions(int accountNo);
        List<V> GetAllTransactions();
        List<T> GetAllAccounts();
    }
}
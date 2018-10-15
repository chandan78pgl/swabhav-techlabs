using BankAppApi.Models.BankModel;
using BankAppApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace BankAppApi.Controllers
{
    [RoutePrefix("api/bank/transaction")]
    public class TransactionController : ApiController
    {
        private IBankRepository<Account, AccountTransaction> _bankRepository = new BankRepository();

        [Route("DoTransaction")]
        public IHttpActionResult PostTransaction(AccountTransaction transaction)
        {
            transaction.TransactionDate = DateTime.Now;
            
            
            _bankRepository.DoTransaction(transaction, transaction.account.AccountNo);
            return Ok("Transaction Successfull");
        }

        [Route("AllTransactions/{accountNo:int}")]
        public IHttpActionResult GetTransactions(int accountNo)
        {
            return Ok(_bankRepository.GetSingleAccountTransactions(accountNo));
        }
    }
}
using BankAppApi.Models.BankModel;
using BankAppApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace BankAppApi.Controllers
{
    [RoutePrefix("api/bank/registration")]
    public class RegistrationController : ApiController
    {
        private IBankRepository<Account,AccountTransaction> _bankRepository = new BankRepository();

        [Route("AllAccounts")]
        public IHttpActionResult GetAccounts()
        {
            return Ok(_bankRepository.GetAllAccounts());
        }

        [Route("RegisterAccount")]
        public IHttpActionResult PostAddAccount(Account account)
        {
            _bankRepository.RegisterAccount(account);   
            return Ok("Account Added Successfully - " + account.AccountHolderName);
        }
    }
}
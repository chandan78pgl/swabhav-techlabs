using BankAppApi.Models.BankModel;
using BankAppApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace BankAppApi.Controllers
{
    [RoutePrefix("api/bank/login")]
    public class LoginController : ApiController
    {
        private IBankRepository<Account, AccountTransaction> _bankRepository = new BankRepository();

        [Route("checkUser")]
        public IHttpActionResult PostUser(AccountHolder account)
        {
            if (_bankRepository.AuthenticateUser(account.AccountNo, account.Password))
            {
                return Ok("Success - "+account.AccountNo);
            }
            return Ok("Authentication Failed");
        }
        

        public class AccountHolder
        {
            public int AccountNo { set; get; }
            public string Password { set; get; }
        }
    }
}
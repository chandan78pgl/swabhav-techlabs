using mvcBankApp.Models.RegistrationModel;
using mvcBankApp.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcBankApp.Controllers
{
    public class RegisterController : Controller
    {
        private BankDbContext _dbContext = new BankDbContext();
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(RegistrationVM vm)
        {
            if (ModelState.IsValid)
            {
                BankingServices bankingService = new BankingServices(_dbContext);
                bankingService.RegisterAccount(new Account { AccountHolderName = vm.AccountHolderName, AccountNo = vm.AccountNo, AccountBalance = vm.AccountBalance, AccountPassword = vm.AccountPassword, AccountCreatedDate = DateTime.Now });
                return RedirectToAction("Index", "Login");
            }
            return View(vm);
        }
    }
}
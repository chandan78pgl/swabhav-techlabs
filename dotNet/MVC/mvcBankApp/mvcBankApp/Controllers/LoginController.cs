using mvcBankApp.Models.LoginModel;
using mvcBankApp.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcBankApp.Controllers
{
    public class LoginController : Controller
    {
        private BankDbContext _dbContext = new BankDbContext();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Index(LoginVM vm)
        {
            if (ModelState.IsValid)
            {
                BankingServices bankingService = new BankingServices(_dbContext);
                if (bankingService.AuthenticateUser(vm.AcntNo, vm.AccountPassword))
                {
                    Session["account"] = bankingService._currentAcntHolder.AccountNo;
                    Session.Timeout = 1;
                    return RedirectToAction("Index", "Home");
                }
                return View(vm);
            }
            return View(vm);
        }
    }
}
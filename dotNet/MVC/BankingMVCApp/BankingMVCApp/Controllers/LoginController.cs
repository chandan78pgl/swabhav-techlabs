using BankingMVCApp.Models.LoginModel;
using BankingMVCApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankingMVCApp.Controllers
{
    public class LoginController : Controller
    {
        private BankDBContext _bankDBContext = new BankDBContext();
        private BankService _bankService;
        // GET: Login
        public ActionResult Index()
        {
            LoginVM loginVM = new LoginVM();
            return View(loginVM);
        }

        [HttpPost]
        public ActionResult Index(LoginVM vm)
        {
            if (ModelState.IsValid)
            {
                _bankService = BankService.GetInstance();
                if (_bankService.AuthenticateUser(vm.AccountNo, vm.Password))
                {
                    Session["user"] = vm.AccountNo;
                    Session.Timeout = 1;
                    RedirectToAction("Index", "Home");
                }
                return View(vm);
            }
            return View(vm);
        }
    }
}
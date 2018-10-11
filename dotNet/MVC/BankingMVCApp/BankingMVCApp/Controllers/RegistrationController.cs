using BankingMVCApp.Models.RegistrationModel;
using BankingMVCApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankingMVCApp.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            //RegistrationVM registrationVM = new RegistrationVM();
            return View();
        }

        [HttpPost]
        public ActionResult Index(RegistrationVM vm)
        {
            if (ModelState.IsValid)
            {
                BankService _bankService = BankService.GetInstance();
                _bankService.AddAccount(new BankAccount{AccountNo = vm.AccountNo,Name = vm.Name,Balance = vm.Balance,Password = vm.Password,DateCreated = DateTime.Now});

                return RedirectToAction("Index", "Registration");
            }
            return View(vm);
        }
    }
}
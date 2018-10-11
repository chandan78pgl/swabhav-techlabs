using mvcBankApp.Models.RegistrationModel;
using mvcBankApp.Models.Services;
using mvcBankApp.Models.TransactionModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcBankApp.Controllers
{
    public class TransactionController : Controller
    {
        private BankDbContext _dbContext = new BankDbContext();
        // GET: Transaction
        public ActionResult Index()
        {
            TransactionVM transactionVM = new TransactionVM();
            if (!CheckSession())
            {
                return RedirectToAction("Index","Login");
            }
            transactionVM.AccountHolderId = Convert.ToInt32(Session["account"]);
            return View(transactionVM);
        }

        [HttpPost]
        public ActionResult Index(TransactionVM vm)
        {
            vm.AccountHolderId = Convert.ToInt32(Session["account"]);
            BankingServices bankingService = new BankingServices(_dbContext);
            AccountTransaction transaction = new AccountTransaction {TransactionType=vm.SelectedType,TransactionAmount=vm.Amount,TransactionDate=DateTime.Now};

            bankingService.DoTransaction(transaction,vm.AccountHolderId);
            return View(vm);
        }

        private bool CheckSession()
        {
            if (Session["account"] != null)
            {
                return true;
            }
            return false;
        }
    }
}
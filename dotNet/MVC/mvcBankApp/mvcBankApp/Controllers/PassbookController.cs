using mvcBankApp.Models.PassbookModel;
using mvcBankApp.Models.Services;
using mvcBankApp.Models.TransactionModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace mvcBankApp.Controllers
{
    public class PassbookController : Controller
    {
        private BankDbContext _bankDBContext = new BankDbContext();
        // GET: Passbook
        public ActionResult Index()
        {
            BankingServices bankServices = new BankingServices(_bankDBContext);
            PassbookVM passbookVM = new PassbookVM();

            if (!CheckSession())
            {
                return RedirectToAction("Index","Login");
            }
            passbookVM.AccountNo = Convert.ToInt32(Session["account"]);
            TempData["transactions"] = bankServices.GetSingleAccountTransaction(passbookVM.AccountNo);
            passbookVM.accountTransactions = TempData["transactions"] as List<AccountTransaction>;
            return View(passbookVM);
        }

        /*public ActionResult DownloadCSV()
        {
            DownloadFile(TempData["transactions"] as List<AccountTransaction>);

        }*/

        private void DownloadFile(List<AccountTransaction> transactions)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Account No,");
            sb.Append("Transaction Type,");
            sb.Append("Amount,");
            sb.Append("Transaction Date,");
            sb.Append("\r\n");

            foreach (var record in transactions)
            {
                sb.Append(record.acnt.AccountNo + ",");
                sb.Append(record.TransactionType + ",");
                sb.Append(record.TransactionAmount + ",");
                sb.Append(record.TransactionDate + ",");
                sb.Append("\r\n");
            }

            File.WriteAllText(@"C:\Users\mahar\Downloads\Transactions.csv", sb.ToString());
        }

        private bool CheckSession()
        {
            if (Session["account"]!=null)
            {
                return true;
            }
            return false;
        }
    }
}
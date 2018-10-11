using mvcBankApp.Models.HomeModel;
using mvcBankApp.Models.RegistrationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcBankApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            HomeVM homeVM = new HomeVM();
            if (Session["account"] != null)
            {
                string acnt = Session["account"].ToString();
                
                homeVM.currentUser = acnt;
            }
            return View(homeVM);
        }
    }
}
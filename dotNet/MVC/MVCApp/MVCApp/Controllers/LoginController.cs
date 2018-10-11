using MVCApp.Models.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            LoginVM loginVM = new LoginVM();
            TempData["data"] = Request.QueryString["data"];
            return View(loginVM);
        }
        
        [HttpPost]
        public ActionResult Index(LoginVM vm)
        {
            LoginService loginService = new LoginService();

            if (loginService.AuthenticateUser(vm.UserName.ToLower(),vm.UserPassword.ToLower()))
            {
                Session["user"] = vm.UserName;
                Session.Timeout = 1;
                return RedirectToAction(TempData["data"].ToString(), "Contact");   
            }
            return View(vm);
        }
    }
}
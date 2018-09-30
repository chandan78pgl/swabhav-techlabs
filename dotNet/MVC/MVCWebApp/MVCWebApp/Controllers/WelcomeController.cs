using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebApp.Controllers
{
    public class WelcomeController:Controller
    {
        public string Index()
        {
            return "<h1>Hello this is the Welcome Page</h1>";
        }

        public ActionResult About()
        {
            ViewBag.Company = "Swabhav TechLabs";
            return View();
        }

        public ActionResult Career()
        {
            return View();
        }

        public ActionResult DisplayDept(int? id)
        {
            return Content("<h1>Display Department of id = " + id + "</h1>");
        }

        public ActionResult DisplayEmp(int empNo)
        {
            return Content("<h1>Display Employee of empNo = " + empNo + "</h1>");
        }
    }
}
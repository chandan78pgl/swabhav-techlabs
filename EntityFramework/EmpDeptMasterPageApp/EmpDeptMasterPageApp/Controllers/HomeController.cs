using EmpDeptMasterPageApp.Models.DepartmentModel;
using EmpDeptMasterPageApp.Models.EmployeeModel;
using EmpDeptMasterPageApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmpDeptMasterPageApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}
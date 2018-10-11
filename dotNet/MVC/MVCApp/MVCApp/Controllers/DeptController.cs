using MVCApp.Models.Dept;
using MVCApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class DeptController : Controller
    {
        // GET: Dept
        public ActionResult Index()
        {
            DeptService deptServices = new DeptService();
            DeptVM deptMV = new DeptVM { Employees = deptServices.Employees, Departments = deptServices.Departments };

            return View(deptMV);
        }

        [HttpPost]
        public ActionResult Index(DeptVM vm, string Selected)
        {
            DeptService deptService = new DeptService();

            vm.Employees = deptService.getEmployeesByDeptNo(Convert.ToInt32(Selected));
            vm.Departments = deptService.Departments;

            return View(vm);
        }
    }
}
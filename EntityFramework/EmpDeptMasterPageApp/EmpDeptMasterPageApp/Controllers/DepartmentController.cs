using EmpDeptMasterPageApp.Models.DepartmentModel;
using EmpDeptMasterPageApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmpDeptMasterPageApp.Controllers
{
    public class DepartmentController : Controller
    {
        private EmpDeptDBContext _empDeptDBContext = new EmpDeptDBContext();
        private DepartmentService _deptService;
        // GET: Department
        public ActionResult Index()
        {
            _deptService = new DepartmentService(_empDeptDBContext);
            DepartmentVM deptVM = new DepartmentVM();
            deptVM.Departments = _deptService.Departments;
            return View(deptVM);
        }

        public ActionResult Add()
        {
            AddVM addVM = new AddVM();
            return View(addVM);
        }

        [HttpPost]
        public ActionResult Add(AddVM vm)
        {
            _deptService = new DepartmentService(_empDeptDBContext);
            _deptService.AddDepartemnt(new Department { DName = vm.DName, Location = vm.Location, Description = vm.Description });
            return RedirectToAction("Index","Department");
        }

        public ActionResult Edit(Guid id)
        {
            _deptService = new DepartmentService(_empDeptDBContext);

            EditVM editVM = new EditVM();
            Department department = _deptService.SearchDepartment(id);

            editVM.Id = department.Id;
            editVM.DName = department.DName;
            editVM.Location = department.Location;
            editVM.Description = department.Description;

            return View(editVM);
        }

        [HttpPost]
        public ActionResult Edit(EditVM vm)
        {
            _deptService = new DepartmentService(_empDeptDBContext);
            Department department = new Department { Id = vm.Id, DName = vm.DName, Location = vm.Location, Description = vm.Description };
            _deptService.UpdateDepartment(department);
            return RedirectToAction("Index", "Department");
        }

        public ActionResult ViewEmployee(Guid id)
        {
            _deptService = new DepartmentService(_empDeptDBContext);

            Models.EmployeeModel.EmployeeVM empVM = new Models.EmployeeModel.EmployeeVM();

            empVM.Employees = _deptService.GetEmployees(id);

            return View(empVM);
        }
    }
}
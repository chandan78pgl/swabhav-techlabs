using EmpDeptMasterPageApp.Models.EmployeeModel;
using EmpDeptMasterPageApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmpDeptMasterPageApp.Controllers
{
    public class EmployeeController : Controller
    {
        private EmpDeptDBContext empDeptDBContext = new EmpDeptDBContext();
        private EmployeeService _empService;
        // GET: Employee
        public ActionResult Index()
        {
            _empService = new EmployeeService(empDeptDBContext);
            EmployeeVM empVM = new EmployeeVM();
            empVM.Employees = _empService.Employees;
            return View(empVM);
        }

        public ActionResult Add()
        {
            DepartmentService deptService = new DepartmentService(empDeptDBContext);
            AddVM addVM = new AddVM();
            addVM.Departments = deptService.Departments;
            return View(addVM);
        }

        [HttpPost]
        public ActionResult Add(AddVM vm)
        {
            _empService = new EmployeeService(empDeptDBContext);
            
            Employee employee = new Employee { EmpName = vm.EmpName, EmpJob = vm.EmpJob, EmpMGR = vm.EmpMGR, EmpComm = vm.EmpComm, EmpSalary = vm.EmpSalary, EmpHireDate = vm.EmpHireDate};

            _empService.AddEmployee(employee,vm.SelectedDepartment);

            return RedirectToAction("Index", "Employee");
        }

        public ActionResult Edit(Guid id)
        {
            DepartmentService deptService = new DepartmentService(empDeptDBContext);
            _empService = new EmployeeService(empDeptDBContext);

            EditVM editVM = new EditVM();
            Employee employee = _empService.SearchEmployee(id);
            editVM.Id = employee.Id;
            editVM.EmpName = employee.EmpName;
            editVM.EmpJob = employee.EmpJob;
            editVM.EmpMGR = employee.EmpMGR;
            editVM.EmpHireDate = employee.EmpHireDate;
            editVM.EmpSalary = employee.EmpSalary;
            editVM.EmpComm = employee.EmpComm;
            editVM.SelectedDepartment = employee.EmpDepartment.Id;
            editVM.Departments = deptService.Departments;

            return View(editVM);
        }

        [HttpPost]
        public ActionResult Edit(EditVM vm)
        {
            _empService = new EmployeeService(empDeptDBContext);
            
            Employee employee = new Employee {Id=vm.Id, EmpName = vm.EmpName, EmpJob = vm.EmpJob, EmpMGR = vm.EmpMGR, EmpComm = vm.EmpComm, EmpSalary = vm.EmpSalary, EmpHireDate = vm.EmpHireDate };

            _empService.UpdateEmployee(employee,vm.SelectedDepartment);

            return RedirectToAction("Index", "Employee");
        }
    }
}
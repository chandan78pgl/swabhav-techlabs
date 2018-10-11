using EmpDeptMasterPageApp.Models.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpDeptMasterPageApp.Services
{
    public class EmployeeService
    {
        private EmpDeptDBContext _empDeptDBContext;

        public EmployeeService(EmpDeptDBContext empDeptDBContext)
        {
            _empDeptDBContext = empDeptDBContext;
        }
        
        public void AddEmployee(Employee employee,Guid departmentId)
        {
            employee.EmpDepartment = _empDeptDBContext.Departments.Where((d) => d.Id == departmentId).Single();

            _empDeptDBContext.Employees.Add(employee);
            _empDeptDBContext.SaveChanges();
        }

        public List<Employee> Employees
        {
            get
            {
                return _empDeptDBContext.Employees.ToList();
            }
        }

        public Employee SearchEmployee(Guid id)
        {
            return _empDeptDBContext.Employees.Where((e)=>e.Id==id).Single();
        }

        public void UpdateEmployee(Employee employee,Guid departmentId)
        {
            Employee singleEmployee = _empDeptDBContext.Employees.Where((e)=>e.Id==employee.Id).Single();

            singleEmployee.Id = employee.Id;
            singleEmployee.EmpName = employee.EmpName;
            singleEmployee.EmpJob = employee.EmpJob;
            singleEmployee.EmpMGR = employee.EmpMGR;
            singleEmployee.EmpHireDate = employee.EmpHireDate;
            singleEmployee.EmpSalary = employee.EmpSalary;
            singleEmployee.EmpComm = employee.EmpComm;
            singleEmployee.EmpDepartment = _empDeptDBContext.Departments.Where((d)=>d.Id==departmentId).Single();

            _empDeptDBContext.SaveChanges();
        }
    }
}
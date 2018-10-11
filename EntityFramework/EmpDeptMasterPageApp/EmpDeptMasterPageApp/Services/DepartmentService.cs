using EmpDeptMasterPageApp.Models.DepartmentModel;
using EmpDeptMasterPageApp.Models.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpDeptMasterPageApp.Services
{
    public class DepartmentService
    {
        private EmpDeptDBContext _empDeptDBContext;

        public DepartmentService(EmpDeptDBContext empDeptDBContext)
        {
            _empDeptDBContext = empDeptDBContext;
        }

        public void AddDepartemnt(Department department)
        {
            _empDeptDBContext.Departments.Add(department);
            _empDeptDBContext.SaveChanges();
        }

        public List<Department> Departments
        {
            get
            {
                return _empDeptDBContext.Departments.ToList();
            }
        }

        public List<Employee> GetEmployees(Guid id)
        {
            return _empDeptDBContext.Employees.Where((e) => e.EmpDepartment.Id == id).ToList();
        }

        public Department SearchDepartment(Guid id)
        {
            return _empDeptDBContext.Departments.Where((d)=>d.Id==id).Single();
        }

        public void UpdateDepartment(Department department)
        {
            Department singleDepartment = _empDeptDBContext.Departments.Where((d) => d.Id == department.Id).Single();

            singleDepartment.Id = department.Id;
            singleDepartment.DName = department.DName;
            singleDepartment.Location = department.Location;
            singleDepartment.Description = department.Description;

            _empDeptDBContext.SaveChanges();
        }
    }
}
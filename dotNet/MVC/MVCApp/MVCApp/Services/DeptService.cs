using MVCApp.Models.Dept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp.Services
{
    public class DeptService
    {
        private List<Department> _departments = new List<Department>();
        private List<Employee> _employees = new List<Employee>();

        public DeptService()
        {
            _departments.Add(new Department { DeptNo = 10, DeptName = "IT" });
            _departments.Add(new Department { DeptNo = 20, DeptName = "SALES" });
            _departments.Add(new Department { DeptNo = 30, DeptName = "EC" });
            _departments.Add(new Department { DeptNo = 40, DeptName = "CIVIL" });

            _employees.Add(new Employee { EmpNo = 101, EmpName = "Chandan", Job = "developer",Salary=20000,DeptNo=10 });
            _employees.Add(new Employee { EmpNo = 102, EmpName = "Dharmesh", Job = "developer", Salary = 30000, DeptNo = 10 });
            _employees.Add(new Employee { EmpNo = 103, EmpName = "Foo", Job = "manager", Salary = 10000, DeptNo = 30 });
            _employees.Add(new Employee { EmpNo = 104, EmpName = "Bar", Job = "clerk", Salary = 15000, DeptNo = 40 });
            _employees.Add(new Employee { EmpNo = 105, EmpName = "Smith", Job = "manager", Salary = 18000, DeptNo = 20 });
            _employees.Add(new Employee { EmpNo = 106, EmpName = "John", Job = "execution", Salary = 12000, DeptNo = 20 });
            _employees.Add(new Employee { EmpNo = 107, EmpName = "Tar", Job = "president", Salary = 14000, DeptNo = 40 });
        }

        public List<Department> Departments
        {
            get
            {
                return _departments;
            }
        }

        public List<Employee> Employees
        {
            get
            {
                return _employees;
            }
        }

        public string SearchDept(Int32 deptNo)
        {
            foreach (Department dept in _departments)
            {
                if (dept.DeptNo==deptNo)
                {
                    return dept.DeptName;
                }
            }
            return null;
        }

        public List<Employee> getEmployeesByDeptNo(Int32 deptNo)
        {
            List<Employee> matchedEmployees = new List<Employee>();
            matchedEmployees = _employees.Where((employee) => employee.DeptNo == deptNo).ToList();

            return matchedEmployees;
        }
    }
}
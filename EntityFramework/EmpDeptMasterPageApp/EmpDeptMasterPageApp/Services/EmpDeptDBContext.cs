using EmpDeptMasterPageApp.Models.DepartmentModel;
using EmpDeptMasterPageApp.Models.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmpDeptMasterPageApp.Services
{
    public class EmpDeptDBContext:DbContext
    {
        public DbSet<Department> Departments { set; get; }
        public DbSet<Employee> Employees { set; get; }
    }
}
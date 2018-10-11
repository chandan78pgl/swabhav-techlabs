using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp.Models.Dept
{
    public class DeptVM
    {
        public List<Department> Departments { set; get; }
        public List<Employee> Employees { set; get; }
        public string Selected { set; get; }
    }
}
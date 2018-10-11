using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp.Models.Dept
{
    public class Employee
    {
        public Int32 EmpNo { set; get; }
        public String EmpName { set; get; }
        public String Job { set; get; }
        public Double Salary { set; get; }
        public Int32 DeptNo { set; get; }
    }
}
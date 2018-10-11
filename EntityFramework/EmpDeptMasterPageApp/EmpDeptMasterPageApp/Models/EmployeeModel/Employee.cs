using EmpDeptMasterPageApp.Models.DepartmentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpDeptMasterPageApp.Models.EmployeeModel
{
    public class Employee
    {
        public Guid Id { set; get; }
        public string EmpName { set; get; }
        public string EmpJob { set; get; }
        public string EmpMGR { set; get; }
        public string EmpHireDate { set; get; }
        public int EmpSalary { set; get; }
        public int EmpComm { set; get; }
        public virtual Department EmpDepartment { get; set; }

        public Employee()
        {
            Id = Guid.NewGuid();
        }
    }
}
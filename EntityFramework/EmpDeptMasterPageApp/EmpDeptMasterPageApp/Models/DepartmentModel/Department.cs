using EmpDeptMasterPageApp.Models.EmployeeModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace EmpDeptMasterPageApp.Models.DepartmentModel
{
    public class Department
    {
        public virtual List<Employee> Employees { set; get; }
        [Key]
        public Guid Id { set; get; }
        public String DName { set; get; }
        public String Location { set; get; }
        public String Description { set; get; }

        public Department()
        {
            Id = Guid.NewGuid();
        }
    }
}
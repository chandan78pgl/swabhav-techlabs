using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpDeptMasterPageApp.Models.DepartmentModel
{
    public class EditVM
    {
        public Guid Id { set; get; }
        public String DName { set; get; }
        public String Location { set; get; }
        public String Description { set; get; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpDeptMapping
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

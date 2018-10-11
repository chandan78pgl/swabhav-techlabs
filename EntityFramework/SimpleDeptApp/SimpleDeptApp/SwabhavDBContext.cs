using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDeptApp
{
    public class SwabhavDBContext:DbContext
    {
        public DbSet<Department> Departments { set; get; }
    }
}

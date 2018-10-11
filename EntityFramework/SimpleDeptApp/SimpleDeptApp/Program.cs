using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDeptApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            SwabhavDBContext swabhavDBContext = new SwabhavDBContext();

            swabhavDBContext.Departments.Add(new Department { DName="IT",Location="SURAT"});
            swabhavDBContext.SaveChanges();
            //UpdateDepartment(swabhavDBContext);
            //RetrieveAllDepartments(swabhavDBContext);
        }

        private static void UpdateDepartment(SwabhavDBContext swabhavDBContext)
        {
            Department department=swabhavDBContext.Departments.Where((d)=>d.Id==2).Single();
            Console.WriteLine(department.DName);
            department.DName = "Elite";
            swabhavDBContext.SaveChanges();
        }

        private static void RemoveDepartment(SwabhavDBContext swabhavDBContext)
        {
            Department department = swabhavDBContext.Departments.Where((d) => d.Id == 2).Single();
            Console.WriteLine(department.DName);
            swabhavDBContext.Departments.Remove(department);
            swabhavDBContext.SaveChanges();
        }

        private static void RetrieveAllDepartments(SwabhavDBContext swabhavDBContext)
        {
            foreach (Department department in swabhavDBContext.Departments)
            {
                Console.WriteLine(department.DName);
            }
        }
    }
}

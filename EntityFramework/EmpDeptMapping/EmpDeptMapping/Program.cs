using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpDeptMapping
{
    public class Program
    {
        static void Main(string[] args)
        {
            SwabhavDBContext swabhavDBContext = new SwabhavDBContext();

            /*Department department = new Department();
            department.Employees = new List<Employee>();
            department.Employees.Add(new Employee { EmpName="Chandan",EmpJob="Developer",EmpMGR="None",EmpComm=0,EmpHireDate="25/11/2018",EmpSalary=20000});
            department.DName = "IT";
            department.Location = "SURAT";
            department.Description = "Hello IT Department";*/

            //Department department = swabhavDBContext.Departments.Where((d) => d.Id == new Guid("3D099213-9BFA-4E31-A716-44E1E4540B01")).Single();
            //Employee employee = new Employee { EmpName = "Foo Bar", EmpJob = "Manager", EmpMGR = "None", EmpComm = 0, EmpHireDate = "28/09/2018", EmpSalary = 2000,EmpDepartment=department};

            //ChildToParent(swabhavDBContext);
            IQueryAbleExample(swabhavDBContext);
            IEnumerAbleExample(swabhavDBContext);
            //swabhavDBContext.Employees.Add(employee);
            //swabhavDBContext.SaveChanges();
        }

        private static void DeleteEmployee(SwabhavDBContext swabhavDBContext)
        {
            Department department = swabhavDBContext.Departments.Where((d) => d.Id == new Guid("00000000-0000-0000-0000-000000000000")).Single();
            Console.WriteLine(department.DName);

            swabhavDBContext.Departments.Remove(department);
            swabhavDBContext.SaveChanges();
        }

        private static void ParentToChild(SwabhavDBContext swabhavDBContext)
        {
            Department department = swabhavDBContext.Departments.Where((d) => d.Id == new Guid("00000000-0000-0000-0000-000000000000")).Single();
            IEnumerable<Employee> myEmployees = department.Employees.Select((e) => e);

            foreach (var employee in myEmployees)
            {
                Console.WriteLine("Employee Name: {0}", employee.EmpName);
            }
        }

        private static void ChildToParent(SwabhavDBContext swabhavDBContext)
        {
            Employee employee = swabhavDBContext.Employees.Where((e) => e.Id == new Guid("CFB036F3-4966-48D8-A77E-94238B661732")).Single();

            Console.WriteLine("Department Id: {0}\n Department Name: {1}", employee.EmpDepartment.Id, employee.EmpDepartment.DName);
        }

        private static void IQueryAbleExample(SwabhavDBContext swabhavDBContext)
        {
            var employees = swabhavDBContext.Employees.Where((e) => e.EmpName.StartsWith("F"))
                                                       .ToList()
                                                       .Select((e) => new
                                                       {
                                                           FirstName = e.EmpName.Split(' ')[0],
                                                           EmpId = e.Id
                                                       });
            foreach (var employee in employees)
            {
                Console.WriteLine("First Name: {0}\n EmpId: {1}", employee.FirstName, employee.EmpId);
            }
        }

        private static void IEnumerAbleExample(SwabhavDBContext swabhavDBContext)
        {
            var employees = swabhavDBContext.Employees.ToList()
                                                       .Where((e) => e.EmpName.StartsWith("F"))
                                                       .Select((e) => new
                                                       {
                                                           FirstName = e.EmpName.Split(' ')[0],
                                                           EmpId = e.Id
                                                       });
            foreach (var employee in employees)
            {
                Console.WriteLine("First Name: {0}\n EmpId: {1}", employee.FirstName, employee.EmpId);
            }
        }
    }
}

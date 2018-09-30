using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLinQApp
{
    public class TestLinQ
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee(7839,"KING","PRESIDENT","none","17-NOV-81", 5000, 0, 10));
            employees.Add(new Employee(7698, "BLAKE", "MANAGER", "7839", "1-MAY-81", 2850, 0, 30));
            employees.Add(new Employee(7782, "CLARK", "MANAGER", "7839", "9-JUN-81", 2450, 0, 10));
            employees.Add(new Employee(7566, "JONES", "MANAGER", "7839", "2-APR-81", 2975, 0, 20));
            employees.Add(new Employee(7654, "MARTIN", "SALESMAN", "7698", "28-SEP-81", 1250, 1400, 30));
            employees.Add(new Employee(7499, "ALLEN", "SALESMAN", "7698", "20-FEB-81", 1600, 300, 30));
            employees.Add(new Employee(7844, "TURNER", "SALESMAN","7698", "8-SEP-81", 1500, 0, 30));
            employees.Add(new Employee(7900, "JAMES", "CLERK", "7698", "3-DEC-81", 950, 0, 30));
            employees.Add(new Employee(7521, "WARD", "SALESMAN", "7698", "22-FEB-81", 1250, 500, 30));
            employees.Add(new Employee(7902, "FORD", "ANALYST", "7566", "3-DEC-81", 3000, 0, 20));
            employees.Add(new Employee(7369, "SMITH", "CLERK", "7902", "17-DEC-80", 800, 0, 20));
            employees.Add(new Employee(7788, "SCOTT", "ANALYST", "7566", "09-DEC-82", 3000, 0, 20));
            employees.Add(new Employee(7876, "ADAMS", "CLERK", "7788", "12-JAN-83", 1100, 0, 20));
            employees.Add(new Employee(7934, "MILLER", "CLERK", "7782", "23-JAN-82", 1300, 0, 10));

            
            IEnumerable<Employee> myEmployees = employees.Select<Employee,Employee>((employee) => employee);
            //PrintEmployees(myEmployees);

            //Employees Having department 10 and Order By Salary
            IEnumerable<Employee> myEmployeesOfDept10 = myEmployees.Where<Employee>((employee)=>employee.EmpDeptNo==10).OrderByDescending<Employee,Int32>((employee)=>employee.EmpSalary);
            //PrintEmployees(myEmployeesOfDept10);

            //Employees Having name starting from 'A'
            IEnumerable<Employee> myEmployeesOfNameA = myEmployees.Where<Employee>((employee)=>employee.EmpName.StartsWith("A"));
            //PrintEmployees(myEmployeesOfNameA);

            //Employees Having Commission null
            IEnumerable<Employee> myEmployeesOfNoComm = myEmployees.Where<Employee>((employee)=>employee.EmpComm==0);
            //PrintEmployees(myEmployeesOfNoComm);

            //Employees Not in Dept 10
            IEnumerable<Employee> myEmployeesOfNotDept10 = myEmployees.Where<Employee>((employee) => employee.EmpDeptNo != 10);
            //PrintEmployees(myEmployeesOfNotDept10);

            //Employees With SALARY and CTC
            var myEmployeesWithCTC = employees.Select((employee)=>new { empName = employee.EmpName, empCTC = (employee.EmpSalary + employee.EmpComm) * 12 });
            /*Console.WriteLine(myEmployeesWithCTC.Count());
            foreach (var item in myEmployeesWithCTC)
            {
                Console.WriteLine("Employee Name: {0}\n CTC: {1}",item.empName,item.empCTC);
            } */

            //Employee Name and Department
            var myEmployeesNameAndDept= employees.Select((employee) => new { empName = employee.EmpName, empDept = employee.EmpDeptNo });
            /*Console.WriteLine(myEmployeesNameAndDept.Count());
            foreach (var item in myEmployeesNameAndDept)
            {
                Console.WriteLine("Employee Name: {0}\n Department No: {1}", item.empName, item.empDept);
            }*/

            //Employees Distinct Department
            var myEmployeesDistinctDept = employees.Select((employee) => new {empDept = employee.EmpDeptNo}).Distinct();
            /*Console.WriteLine(myEmployeesDistinctDept.Count());
            foreach (var item in myEmployeesDistinctDept)
            {
                Console.WriteLine("Department No: {0}",item.empDept);
            }*/
            
            //Employees with HireDate and Tenure
            var myEmployeesTenure = employees.Select((employee) => new { empHiredate = employee.EmpHireDate, Tenure = (DateTime.Now.Year-Convert.ToDateTime(employee.EmpHireDate).Year) });
            /*Console.WriteLine(myEmployeesTenure.Count());
            foreach (var item in myEmployeesTenure)
            {
                Console.WriteLine("HireDate No= {0} | Tenure= {1}",item.empHiredate,item.Tenure);
            }*/

            //Employee who are MANAGERs
            var myEmployeesWhoRManagers = employees.Where<Employee>((employee) => employee.EmpJob.Equals("MANAGER"));
            //PrintEmployees(myEmployeesWhoRManagers);

            //Employee Top 3 SalariedEmployee
            var myEmployeesTop3 = myEmployees.OrderByDescending((employee) =>employee.EmpSalary).Take(3);
            //PrintEmployees(myEmployeesTop3);

            //Employee in the Department of SCOTT
            var myEmployeesDeptScott = myEmployees.Where((employee)=>employee.EmpName=="SCOTT").Select((employee)=>employee.EmpDeptNo);
            int deptNo=0;
            /*foreach(var item in myEmployeesDeptScott)
            {
                if (item!=0)
                {
                    deptNo = item;
                }
            }
            Console.WriteLine(deptNo);*/
            var myEmployeeOfScottDept = myEmployees.Where((employee) => employee.EmpDeptNo == deptNo);
            //PrintEmployees(myEmployeeOfScottDept);
            
            //Employees designation of SMITH
            var myEmployeesJobSmith = myEmployees.Where((employee) => employee.EmpName == "SMITH").Select((employee) => employee.EmpJob);
            var myEmployeesOfSmithJob = myEmployees.Where((employee) => employee.EmpJob == GetData(myEmployeesJobSmith));
            //PrintEmployees(myEmployeesOfSmithJob);

            var myEmployeesNotMaxSal = myEmployees.Where((employee) => employee.EmpSalary != myEmployees.Max((employee1) => employee1.EmpSalary));
            var myEmployees2ndMaxSal = myEmployees.Where((employee)=>employee.EmpSalary==myEmployeesNotMaxSal.Max((employee2)=>employee2.EmpSalary));
            //PrintEmployees(myEmployees2ndMaxSal);

            //var noOfEmpInEachDept = myEmployees.GroupBy((employee)=>employee.EmpDeptNo).SelectMany((employee)=>employee);
            var noOfEmpInEachDept = from employee in myEmployees
                                    group employee by employee.EmpDeptNo into newGroup
                                    orderby newGroup.Key
                                    select newGroup;
            /*foreach (var nameGroup in noOfEmpInEachDept)
            {
                Console.WriteLine("Department No = {0} | {1}",nameGroup.Key,nameGroup.Count());
            }*/

            var noOfEmpInEachJob = myEmployees.GroupBy((employee) => employee.EmpJob).Select((group) => new { Job = group.Key, headCount = group.Count() }).Where((group)=>group.headCount>2);

            /*foreach (var item in noOfEmpInEachJob)
            {
                Console.WriteLine("HeadCount = {0} | Job = {1}",item.headCount,item.Job);
            }*/

            var noOfEmpGroupByJobDept = myEmployees.GroupBy((employee) => new { employee.EmpJob, employee.EmpDeptNo })
                                                   .Select((group)=>new { Job=group.Key.EmpJob,Dept=group.Key.EmpDeptNo, Count=group.Count()})
                                                   .OrderBy((data)=>data.Dept);
            foreach (var item in noOfEmpGroupByJobDept)
            {
                Console.WriteLine("Department = {0} | Job = {1} | HeadCount={2}", item.Dept, item.Job,item.Count);
            }
        }

        private static void PrintEmployees(IEnumerable<Employee> employees)
        {
            Console.WriteLine(employees.Count());
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }

        private static string GetData(IEnumerable<string> collection)
        {
            foreach (var item in collection)
            {
                if (item!="")
                {
                    return item;
                }
            }
            return "";
        }
    }
}

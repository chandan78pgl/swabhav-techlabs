using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLinQApp
{
    public class Employee
    {
        private int _empNo;
        private string _empName;
        private string _empJob;
        private string _empMGR;
        private string _empHireDate;
        private int _empSalary;
        private int _empComm;
        private int _empDeptNo;

        public Employee(int empNo, string empName, string empJob, string empMGR, string empHireDate, int empSalary, int empComm, int empDeptNo)
        {
            _empNo = empNo;
            _empName = empName;
            _empJob = empJob;
            _empMGR = empMGR;
            _empHireDate = empHireDate;
            _empSalary = empSalary;
            _empComm = empComm;
            _empDeptNo = empDeptNo;
        }

        public int EmpNo
        {
            get
            {
                return _empNo;
            }
        }

        public string EmpName
        {
            get
            {
                return _empName;
            }
        }

        public string EmpJob
        {
            get
            {
                return _empJob;
            }
        }

        public string EmpMGR
        {
            get
            {
                return _empMGR;
            }
        }

        public string EmpHireDate
        {
            get
            {
                return _empHireDate;
            }
        }

        public int EmpSalary
        {
            get
            {
                return _empSalary;
            }
        }

        public int EmpComm
        {
            get
            {
                return _empComm;
            }
        }

        public int EmpDeptNo
        {
            get
            {
                return _empDeptNo;
            }
        }

        public override string ToString()
        {
            return "Employee No: "+EmpNo
                +"\n Employee Name: "+EmpName
                +"\n JOB: "+EmpJob
                +"\n Manager: "+EmpMGR
                +"\n HireDate: "+EmpHireDate
                +"\n Salary: "+EmpSalary
                +"\n Commission: "+EmpComm
                +"\n Department No: "+EmpDeptNo
                +"\n\n";
        }
    }
}

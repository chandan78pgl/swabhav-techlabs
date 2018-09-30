using System;
using System.Collections.Generic;
using System.Text;

namespace CollegeApp
{
    class Professor : Person, SalariedEmployee
    {
        private Branch _branch;
        private int _lectures;
        private double _salary;
        private int _semester;

        public Professor(int id, string name, string address, string dateOfBirth, Branch branch, int lectures,double salary, int semester) : base(id, name, address, dateOfBirth)
        {
            _branch = branch;
            _lectures = lectures;
            _salary = salary;
            _semester = semester;
        }

        public String GetBranch
        {
            get
            {
                return _branch.ToString();
            }
        }

        public double Salary
        {
            get
            {
                return _salary;
            }
        }

        public Int32 Semester
        {
            get
            {
                return _semester;
            }
        }

        public String GiveSalaryLogic()
        {
            return "No. of Lectures taken: " + _lectures
                    + "\n Total salary: "+CalculateSalary();
        }

        private Double CalculateSalary()
        {
            return Salary * _lectures;
        }

        public override string ToString()
        {
            return "Id: " + Id
                +"\n Name: " + Name
                +"\n Address: "+Address
                +"\n DateOfBirth: "+DateOfBirth
                +"\n Branch: "+GetBranch
                +"\n Semester: "+Semester
                +"\n Basic Salary: "+Salary
                +"\n Salary Logic: \n"+GiveSalaryLogic();
        }
    }
}

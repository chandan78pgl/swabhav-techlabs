using System;
using System.Collections.Generic;
using System.Text;

namespace CollegeApp
{
    class Student : Person
    {
        private Branch _branch;
        private int _semester;
        public Student(int id, string name, string address, string dateOfBirth,Branch branch,int semester) : base(id, name, address, dateOfBirth)
        {
            _branch = branch;
            _semester = semester;
        }

        public String GetBranch
        {
            get
            {
                return _branch.ToString();
            }
        }

        public Int32 Semester
        {
            get
            {
                return _semester;
            }
        }

        public override string ToString()
        {
            return "Id: "+Id
                +"\n Name: "+Name
                +"\n Address: "+Address
                +"\n DateOfBirth: "+DateOfBirth
                +"\n Branch: "+GetBranch
                +"\n Semester: "+Semester;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp.StudentClass
{
    public class Student
    {
        private int _rollNo;
        private string _name;
        private int _standard;

        public Student(int rollNo,string name,int standard)
        {
            this._rollNo = rollNo;
            this._name = name;
            this._standard = standard;
        }

        public Int32 RollNo
        {
            get
            {
                return this._rollNo;
            }
        }

        public String Name
        {
            get
            {
                return this._name;
            }
        }

        public Int32 Standard
        {
            get
            {
                return this._standard;
            }
        }

        public override bool Equals(object obj)
        {
            Student other = (Student)obj;

            if(other.RollNo == this.RollNo)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return this.RollNo.GetHashCode();
        }

        public override string ToString()
        {
            return "Roll No: "+this.RollNo
                +" - Name: "+this.Name
                +" - Standard: "+this.Standard
                +" ";
        }
    }
}

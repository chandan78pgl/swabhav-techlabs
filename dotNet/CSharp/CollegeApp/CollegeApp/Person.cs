using System;
using System.Collections.Generic;
using System.Text;

namespace CollegeApp
{
    public abstract class Person
    {
        private int _id;
        private string _name;
        private string _address;
        private DateTime _dateOfBirth;

        public Person(int id,string name,string address, string dateOfBirth)
        {
            _id = id;
            _name = name;
            _address = address;
            _dateOfBirth = Convert.ToDateTime(dateOfBirth);
        }

        public Int32 Id
        {
            get
            {
                return _id;
            }
        }

        public String Name
        {
            get
            {
                return _name;
            }
        }

        public String Address
        {
            get
            {
                return _address;
            }
        }

        public String DateOfBirth
        {
            get
            {
                return _dateOfBirth.ToLongDateString();
            }
        }
        
    }
}

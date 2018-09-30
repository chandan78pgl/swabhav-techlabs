using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CustomerApp
{
    public class Customer
    {
        private static int _tempId;
        private int _id;
        private string _firstname;
        private string _lastname;
        private DateTime _dateOfBirth;

        static Customer()
        {
            _tempId = 100;
        }

        public Customer(string firstName,string lastName,string dateOfBirth)
        {
            _tempId++;
            _id = _tempId;
            _firstname = firstName;
            _lastname = lastName;
            _dateOfBirth = ConvertToDate(dateOfBirth);
            CalculateAge();
        }

        public Int32 Id
        {
            get
            {
                return _id;
            }
        }

        public String FirstName
        {
            get
            {
                return _firstname;
            }
        }

        public String LastName
        {
            get
            {
                return _lastname;
            }
        }

        public String DateOfBirth
        {
            get
            {
                return _dateOfBirth.ToLongDateString();
            }
        }

        private DateTime ConvertToDate(string date)
        {
            return DateTime.Parse(date);
        }

        public Int32 CalculateAge()
        {
            DateTime date = DateTime.Now;
            Int32 curr_year = date.Year;
            Int32 dob_year = _dateOfBirth.Year;

            return curr_year-dob_year;
        }

        public override string ToString()
        {
            return "Customer ID: "+_id
                +"\n First Name: "+_firstname
                +"\n Last Name: "+_lastname
                +"\n Date Of Birth: "+DateOfBirth
                +"\n Age: "+CalculateAge();
        }
    }
}

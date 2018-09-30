using System;
using System.Collections.Generic;
using System.Text;

namespace ContactManagerApp
{
    [Serializable]
    public class Contact
    {
        private string _name;
        private string _number;

        public Contact(string name,string number)
        {
            _name = name;
            _number = number;
        }

        public override string ToString()
        {
            return "Contact Name: "+_name
                +"\n Contact Number: "+_number;
        }
    }
}

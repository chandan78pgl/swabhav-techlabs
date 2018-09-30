using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactCore
{
    [Serializable]
    public class Contact
    {
        private string _name;
        private string _number;

        public Contact(string name, string number)
        {
            _name = name;
            _number = number;
        }

        public String Name
        {
            get
            {
                return _name;
            }
        }

        public String Number
        {
            get
            {
                return _number;
            }
        }

        public override string ToString()
        {
            return "Contact Name: " + _name
                + "\n Contact Number: " + _number;
        }
    }
}

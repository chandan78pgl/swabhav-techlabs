using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstApiApp.Models.ContactModel
{
    public class Contact
    {
        public Guid Id { set; get; }
        public String Name { set; get; }
        public String Number { set; get; }

        public Contact()
        {
            Id = Guid.NewGuid();
        }
    }
}
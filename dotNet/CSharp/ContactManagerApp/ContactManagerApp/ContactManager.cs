using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace ContactManagerApp
{
    class ContactManager
    {
        private List<Contact> _contacts;

        public ContactManager()
        {
            _contacts = StoreContact.getObjectFromFile();
        }

        public void AddContact(string name,string number)
        {
            _contacts.Add(new Contact(name, number));
            StoreContact.saveObjectToFile(_contacts);
        }

        public List<Contact> Contacts
        {
            get
            {
                return _contacts;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactCore
{
    public class ContactManager
    {
        private List<Contact> _contacts = new List<Contact>();

        public ContactManager()
        {
            _contacts = DatabaseStore.GetDataFromDatabase();
        }

        public void AddContact(string name, string number)
        {
            Contact contact = new Contact(name, number);
            _contacts.Add(contact);
            DatabaseStore.SaveDataToDatabase(contact);
        }

        public List<Contact> SearchContact(string contactName)
        {
            List<Contact> matchedContacts = new List<Contact>();
            foreach (Contact contact in _contacts)
            {
                if (contact.Name.ToLower().Contains(contactName.ToLower()))
                {
                    matchedContacts.Add(contact);
                }
            }
            return matchedContacts;
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

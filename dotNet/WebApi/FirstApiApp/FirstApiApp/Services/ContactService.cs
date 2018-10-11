using FirstApiApp.Models.ContactModel;
using FirstApiApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstApiApp.Services
{
    public class ContactService
    {
        public List<Contact> Contacts { set; get; }
        private static ContactService _contactService;

        public static ContactService GetInstance()
        {
            if (_contactService==null)
            {
                return _contactService = new ContactService();
            }
            return _contactService;
        }
        
        public ContactService()
        {
            Contacts = new List<Contact>();
            Contacts.Add(new Contact { Name = "chandan", Number = "8460551251" });
            Contacts.Add(new Contact { Name = "dharmesh", Number = "8525241541" });
            Contacts.Add(new Contact { Name = "foo", Number = "8780412101" });
            Contacts.Add(new Contact { Name = "bar", Number = "8468984661" });
        }

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }

        public Contact SearchContact(String Name)
        {
            foreach (var contact in Contacts)
            {
                if (contact.Name==Name)
                {
                    return contact;
                }
            }

            return null;
        }
    }
}
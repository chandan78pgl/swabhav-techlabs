using MVCApp.Models.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp.Services
{
    public class ContactService
    {
        private ContactDBContext _contactDbContext;
        
        public ContactService()
        {
            _contactDbContext = new ContactDBContext();
        }

        public void AddContact(int id,string contactNo, string fName, string lName, string email)
        {
            _contactDbContext.Contacts.Add(new Contact { Id = id, ContactNo = contactNo, FName = fName, LName = lName, Email = email });
            _contactDbContext.SaveChanges();
        } 

        public List<Contact> Contacts
        {
            get
            {
                return _contactDbContext.Contacts.ToList();
            }
        }

        public Contact SearchContact(int id)
        {
            return _contactDbContext.Contacts.Where((c) => c.Id == id).Single();
        }

        public void UpdateContact(Contact contact)
        {
            Contact singleContact=_contactDbContext.Contacts.Where((c) => c.Id == contact.Id).Single();

            singleContact.Id = contact.Id;
            singleContact.ContactNo = contact.ContactNo;
            singleContact.FName = contact.FName;
            singleContact.LName = contact.LName;
            singleContact.Email = contact.Email;

            _contactDbContext.SaveChanges();
        }
    }
}
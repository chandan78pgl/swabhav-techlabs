using MVCApp.Models.Contact;
using MVCApp.Models.Login;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace MVCApp.Services
{
    public class ContactDBContext:DbContext
    {
        public DbSet<Contact> Contacts { set; get; }
        public DbSet<User> Users { set; get; }
    }
}
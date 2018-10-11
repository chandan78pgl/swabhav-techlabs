using FirstApiApp.Models.ContactModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FirstApiApp.Repository
{
    public class ContactDBContext:DbContext
    {
        public DbSet<Contact> Contacts { set; get; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TenantManagementApi.Models.Tenant
{
    public class ContactDetail
    {
        public Guid Id { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string PhoneNumber { set; get; }
        public string Email { set; get; }

        public virtual User UserDetails { set; get; }

        public ContactDetail()
        {
            Id = Guid.NewGuid();
        }
    }
}
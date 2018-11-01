using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using TenantManagementApi.Models.Login;
using TenantManagementApi.Models.MasterModel;

namespace TenantManagementApi.Models.Tenant
{
    public class User
    {
        public Guid Id { set; get; }
        public string Name { set; get; }
        public string Role { set; get; }
        public string Currency { set; get; }
        public string ShortName { set; get; }
        public string WebUrl { set; get; }
        
        public virtual Master UserMasterDetails { set; get; }
        public virtual LoginDetail UserLoginDetails { set; get; }
        public virtual List<Subscription> UserSubscriptionDetails { set; get; }
        public virtual List<Address> AddressDetail { set; get; }
        public virtual List<ContactDetail> ContactDetail { set; get; }

        public User()
        {
            Id = Guid.NewGuid();
        }
    }
}
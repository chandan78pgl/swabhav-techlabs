using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TenantManagementApi.Models.MasterModel;

namespace TenantManagementApi.Models.Tenant
{
    public class Subscription
    {
        public Guid Id { set; get; }
        public string Type { set; get; }
        public int NoOfNamedUsers { set; get; }

        public virtual User UserDetails { set; get; }
        public virtual List<Module> UserModules { set; get; }
        public virtual List<Service> UserServices { set; get; }

        public Subscription()
        {
            Id = Guid.NewGuid();
        }
    }
}
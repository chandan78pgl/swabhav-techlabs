using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TenantManagementApi.Models.Tenant;

namespace TenantManagementApi.Models.MasterModel
{
    public class Module
    {
        public Guid Id { set; get; }
        public string Name { set; get; }

        public virtual Subscription UserSubscriptionDetails { set; get; }

        public Module()
        {
            Id = Guid.NewGuid();
        }
    }
}
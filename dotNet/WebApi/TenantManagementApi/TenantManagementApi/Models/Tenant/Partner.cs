using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TenantManagementApi.Models.Tenant
{
    public class Partner
    {
        public Guid Id { set; get; }
        public string Name { set; get; }

        public Partner()
        {
            Id = Guid.NewGuid();
        }
    }
}
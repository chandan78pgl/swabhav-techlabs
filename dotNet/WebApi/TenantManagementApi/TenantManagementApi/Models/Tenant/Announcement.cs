using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TenantManagementApi.Models.Tenant
{
    public class Announcement
    {
        public Guid Id { set; get; }
        public DateTime Date { set; get; }
        public string Title { set; get; }
        public string Description { set; get; }

        public Announcement()
        {
            Id = Guid.NewGuid();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TenantManagementApi.Models.DTO
{
    public class SubscriptionDetailsDTO
    {
        public Guid Id { set; get; }
        public string Type { set; get; }
        public int NoOfNamedUsers { set; get; }
        public List<string> Modules { set; get; }
        public List<string> Services { set; get; }
    }
}
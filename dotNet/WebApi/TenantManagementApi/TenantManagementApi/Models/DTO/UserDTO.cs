using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TenantManagementApi.Models.DTO
{
    public class UserDTO
    {
        public UserDetailsDTO UserDetails { set; get; }
        public LoginDetailsDTO LoginDetails { set; get; }
        public SubscriptionDetailsDTO SubscriptionDetails { set; get; }
    }
}
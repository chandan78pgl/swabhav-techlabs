using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TenantManagementApi.Repository.Specification
{
    public class UserSearchCriteria
    {
        public Guid UserId { set; get; }
        public string UserName { set; get; }
    }
}
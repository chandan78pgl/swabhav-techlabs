using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TenantManagementApi.Repository.Specification
{
    public class LoginDetailSearchCriteria
    {
        public Guid LoginDetailId { set; get; }
        public string LoginDetailUsername { set; get; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TenantManagementApi.Models.Tenant;

namespace TenantManagementApi.Repository
{
    public interface ITenantRepository<T>:IRepository<User>
    {

    }
}
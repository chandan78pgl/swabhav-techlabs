using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TenantManagementApi.Models.Login;

namespace TenantManagementApi.Repository
{
    public interface ILoginRepository<T>:IRepository<LoginDetail>
    {
        T GetByUsername(string loginUsername);
        bool AuthenticateUser(string loginUsername,string loginPassword);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TenantManagementApi.Models.DTO
{
    public class LoginDetailsDTO
    {
        public Guid Id { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
        public string Captcha { set; get; }
    }
}
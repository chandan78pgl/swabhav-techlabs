using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using TenantManagementApi.Models.Tenant;

namespace TenantManagementApi.Models.Login
{
    public class LoginDetail
    {
        [Key, ForeignKey("UserDetails")]
        public Guid Id { set; get; }
        [Required]
        [Index(IsUnique =true)]
        [StringLength(50)]
        public string Username { set; get; }
        public string Password { set; get; }
        public string Captcha { set; get; }

        public virtual User UserDetails { set; get; }

        public LoginDetail()
        {
            Id = Guid.NewGuid();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using TenantManagementApi.Models.Tenant;

namespace TenantManagementApi.Models.MasterModel
{
    public class Master
    {
        [Key, ForeignKey("UserDetails")]
        public Guid Id { set; get; }

        public virtual User UserDetails { set; get; }
        public virtual List<Module> ModuleMaster { set; get; }
        public virtual List<Service> ServiceMaster { set; get; }
        public virtual List<Partner> PartnerMaster { set; get; }

        public Master()
        {
            Id = Guid.NewGuid();
        }
    }
}
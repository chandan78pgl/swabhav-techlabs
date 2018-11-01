using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TenantManagementApi.Models.Tenant;
using TenantManagementApi.Models.Login;
using TenantManagementApi.Models.MasterModel;

namespace TenantManagementApi.Repository
{
    public class TenantDBContext:DbContext
    {
        public DbSet<User> Users { set; get; }
        public DbSet<LoginDetail> LoginDetails { set; get; }
        public DbSet<Partner> Partners { set; get; }
        public DbSet<Subscription> Subscriptions { set; get; }
        public DbSet<Master> Masters { set; get; }
        public DbSet<Module> Modules { set; get; }
        public DbSet<Service> Services { set; get; }
        public DbSet<Announcement> Announcements { set; get; }
    }
}
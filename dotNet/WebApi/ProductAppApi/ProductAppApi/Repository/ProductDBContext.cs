using ProductAppApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProductAppApi.Repository
{
    public class ProductDBContext : DbContext
    {
        public DbSet<Product> Products { set; get; }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToManyMapApp
{
    public class SwabhavDBContext:DbContext
    {
        public DbSet<Movie> Movies { set; get; }
        public DbSet<Actor> Actors { set; get; }
    }
}

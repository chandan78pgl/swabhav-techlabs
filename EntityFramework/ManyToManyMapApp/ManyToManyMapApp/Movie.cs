using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToManyMapApp
{
    public class Movie
    {
        public virtual List<Actor> Actors { set; get; }
        public Guid Id { set; get; }
        public String Name { set; get; }
        public String ReleaseDate { set; get; }

        public Movie()
        {
            Id = Guid.NewGuid();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToManyMapApp
{
    public class Actor
    {
        public virtual List<Movie> Movies { set; get; }
        public Guid Id { set; get; }
        public string Name { set; get; }
        public int Age { set; get; }

        public Actor()
        {
            Id = Guid.NewGuid();
        }
    }
}

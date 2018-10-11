using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToManyMapApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            SwabhavDBContext swabhavDBContext = new SwabhavDBContext();
            AddDataMovies(swabhavDBContext);
        }

        private static void AddDataActors(SwabhavDBContext swabhavDBContext)
        {
            Actor actor = new Actor { Name = "Salmaan Khan", Age = 52 };
            actor.Movies = new List<Movie>();
            actor.Movies.Add(new Movie { Name = "Dabang", ReleaseDate = "25/11/2008" });
            actor.Movies.Add(new Movie { Name = "Wanted", ReleaseDate = "16/10/2006" });
            actor.Movies.Add(new Movie { Name = "Dabang 2", ReleaseDate = "11/12/2010" });

            swabhavDBContext.Actors.Add(actor);
            swabhavDBContext.SaveChanges();
        }

        private static void AddDataMovies(SwabhavDBContext swabhavDBContext)
        {
            Movie movie = new Movie { Name = "Student Of The Year", ReleaseDate = "1/9/2016" };
            movie.Actors = new List<Actor>();
            movie.Actors.Add(new Actor { Name="Alia Bhatt",Age = 25});
            movie.Actors.Add(new Actor { Name = "Varun Dhavan", Age = 31 });
            movie.Actors.Add(new Actor { Name = "Siddarth Malhotra", Age = 33 });

            swabhavDBContext.Movies.Add(movie);
            swabhavDBContext.SaveChanges();
        }
    }
}

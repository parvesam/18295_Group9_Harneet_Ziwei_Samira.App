using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18295_Group9_Harneet_Ziwei_Samira.Models
{
    public static class MoviesRepository
    {
        private static readonly List<Movie> movies;

        static MoviesRepository()
        {
            movies = new List<Movie>
        {
            new Movie { Name = "Movie 1", Genre = "Action", Duration = 120, Language = "English" },
            new Movie { Name = "Movie 2", Genre = "Comedy", Duration = 90, Language = "Hindi" },
            new Movie { Name = "Movie 3", Genre = "Drama", Duration = 150, Language = "Spanish" },
            new Movie { Name = "Movie 4", Genre = "Horror", Duration = 100, Language = "French" },
            new Movie { Name = "Movie 5", Genre = "Romance", Duration = 110, Language = "Italian" },
            new Movie { Name = "Movie 6", Genre = "Action", Duration = 130, Language = "English" },
            new Movie { Name = "Movie 7", Genre = "Comedy", Duration = 80, Language = "Hindi" },
            new Movie { Name = "Movie 8", Genre = "Drama", Duration = 140, Language = "Spanish" },
            new Movie { Name = "Movie 9", Genre = "Horror", Duration = 95, Language = "French" },
            new Movie { Name = "Movie 10", Genre = "Romance", Duration = 120, Language = "Italian" },
            new Movie { Name = "Movie 11", Genre = "Action", Duration = 125, Language = "English" },
            new Movie { Name = "Movie 12", Genre = "Comedy", Duration = 85, Language = "Hindi" },
            new Movie { Name = "Movie 13", Genre = "Drama", Duration = 160, Language = "Spanish" },
            new Movie { Name = "Movie 14", Genre = "Horror", Duration = 90, Language = "French" },
            new Movie { Name = "Movie 15", Genre = "Romance", Duration = 115, Language = "Italian" },
            new Movie { Name = "Movie 16", Genre = "Action", Duration = 130, Language = "English" },
            new Movie { Name = "Movie 17", Genre = "Comedy", Duration = 95, Language = "Hindi" },
            new Movie { Name = "Movie 18", Genre = "Drama", Duration = 150, Language = "Spanish" },
            new Movie { Name = "Movie 19", Genre = "Horror", Duration = 105, Language = "French" },
            new Movie { Name = "Movie 20", Genre = "Romance", Duration = 125, Language = "Italian" },
        };


        }
        public static IEnumerable<Movie> GetAllMovies()
        {
            return movies;
        }
    }
}

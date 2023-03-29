using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18295_Group9_Harneet_Ziwei_Samira
{

    class MovieTheater:Movie
    {
        public List<Movie> Movies { get; set; }

        public MovieTheater()
        {
            Movies = new List<Movie>()
        {
            new Movie("Avengers: Endgame", "Action", "New York", 100, new DateTime(2023, 3, 23, 12, 0, 0)),
            new Movie("The Lion King", "Animation", "Los Angeles", 80, new DateTime(2023, 3, 23, 14, 0, 0)),
            new Movie("Joker", "Drama", "Chicago", 50, new DateTime(2023, 3, 23, 16, 0, 0)),
            new Movie("Star Wars: The Rise of Skywalker", "Sci-Fi", "Houston", 70, new DateTime(2023, 3, 23, 18, 0, 0)),
            new Movie("Spider-Man: No Way Home", "Action", "New York", 60, new DateTime(2023, 3, 23, 20, 0, 0)),
            new Movie("Black Panther", "Action", "Chicago", 90, new DateTime(2023, 3, 24, 12, 0, 0)),
            new Movie("Frozen 2", "Animation", "Los Angeles", 80, new DateTime(2023, 3, 24, 14, 0, 0)),
            new Movie("Interstellar", "Sci-Fi", "Houston", 50, new DateTime(2023, 3, 24, 16, 0, 0)),
            new Movie("The Godfather", "Drama", "New York", 70, new DateTime(2023, 3, 24, 18, 0, 0)),
            new Movie("Titanic", "Romance", "Chicago", 60, new DateTime(2023, 3, 24, 20, 0, 0))
        };
        }
    }
}

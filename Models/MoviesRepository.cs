using Android.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18295_Group9_Harneet_Ziwei_Samira.Models
{
    public static class MoviesRepository
    {
        private static List<Movie> _movies;

        static MoviesRepository()
        {
            PopulateMovies();
        }

        private static void PopulateMovies()
        {
            _movies = new List<Movie>
        {
            new Movie { Name = "Die Hard", Genre = "Action", Duration = 120, Language = "English", AvailableSeats = 57, Location = "Bramalea", MainActor="Bruce Willis", Description="John McClane, a New York cop, fights a gang of terrorists who have taken over a Los Angeles skyscraper.",ImageUrl="https://upload.wikimedia.org/wikipedia/en/c/ca/Die_Hard_%281988_film%29_poster.jpg"},
            new Movie { Name = "Hera Pheri", Genre = "Comedy", Duration = 90, Language = "Hindi",  AvailableSeats = 88, Location = "Courtney", MainActor="Akshay Kumar, Sunil Shetty, and Paresh Rawal", Description="Three bumbling friends try to get rich quick through a series of hilarious mishaps and misunderstandings.",ImageUrl="https://upload.wikimedia.org/wikipedia/en/a/a5/Hera_Pheri_2000_poster.jpg" },
            new Movie { Name = "All About My Mother", Genre = "Drama", Duration = 150, Language = "Spanish", AvailableSeats = 76, Location = "McLaughlin", MainActor="Cecilia Roth", Description="A grieving mother travels to Barcelona to find the father of her deceased son, and meets a cast of eccentric characters along the way.",ImageUrl="https://s3.amazonaws.com/criterion-production/films/081d7c31ab52d99598396ad232926653/psy2aK64LWq4FLcQRLx86tC4MeIcdm_large.jpg" },
            new Movie { Name = "Raw", Genre = "Horror", Duration = 100, Language = "French", AvailableSeats = 92, Location = "Derry", MainActor="Garance Marillier", Description="A vegetarian veterinary student undergoes a transformation after being forced to eat meat during a hazing ritual, leading to a gruesome and erotic exploration of cannibalism and desire.",ImageUrl="https://upload.wikimedia.org/wikipedia/en/d/d2/Raw_%28film%29.png" },
            new Movie { Name = "The Mountain", Genre = "Adventure", Duration = 110, Language = "Turkish", AvailableSeats = 66, Location = "Bramalea", MainActor="Ahmet Mumtaz Taylan", Description="A group of mountaineers embark on a dangerous expedition to climb a remote peak in Turkey, facing extreme weather conditions and personal conflicts along the way.",ImageUrl="https://upload.wikimedia.org/wikipedia/en/4/40/The_Mountain_%282012_film%29_poster.jpg"},
            new Movie { Name = "John Wick", Genre = "Action", Duration = 130, Language = "English", AvailableSeats = 57, Location = "Courtney", MainActor="Keanu Reeves", Description="After his dog is killed and his car stolen, a retired hitman seeks revenge against the Russian mafia in New York City.",ImageUrl="https://m.media-amazon.com/images/M/MV5BMTU2NjA1ODgzMF5BMl5BanBnXkFtZTgwMTM2MTI4MjE@._V1_.jpg" },
            new Movie { Name = "Andaz Apna Apna", Genre = "Comedy", Duration = 80, Language = "Hindi",  AvailableSeats = 78, Location = "Steeles", MainActor="Aamir Khan and Salman Khan", Description="Two dim-witted but ambitious men try to win the heart of a wealthy heiress, leading to a series of comedic misunderstandings and schemes.",ImageUrl="https://pics.filmaffinity.com/Andaz_Apna_Apna-305198243-large.jpg" },
            new Movie { Name = "Talk to Her", Genre = "Drama", Duration = 140, Language = "Spanish", AvailableSeats = 43, Location = "Steeles", MainActor="Javier Cámara", Description="Two men form an unlikely friendship while caring for their comatose girlfriends, leading to a complex exploration of love and companionship.",ImageUrl="https://upload.wikimedia.org/wikipedia/en/2/2c/Talk_to_Her_poster.png" },
            new Movie { Name = "Inside", Genre = "Horror", Duration = 95, Language = "French", AvailableSeats = 57, Location = "Bovaird", MainActor="Alysson Paradis", Description="A pregnant woman is terrorized by a mysterious stranger who wants to take her unborn baby, leading to a violent and suspenseful battle for survival.",ImageUrl="https://upload.wikimedia.org/wikipedia/en/2/21/Inside_2018_poster.jpg" },
            new Movie { Name = "The Wild Pear Tree", Genre = "Adventure", Duration = 120, Language = "Turkish", AvailableSeats = 59, Location = "McLaughlin", MainActor="Dogu Demirkol", Description="A young man returns to his rural hometown after finishing university, struggling to reconcile his intellectual ambitions with his family and community's expectations.",ImageUrl="https://m.media-amazon.com/images/M/MV5BZjJmMGZmZTQtOWQ5NS00YjUwLWI4ZjEtZGY5NzBlMmY5ZGZlXkEyXkFqcGdeQXVyMTg5MDEyNw@@._V1_.jpg"},
            new Movie { Name = "The Bourne Identity", Genre = "Action", Duration = 125, Language = "English", AvailableSeats = 84, Location = "McLaughlin", MainActor="Matt Damon", Description="A man with amnesia is pursued by assassins as he tries to uncover his true identity and the reasons why he is being hunted.",ImageUrl="https://resizing.flixster.com/Zy_sva1RnVL8-ay3N6c-jt9Bxbo=/206x305/v2/https://flxt.tmsimg.com/assets/p28900_p_v8_ar.jpg" },
            new Movie { Name = "Golmaal", Genre = "Comedy", Duration = 85, Language = "Hindi",  AvailableSeats = 75, Location = "Steeles", MainActor="Ajay Devgn", Description="A group of friends fabricate a fake blind man to avoid paying rent, leading to a string of hilarious lies and situations.",ImageUrl="https://upload.wikimedia.org/wikipedia/en/b/b4/Golmaal-Fun_Unlimited.jpg" },
            new Movie { Name = "The Spirit of the Beehive", Genre = "Drama", Duration = 160, Language = "Spanish", AvailableSeats = 67, Location = "Bovaird", MainActor="Ana Torrent", Description="A young girl in rural Spain is captivated by a screening of \"Frankenstein,\" leading to a haunting exploration of childhood, innocence, and the traumas of the Spanish Civil War.",ImageUrl="https://s3.amazonaws.com/criterion-production/films/9ed25eb19c6d6f400c5a26266cb9ddc9/38WjZ61t2cZ8MZD8xKLCTaUHbpVeAf_large.jpg" },
            new Movie { Name = "Martyrs", Genre = "Horror", Duration = 90, Language = "French",  AvailableSeats = 79, Location = "Bovaird" , MainActor="Mylène Jampanoï", Description="Two young women are subjected to extreme torture and abuse by a cult, leading to a disturbing and haunting exploration of trauma and redemption.",ImageUrl="https://m.media-amazon.com/images/M/MV5BYTY0NTZlZjYtNWRmZi00MGRjLTk4ZDctMjE4NjBiZTUyNGNhXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_.jpg"},
            new Movie { Name = "The Mountain 2", Genre = "Adventure", Duration = 115, Language = "Turkish",  AvailableSeats = 72, Location = "Derry", MainActor="Ozan Agaç", Description="A group of Turkish soldiers go on a dangerous mission to rescue hostages from ISIS in Syria, facing difficult moral dilemmas and risking their lives for their country and fellow human beings.",ImageUrl="https://m.media-amazon.com/images/M/MV5BN2I2NGMzMTItNWI4YS00MWRiLTliZTEtNzhjODE3NDcyZjQwXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_FMjpg_UX1000_.jpg" },
            new Movie { Name = "Mission: Impossible - Fallout", Genre = "Action", Duration = 130, Language = "English", AvailableSeats = 57, Location = "Derry",MainActor="Tom Cruise", Description="Ethan Hunt and his team race against time to stop a nuclear attack, while being pursued by a CIA agent who suspects them of being traitors.",ImageUrl="https://upload.wikimedia.org/wikipedia/en/f/ff/MI_%E2%80%93_Fallout.jpg" },
            new Movie { Name = "3 Idiots", Genre = "Comedy", Duration = 95, Language = "Hindi",  AvailableSeats = 74, Location = "Courtney", MainActor="Aamir Khan, R. Madhavan, and Sharman Joshi", Description="Two friends search for their missing college mate, leading to a hilarious journey of self-discovery and coming-of-age.",ImageUrl="https://upload.wikimedia.org/wikipedia/en/d/df/3_idiots_poster.jpg" },
            new Movie { Name = "Women on the Verge of a Nervous Breakdown", Genre = "Drama", Duration = 150, Language = "Spanish", AvailableSeats = 66, Location = "Chinguacousy", MainActor="Carmen Maura", Description="A woman goes on a wild ride after being dumped by her lover, leading to a hilarious and poignant exploration of love, relationships, and female empowerment.",ImageUrl="https://m.media-amazon.com/images/M/MV5BMjA0NjE2MTAyMl5BMl5BanBnXkFtZTcwNjY3NjcxMQ@@._V1_.jpg"},
            new Movie { Name = "High Tension", Genre = "Horror", Duration = 105, Language = "French",  AvailableSeats = 91, Location = "Chinguacousy", MainActor="Cécile De France", Description="Two friends on a remote vacation are stalked by a sadistic killer, leading to a bloody and intense game of cat and mouse.",ImageUrl="https://m.media-amazon.com/images/W/IMAGERENDERING_521856-T1/images/I/51jthT0B7iL._AC_SY445_.jpg" },
            new Movie { Name = "The Butterfly's Dream", Genre = "Adventure", Duration = 125, Language = "Turkish", AvailableSeats = 85, Location = "Chinguacousy", MainActor="Kivanç Tatlitug and Mert Firat", Description="Two young poets in 1940s Turkey struggle to make their dreams of literature and love come true, against the backdrop of World War II and political turmoil.",ImageUrl="https://www.cinemawithoutborders.com/wp-content/uploads/2017/07/The_Butterfly_DreamA_411237807.jpg" },
        };
        }
        public static List<Movie> GetAllMovies()
        {
            return _movies;
        }

        public static List<Movie> SearchByName(string title)
        {
            var result = new List<Movie>();

            foreach (var movie in _movies)
            {
                if (movie.Name.ToLower().Contains(title.ToLower()))
                    result.Add(movie);
            }
            return result;
        }
    }
}

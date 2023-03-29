using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18295_Group9_Harneet_Ziwei_Samira
{
    class Movie
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Location { get; set; }
        public int AvailableSeats { get; set; }
        public int TotalSeats { get; set; }
        public DateTime ShowTime { get; set; }
        public List<string> BookedSeats { get; set; }

        public Movie(string name, string genre, string location, int availableSeats, DateTime showTime, int totalSeats)
        {
            Name = name;
            Genre = genre;
            Location = location;
            AvailableSeats = availableSeats;
            ShowTime = showTime;
            TotalSeats = totalSeats;
            BookedSeats = new List<string>();
        }
    }

}

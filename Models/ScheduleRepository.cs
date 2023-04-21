
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18295_Group9_Harneet_Ziwei_Samira.Models
{/*created by Harneet*/
    internal class ScheduleRepository
    {
        private static readonly List<Schedule> schedules;
        static ScheduleRepository()
        {
            // Create a list of Schedule instances
            schedules = new List<Schedule>();

            // Get all movies from the movie repository
            var movies = MoviesRepository.GetAllMovies();

            // Get all halls from the hall repository
            var halls = HallRepository.GetAllHalls();

            foreach (var movie in movies)
            {
                DateTime scheduleDateTime = DateTime.Now.AddDays(1).AddHours(new Random().Next(0, 24)); // Generate a random datetime for the current movie

                foreach (var hall in halls)
                {
                    // Create a new schedule with the current movie, hall, and random datetime
                    var schedule = new Schedule
                    {
                        Movie = movie,
                        Hall = hall,
                        DateTime = scheduleDateTime
                    };

                    // Add the schedule to the list
                    schedules.Add(schedule);
                }
            }

        
    }

        // Get all schedules in the list
        public IEnumerable<Schedule> GetAllSchedules()
        {
            return schedules;
        }
        public static List<Schedule> SearchByName(string title)
        {
            var result = new List<Schedule>();

            foreach (var schedule in schedules)
            {
                if (schedule.Movie.Name==title)
                {
                    result.Add(schedule);
                }
            }
            return result;
        }
       
    }
}

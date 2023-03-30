using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18295_Group9_Harneet_Ziwei_Samira.Models
{
    internal class ScheduleRepository
    {
        private readonly List<Schedule> schedules;
        public ScheduleRepository()
        {
            // Create a list of Schedule instances
            schedules = new List<Schedule>();

            // Get all movies from the movie repository
            var movies = MoviesRepository.GetAllMovies();

            // Get all halls from the hall repository
            var halls = HallRepository.GetAllHalls();

            // Create a schedule for each movie in each hall
            foreach (var movie in movies)
            {
                foreach (var hall in halls)
                {
                    // Create a new schedule with the current movie and hall
                    var schedule = new Schedule
                    {
                        Movie = movie,
                        Hall = hall,
                        DateTime = DateTime.Now.AddDays(1) // Set the schedule for tomorrow
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

    }
}

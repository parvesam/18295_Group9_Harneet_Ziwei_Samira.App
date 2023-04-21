using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18295_Group9_Harneet_Ziwei_Samira.Models
{/*created by Harneet*/

    public static class HallRepository
    {
        private static List<Hall> halls;
        static HallRepository()
        {
            PopulateHallRepository();
        }

        private static void  PopulateHallRepository()
        {
            // Create 8 instances of Hall
            var hall1 = new Hall { Name = "Cinema 1", Location = "WestWord Cinemas, Milton", NumberOfSeats = 40, HallName = "Hall A" };
            var hall2 = new Hall { Name = "Cinema 2", Location = "Outland Mall, Orangeville", NumberOfSeats = 40, HallName = "Hall B" };
            var hall3 = new Hall { Name = "Cinema 3", Location = "Royal Gardens Cinemas, Windsor", NumberOfSeats = 40, HallName = "Hall C" };
            var hall4 = new Hall { Name = "Cinema 4", Location = "Silver Screen Cinemas, Oakdale", NumberOfSeats = 40, HallName = "Hall D" };
            var hall5 = new Hall { Name = "Cinema 5", Location = "Hollywood Hills Cinemas, Sun Valley", NumberOfSeats = 40, HallName = "Hall E" };
            var hall6 = new Hall { Name = "Cinema 6", Location = "Sunset Cinemas, Bayview", NumberOfSeats = 40, HallName = "Hall F" };
            var hall7 = new Hall { Name = "Cinema 7", Location = "Crystal Palace Cinemas, Brookfield", NumberOfSeats = 40, HallName = "Hall G" };
            var hall8 = new Hall { Name = "Cinema 8", Location = "Starlight Cinemas, Meadowville", NumberOfSeats = 40, HallName = "Hall H" };

            // Create a list that holds the instances of Hall
            halls = new List<Hall> { hall1, hall2, hall3, hall4, hall5, hall6, hall7, hall8 };
        }





        public static List<Hall> GetAllHalls()
        {
            return halls;
        }
        public static int GetNumberofSeatsbyName(Hall selectedHall)
        {
            var result = new List<int>();

            foreach (var hall in halls)
            {
                if (hall.HallName.ToLower().Contains(selectedHall.HallName.ToLower()))
                   result.Add(hall.NumberOfSeats);  
            }
            return result[0];
        }

    }

}


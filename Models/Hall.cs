using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18295_Group9_Harneet_Ziwei_Samira.Models
{
    public class Hall : Cinema
    {
        public int NumberOfSeats { get; set; }
        public string HallName { get; set; }

        public static List<int> HallMap(Hall hall)
        {
            var totalseats = hall.NumberOfSeats;
            var seats = new List<int>();
            while (totalseats > 10)
            {
                seats.Add(10);
                totalseats = totalseats - 10;
            }
            if (totalseats <= 10)
                seats.Add(totalseats);
            return seats;



        }
    }
}

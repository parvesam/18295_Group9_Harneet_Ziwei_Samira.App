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
        public Hall()
        {
            
        }

        public static void PopulateMap(int NoofSeats)
        {
            string[,] seats = new string[5, 10];
            
            foreach (var seat in seats)
            {
                
                if (NoofSeats <= 50)
                {
                    seats[0,0 ] = "chair.png";
                    seats[1, 0] = "chair.png";
                    seats[2, 0] = "chair.png";
                    seats[3, 0]= "chair.png";
                    seats[4, 0]= "chair.png";
                    seats[0, 1] = "chair.png";
                    seats[1, 1] = "chair.png";
                    seats[2, 1] = "chair.png";
                    seats[3, 1] = "chair.png";
                    seats[4, 1] = "chair.png";
                    seats[0, 2] = "chair.png";
                    seats[1, 2] = "chair.png";
                    seats[2, 2] = "chair.png";
                    seats[3, 2] = "chair.png";
                    seats[4, 2] = "chair.png";
                    seats[0, 3] = "chair.png";
                    seats[1, 3] = "chair.png";
                    seats[2, 3] = "chair.png";
                    seats[3, 3] = "chair.png";
                    seats[4, 3] = "chair.png";
                    seats[0, 4] = "chair.png";
                    seats[1, 4] = "chair.png";
                    seats[2, 4] = "chair.png";
                    seats[3, 4] = "chair.png";
                    seats[4, 4] = "chair.png";
                    seats[0, 5] = "chair.png";
                    seats[1, 5] = "chair.png";
                    seats[2, 5] = "chair.png";
                    seats[3, 5] = "chair.png";
                    seats[4, 5] = "chair.png";
                    seats[0, 6] = "chair.png";
                    seats[1, 6] = "chair.png";
                    seats[2, 6] = "chair.png";
                    seats[3, 6] = "chair.png";
                    seats[4, 6] = "chair.png";
                    seats[0, 7] = "chair.png";
                    seats[1, 7] = "chair.png";
                    seats[2, 7] = "chair.png";
                    seats[3, 7] = "chair.png";
                    seats[4, 7] = "chair.png";
                    seats[0, 8] = "chair.png";
                    seats[1, 8] = "chair.png";
                    seats[2, 8] = "chair.png";
                    seats[3, 8] = "chair.png";
                    seats[4, 8] = "chair.png";
                    seats[0, 9] = "chair.png";
                    seats[1, 9] = "chair.png";
                    seats[2, 9] = "chair.png";
                    seats[3, 9] = "chair.png";
                    seats[4, 9] = "chair.png";

                    
                }
                
            }




        }
        public int ReturnNumberofSeats()
        {
            return NumberOfSeats;
        }
        public string ReturnHallName()
        {
            return HallName;
        }
    }
}

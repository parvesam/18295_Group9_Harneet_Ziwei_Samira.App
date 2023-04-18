using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18295_Group9_Harneet_Ziwei_Samira.Models
{
    internal class SeatRepository
    {
        public static List<Seat> seats;
        private string[,] _images = new string[4, 7];

        public SeatRepository(Hall hall)
        {
            PopulateSeats(hall);
        }
        public static void PopulateSeats(Hall hall)
        {

            seats = new List<Seat>();

            for (char row = 'A'; row <= 'E'; row++)
            {
                for (int seatNumber = 1; seatNumber <= 8; seatNumber++)
                {
                    switch (hall.HallName)
                    {
                        case "Hall A":
                            seats.Add(new Seat
                            {
                                HallName = "Hall A",
                                RowName = row.ToString(),
                                SeatNumberinRow = seatNumber,
                                SeatPhoto = "chair.png"
                            }); ;
                            break;
                        case "Hall E":
                            seats.Add( new Seat
                            {
                                HallName = "Hall E",
                                RowName = row.ToString(),
                                SeatNumberinRow = seatNumber,
                                SeatPhoto = "chair.png"
                            });
                            break;
                        case "Hall G":
                            seats.Add(new Seat
                            {
                                HallName = "Hall G",
                                RowName = row.ToString(),
                                SeatNumberinRow = seatNumber,
                                SeatPhoto = "chair.png"
                            });
                            break;
                        case "Hall H":
                            seats.Add(new Seat
                            {
                                HallName = "Hall H",
                                RowName = row.ToString(),
                                SeatNumberinRow = seatNumber,
                                SeatPhoto = "chair.png"
                            });
                            break;


                        case "Hall B":


                            seats.Add(new Seat
                            {
                                HallName = "Hall B",
                                RowName = row.ToString(),
                                SeatNumberinRow = seatNumber,
                                SeatPhoto = "chair.png"
                            });
                            break;
                        case "Hall F":
                            seats.Add(new Seat
                            {
                                HallName = "Hall F",
                                RowName = row.ToString(),
                                SeatNumberinRow = seatNumber,
                                SeatPhoto = "chair.png"
                            });
                            break;



                        case "Hall C":
                            seats.Add(new Seat
                            {
                                HallName = "Hall C",
                                RowName = row.ToString(),
                                SeatNumberinRow = seatNumber,
                                SeatPhoto = "chair.png"
                            });
                            break;
                        case "Hall D":
                            seats.Add(new Seat
                            {
                                HallName = "Hall D",
                                RowName = row.ToString(),
                                SeatNumberinRow = seatNumber,
                                SeatPhoto = "chair.png"
                            });
                            break;
                    }
                }
            }
        }
        public static List<Seat> GetSeatsInHall(Hall hall)


        {
            var result = new List<Seat>();

            foreach (var seat in seats)
            {
                if (seat.HallName.ToLower().Contains(hall.HallName.ToLower()))
                    result.Add(seat);
            }
            return result;
        }
        private void PopulateImages()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    _images[i, j] = "chair.png";
                }
            }
        }
    }
}

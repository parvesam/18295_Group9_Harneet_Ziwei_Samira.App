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
        public SeatRepository()
        {
            PopulateSeats();
        }
        public void PopulateSeats()
        {

            seats = new List<Seat>();

            for (char row = 'A'; row <= 'E'; row++)
            {
                for (int seatNumber = 1; seatNumber <= 10; seatNumber++)
                {
                    if (seats.Count <= 30)
                    {
                        seats.Add(new Seat
                        {
                            HallName = "Hall A",
                            RowName = row.ToString(),
                            SeatNumberinRow = seatNumber
                        });
                        seats.Add(new Seat
                        {
                            HallName = "Hall E",
                            RowName = row.ToString(),
                            SeatNumberinRow = seatNumber
                        });
                        seats.Add(new Seat
                        {
                            HallName = "Hall G",
                            RowName = row.ToString(),
                            SeatNumberinRow = seatNumber
                        });
                        seats.Add(new Seat
                        {
                            HallName = "Hall H",
                            RowName = row.ToString(),
                            SeatNumberinRow = seatNumber
                        });




                    }
                    if (seats.Count <= 25)
                    {
                        seats.Add(new Seat
                        {
                            HallName = "Hall B",
                            RowName = row.ToString(),
                            SeatNumberinRow = seatNumber
                        });
                        seats.Add(new Seat
                        {
                            HallName = "Hall F",
                            RowName = row.ToString(),
                            SeatNumberinRow = seatNumber
                        });



                    }
                    if (seats.Count <= 40)
                    {
                        seats.Add(new Seat
                        {
                            HallName = "Hall C",
                            RowName = row.ToString(),
                            SeatNumberinRow = seatNumber
                        });
                        seats.Add(new Seat
                        {
                            HallName = "Hall D",
                            RowName = row.ToString(),
                            SeatNumberinRow = seatNumber
                        });

                    }
                }
            }
        }
        public static List<Seat> GetSeatsInHall(Hall hall)

        {
            var SeatsinHall = new List<Seat>();
            foreach (Seat seatname in seats)
            {


                if (seats.Contains(hall))
                {
                    SeatsinHall.Add(seatname);

                }
            }
            return SeatsinHall;
        }
    }
}

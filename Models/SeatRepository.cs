using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18295_Group9_Harneet_Ziwei_Samira.Models
{
    public static class SeatRepository
    {
        
        private static List<string> _selectedSeats;

       

        static SeatRepository()
        {
            PopulateSelectedSeats();
        }
        
        
        public static string ConvertToRowLabel(double num)
        {
            /*
            Convert a number to a row or column label.
            */
            switch (num)
            {
                case 0:
                    return "A";
                case 1:
                    return "B";
                case 2:
                    return "C";
                case 3:
                    return "D";
                case 4:
                    return "E";
                default:
                    throw new ArgumentException("Invalid number");
            }
        }
       public  static double ConvertToSeatNumberinRow(double num)
        {
            
            
            double columnLabel = (num + 1); // add 1 to convert 0-7 range to 1-8 range
            return columnLabel;
        }
       //public  static void AddSelectedSeats(string rowName, int seatNumber)
       // {
       //     _selectedSeats = new List<Seat>();
       //     _selectedSeats.Add(new Seat(rowName, seatNumber));
       // }
        public static string CombineNumbers(double num1, double num2)
        {
            /*
            Convert num1 and num2 to row and column labels, and combine them into a string.
            */
            string rowLabel = ConvertToRowLabel(num1);
            string columnLabel = (num2 + 1).ToString(); // add 1 to convert 0-7 range to 1-8 range
            return rowLabel + columnLabel;
        }
        public static void AddSelectedSeat(string seatname)
        {
           
            if(!_selectedSeats.Contains(seatname))
            _selectedSeats.Add(seatname);
           
               
        }
        public static void RemoveSelectedSeat(string seatname)
        {
            
            if (_selectedSeats.Contains(seatname))
                _selectedSeats.Remove(seatname);


        }
        public static List<string> GetSelectedSeats()
        {
            return _selectedSeats;
        }
        public static double CalculatePrice(double NumberOfAdultTickets, double NumberOfKidTickets)
        {

            double price;
            price = NumberOfAdultTickets * (double)(TicketType.Adult) + NumberOfKidTickets * (double)(TicketType.Kid);
            return price;
        }
        public static bool isSeatAlreadySelected(string seatName)
        {
            if (!_selectedSeats.Contains(seatName))
            {
                return false;
               
            }
            
            return
                true;
        }
        public static void PopulateSelectedSeats()
        {
            _selectedSeats = new List<string>();
            //_selectedSeats.Add("1");
        }
        

    }
}

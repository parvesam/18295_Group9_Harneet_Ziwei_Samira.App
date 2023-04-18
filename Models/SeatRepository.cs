using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18295_Group9_Harneet_Ziwei_Samira.Models
{
    internal class SeatRepository
    {
        
        public static List<Seat> _selectedSeats;

        private string[,] _images = new string[4, 7];

        public SeatRepository(Hall hall)
        {
            
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
        static string ConvertToRowLabel(int num)
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
        static int ConvertToSeatNumberinRow(int num)
        {
            
            
            int columnLabel = (num + 1); // add 1 to convert 0-7 range to 1-8 range
            return columnLabel;
        }
        static void AddSelectedSeats(string rowName, int seatNumber)
        {
            _selectedSeats = new List<Seat>();
            _selectedSeats.Add(new Seat(rowName, seatNumber));
        }
        static string CombineNumbers(int num1, int num2)
        {
            /*
            Convert num1 and num2 to row and column labels, and combine them into a string.
            */
            string rowLabel = ConvertToRowLabel(num1);
            string columnLabel = (num2 + 1).ToString(); // add 1 to convert 0-7 range to 1-8 range
            return rowLabel + columnLabel;
        }


    }
}

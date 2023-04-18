using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18295_Group9_Harneet_Ziwei_Samira.Models
{
    internal class Seat:Hall
    {
        public string RowName { get; set; }
        public int SeatNumberinRow { get; set; }
        public Seat( string rowName, int seatNumber)
        {
            RowName= rowName;
            SeatNumberinRow= seatNumber;
        }
       
    }
    
}

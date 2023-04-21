using System;
using _18295_Group9_Harneet_Ziwei_Samira.Models;
using _18295_Group9_Harneet_Ziwei_Samira.Pages;
enum TicketType
{
    Adult = 15,
    Kid = 10
}
public class Ticket
{
    
    
   
    public string SeatNumber { get; set; }
	public Schedule newSchedule { get; set; }


    public Ticket(Schedule schedule, string seatnumber)
	{newSchedule= schedule; 
		
        SeatNumber= seatnumber;

    }
    
}



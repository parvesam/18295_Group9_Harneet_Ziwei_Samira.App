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
    
    
    public string MovieName { get; set; }
	public string Location { get; set; }
    public string SeatNumber { get; set; }
	


    public Ticket(string movieName, string location )
	{
		MovieName= movieName;
		Location= location;
        


    }
    public double CalculatePrice(double NumberOfAdultTickets, double NumberOfKidTickets)
    {
        
        double price;
        price=NumberOfAdultTickets*(double)(TicketType.Adult)+NumberOfKidTickets*(double)(TicketType.Kid);
        return price;
    }
}



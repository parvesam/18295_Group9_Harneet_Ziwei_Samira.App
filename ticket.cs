using System;

public class Ticket
{
    public enum TicketType
    {
        Adult = 1,
        Kid = 2
        
    }
    public Ticket()
	{
		public string MovieName { get; set; }
	public string Location { get; set; }
	public int NumberOfAdultTickets { get; set; }
    public int NumberOfKidTickets
    {
        get; set;
    }


    public Ticket(string MovieName, string Location, int AdultTickets, int KidTickets )
	{
		MovieName= MovieName;
		Location= Location;
        NumberOfAdultTickets= AdultTickets;
        NumberOfKidTickets= KidTickets;


    }
    public double CalculatePrice()
    {
        
        double price;
       

        
        price= (15 * NumberOfAdultTickets)+ (10 * NumberOfKidTickets);
        return price;
    }
}

}

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
	public int NumberOfTickets { get; set; }
	public Ticket()
	{
		MovieName= MovieName;
		Location= Location;
		NumberOfTickets= NumberOfTickets;
	}
    public double CalculatePrice(TicketType ticketType)
    {
        double ticketPrice = 0;

        switch (ticketType)
        {
            case TicketType.Adult:
                ticketPrice = 15.99;
                break;
            case TicketType.Kid:
                ticketPrice = 9.99;
                break;
        }

        return ticketPrice * NumberOfTickets;
    }
}

}

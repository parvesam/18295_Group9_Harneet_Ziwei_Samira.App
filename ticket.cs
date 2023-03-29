using System;

public class Ticket
{
    
    public Ticket()
	{
		public string MovieName { get; set; }
	public string Location { get; set; }
	public int NumberOfAdultTickets { get; set; }
    public int NumberOfKidTickets
    {
        get; set;
    }


    public Ticket(string movieName, string location, int AdultTickets, int KidTickets )
	{
		MovieName= movieName;
		Location= location;
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

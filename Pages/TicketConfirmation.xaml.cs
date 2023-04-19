using _18295_Group9_Harneet_Ziwei_Samira.Models;
namespace _18295_Group9_Harneet_Ziwei_Samira.Models;

public partial class TicketConfirmation : ContentPage
{
	public TicketConfirmation(Ticket ticket, Hall hall)
	{
		InitializeComponent();
		 MovieLabel.Text = ticket.MovieName;
        	CinemaLebal.Text = ticket.Location;
        	HallNameLabel.Text = hall.HallName;
        	// ScheduleLabel.Text= schedule.DateTime.ToString();
        	// SeatsLabel.Text = ;
	}
}

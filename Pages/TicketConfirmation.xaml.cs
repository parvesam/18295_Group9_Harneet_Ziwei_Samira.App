using _18295_Group9_Harneet_Ziwei_Samira.Models;
namespace _18295_Group9_Harneet_Ziwei_Samira.Models;

public partial class TicketConfirmation : ContentPage
{
    public List<Ticket> Tickets = new List<Ticket>();
    public TicketConfirmation(bool emailOptionSelected)
	{
		InitializeComponent();
        if (emailOptionSelected)
        {
            EmailConfirmationLabel.Text = "Thank you! Your tickets have been booked. Please check your email.";
        }
        else
        {
            EmailConfirmationLabel.IsVisible = true;
            EmailConfirmationLabel.Text = "Thank you! Your tickets have been booked. Please print your tickets.";
        }
        TicketsListView.ItemsSource = TicketRepository.GetTickets();
    }
    }

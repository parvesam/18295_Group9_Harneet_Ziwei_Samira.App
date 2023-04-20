namespace _18295_Group9_Harneet_Ziwei_Samira.Pages;
using _18295_Group9_Harneet_Ziwei_Samira.Models;

public partial class PaymentPage : ContentPage
{
	public PaymentPage()
	{
		InitializeComponent();
        //LocationListView.ItemsSource = ScheduleRepository.SearchByName(movie.Name);
    }

    void Confirmed_Clicked(object sender, EventArgs e)
    {
        //var selectedticket = LocationListView.SelectedItem as ticket;
        //Navigation.PushAsync(new TicketConfirmation());
    }
}
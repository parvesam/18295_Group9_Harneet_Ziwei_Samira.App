using _18295_Group9_Harneet_Ziwei_Samira.Models;
using _18295_Group9_Harneet_Ziwei_Samira.Pages;

namespace _18295_Group9_Harneet_Ziwei_Samira;

public partial class BookTicket : ContentPage
{
	public BookTicket(Movie movie)
	{
		InitializeComponent();
        LocationListView.ItemsSource = ScheduleRepository.SearchByName(movie.Name);
        
    }
    void LocationListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var selectedSchedule = LocationListView.SelectedItem as Schedule;
        Navigation.PushAsync(new SeatReservation(selectedSchedule.Hall));
    }

}
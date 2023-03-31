using _18295_Group9_Harneet_Ziwei_Samira.Models;

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
        //var selectedMovie = MoviesListView.SelectedItem as Movie;
        //Navigation.PushAsync(new BookTicket(selectedMovie));
    }

}
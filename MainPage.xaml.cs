using _18295_Group9_Harneet_Ziwei_Samira.Models;
namespace _18295_Group9_Harneet_Ziwei_Samira;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
        MoviesListView.ItemsSource = MoviesRepository.GetAllMovies();

    }


    void SearchEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        MoviesListView.ItemsSource = MoviesRepository.SearchByName(SearchEntry.Text);
    }
    void MoviesListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var selectedMovie = MoviesListView.SelectedItem as Movie;
        Navigation.PushAsync(new MoviePage(selectedMovie));
    }

    
}


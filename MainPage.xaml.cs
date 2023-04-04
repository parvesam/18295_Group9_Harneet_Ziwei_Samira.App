using _18295_Group9_Harneet_Ziwei_Samira.Models;
namespace _18295_Group9_Harneet_Ziwei_Samira;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
        MoviesListView.ItemsSource = MoviesRepository.GetAllMovies();

    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

    
}


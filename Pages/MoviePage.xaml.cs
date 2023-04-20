using _18295_Group9_Harneet_Ziwei_Samira.Models;
using _18295_Group9_Harneet_Ziwei_Samira.Pages;
namespace _18295_Group9_Harneet_Ziwei_Samira;
public partial class MoviePage : ContentPage
{
    private Movie _movies;
    public MoviePage(Movie movie)
    {
        InitializeComponent();
        _movies = movie;

        //show all the movie details in the moviePage.xaml
        //1: create UI: image, label(s), and a button 
        //2: populate the UI with the received object

        MovieImage.Source = _movies.ImageUrl;
        MovieName.Text = _movies.Name;
        MovieDuration.Text = "Duration: " + _movies.Duration.ToString() + " mins";
        MovieGenre.Text = "Genre: "+_movies.Genre;
        MovieMainActor.Text = "Actor: "+_movies.MainActor;
        MovieLanguage.Text = "Language: "+_movies.Language;
        MovieDescription.Text = "Description: " + _movies.Description;
        
    }

    void BuyTickets_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BookTicket(_movies));
    }
}
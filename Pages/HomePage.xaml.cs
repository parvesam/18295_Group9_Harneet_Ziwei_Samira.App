using _18295_Group9_Harneet_Ziwei_Samira.Pages;
namespace _18295_Group9_Harneet_Ziwei_Samira;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}
    void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MoviePage());
    }
}
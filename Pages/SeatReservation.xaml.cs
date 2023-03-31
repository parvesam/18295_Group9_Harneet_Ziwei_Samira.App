using _18295_Group9_Harneet_Ziwei_Samira.Models;

namespace _18295_Group9_Harneet_Ziwei_Samira.Pages;

public partial class SeatReservation : ContentPage
{
	public SeatReservation(Hall hall)
	{
		InitializeComponent();
		hall=new Hall();
		var SeatPlan=Hall.HallMap(hall);


	}

    private void SeatListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {

    }
}
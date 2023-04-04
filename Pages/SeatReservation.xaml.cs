using _18295_Group9_Harneet_Ziwei_Samira.Models;
using System;

namespace _18295_Group9_Harneet_Ziwei_Samira.Pages;

public partial class SeatReservation : ContentPage
{
   
	public SeatReservation(Hall hall)
	{
        InitializeComponent();
		
        Hall.PopulateMap(hall.NumberOfSeats);
        


	}

    private void ImageButton_Clicked(object sender, SelectedItemChangedEventArgs e)
    {

    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {

    }
}
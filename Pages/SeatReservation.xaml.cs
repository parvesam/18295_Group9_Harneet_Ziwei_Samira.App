using _18295_Group9_Harneet_Ziwei_Samira.Models;
using System;

namespace _18295_Group9_Harneet_Ziwei_Samira.Pages;

public partial class SeatReservation : ContentPage
{
    private SeatRepository seatRepository;
	public SeatReservation(Hall hall)
	{
        InitializeComponent();
       
        seatRepository = new SeatRepository();
        SeatsListView.ItemsSource = SeatRepository.GetSeatsInHall(hall);



    }

   

    private void ImageButton_Clicked(object sender, EventArgs e)
    {

    }

    private void SeatsListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {

    }
}
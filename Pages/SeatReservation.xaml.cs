using _18295_Group9_Harneet_Ziwei_Samira.Models;
using System;
using Microsoft.Maui.Graphics;

namespace _18295_Group9_Harneet_Ziwei_Samira.Pages;

public partial class SeatReservation : ContentPage
{
    private Hall _hall;
    private bool[] _selectedSeats;

    public SeatReservation(Hall hall)
	{
        InitializeComponent();
        _hall = hall;
        _selectedSeats = new bool[_hall.NumberOfSeats];
        Hall.PopulateMap(hall.NumberOfSeats);
        


	}

    private void ImageButton_Clicked(object sender, SelectedItemChangedEventArgs e)
    {
        ImageButton button = sender as ImageButton;
        int row = Grid.GetRow(button);
        int column = Grid.GetColumn(button);
        int seatIndex = row * 4 + column;

        if (_selectedSeats[seatIndex])
        {
            button.BackgroundColor = Colors.Blue;
            _selectedSeats[seatIndex] = false;
        }
        else
        {
            button.BackgroundColor = Colors.Red;
            _selectedSeats[seatIndex] = true;
        }

    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
       // Navigation.PushAsync();
    }
}
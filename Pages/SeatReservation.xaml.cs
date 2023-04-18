using _18295_Group9_Harneet_Ziwei_Samira.Models;
using System;
using Microsoft.Maui.Graphics;

namespace _18295_Group9_Harneet_Ziwei_Samira.Pages;

public partial class SeatReservation : ContentPage
{
    public double NoOfAdultTickets;
    public double NoOfKidTickets;

    public SeatReservation(Hall hall)
    {
        InitializeComponent();

       


       
    }

    private void Kid_Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double value = e.NewValue;
        
        NoOfKidTickets = value;

    }

    private void Adult_Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double value = e.NewValue;

        NoOfAdultTickets = value;
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        var button = (ImageButton)sender;
        var col = ImagesGrid.GetColumn(button);
        var row = ImagesGrid.GetRow(button);
        button.BackgroundColor= Colors.Green;
        

    }

    private void ContinueToPaymentPage_Clicked(object sender, EventArgs e)
    {

    }
}
using _18295_Group9_Harneet_Ziwei_Samira.Models;
using System;
using Microsoft.Maui.Graphics;

namespace _18295_Group9_Harneet_Ziwei_Samira.Pages;

public partial class SeatReservation : ContentPage
{
    public double NoOfAdultTickets;
    public double NoOfKidTickets;
    
    public string _chosenSeat { get; set; }

    public SeatReservation()
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
        var SelecetdRowNumber = SeatRepository.ConvertToRowLabel(col);
        var SelecetdSeatNumberinRow = SeatRepository.ConvertToSeatNumberinRow(col);


        var row = ImagesGrid.GetRow(button);
        
       
        _chosenSeat = SeatRepository.CombineNumbers(row, col);
        var seatIsSelectedAlready = SeatRepository.isSeatAlreadySelected(_chosenSeat);
        if (seatIsSelectedAlready)
        {
            SeatRepository.RemoveSelectedSeat(_chosenSeat);
            button.BackgroundColor = Colors.Blue;
        }
        else if (!seatIsSelectedAlready)
        {
            SeatRepository.AddSelectedSeat(_chosenSeat);
            button.BackgroundColor = Colors.Green;
        }
       



    }

    private void ContinueToPaymentPage_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PaymentPage());
    }

    private void CheckPrice_Clicked(object sender, EventArgs e)
    {
        var price = SeatRepository.CalculatePrice(NoOfAdultTickets, NoOfKidTickets);
       PriceLabel.Text = "Total Amount Due:"+price.ToString();
    }
}
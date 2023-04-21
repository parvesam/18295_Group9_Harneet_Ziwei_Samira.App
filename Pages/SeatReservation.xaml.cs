using _18295_Group9_Harneet_Ziwei_Samira.Models;
using System;
using Microsoft.Maui.Graphics;

namespace _18295_Group9_Harneet_Ziwei_Samira.Pages;

public partial class SeatReservation : ContentPage
{
    public double NoOfAdultTickets;
    public double NoOfKidTickets;
    private Schedule newSchedule;
    
    private string _chosenSeat { get; set; }

    public SeatReservation(Schedule schedule)
    {
        InitializeComponent();
        newSchedule= schedule;
    }

    private void Kid_Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double value = e.NewValue;
        
        NoOfKidTickets = value;
        KidStepperLabel.Text = value.ToString();
        TotalTicketsLabel.Text = (NoOfKidTickets + NoOfAdultTickets).ToString();

    }

    private void Adult_Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double value = e.NewValue;

        NoOfAdultTickets = value;
        AdultStepperLabel.Text = value.ToString();
        TotalTicketsLabel.Text = (NoOfKidTickets + NoOfAdultTickets).ToString();
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        var button = (ImageButton)sender;
        var col = ImagesGrid.GetColumn(button);
        var row = ImagesGrid.GetRow(button);
        var SelecetdRowNumber = SeatRepository.ConvertToRowLabel(row);
        var SelecetdSeatNumberinRow = SeatRepository.ConvertToSeatNumberinRow(col);


      
        
       
        _chosenSeat = SeatRepository.CombineNumbers(row, col);
        var seatIsSelectedAlready = SeatRepository.isSeatAlreadySelected(_chosenSeat);
        if (seatIsSelectedAlready)
        {
            SeatRepository.RemoveSelectedSeat(_chosenSeat);
            button.BackgroundColor = Colors.White;
        }
        else if (!seatIsSelectedAlready)
        {
            SeatRepository.AddSelectedSeat(_chosenSeat);
            button.BackgroundColor = Colors.Green;
        }
       



    }

    private void ContinueToPaymentPage_Clicked(object sender, EventArgs e)

    {var GetSeats=SeatRepository.GetSelectedSeats();
        TicketRepository.CreateTicket(newSchedule, GetSeats);
        Navigation.PushAsync(new PaymentPage());
    }

    private void CheckPrice_Clicked(object sender, EventArgs e)
    {
        var price = SeatRepository.CalculatePrice(NoOfAdultTickets, NoOfKidTickets);
       PriceLabel.Text = "Total Amount Due:"+price.ToString();
    }
}
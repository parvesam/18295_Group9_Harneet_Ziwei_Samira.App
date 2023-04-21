namespace _18295_Group9_Harneet_Ziwei_Samira.Pages;
using _18295_Group9_Harneet_Ziwei_Samira.Models;
using System;

public partial class PaymentPage : ContentPage
{
    private bool emailOptionSelected;

    public PaymentPage()
	{
		InitializeComponent();
    }

    void OnConfirmClicked(object sender, EventArgs e)

    {
       if (CardNumberEntry.Text.Length != 10)
        {
            DisplayAlert("Error", "Incorrect card number. Please enter a 10-digit card number.", "OK");
            return;
        }

        if (string.IsNullOrWhiteSpace(NameEntry.Text))
        {
            DisplayAlert("Error", "Please enter your name.", "OK");
            return;
        }

        if (!string.IsNullOrWhiteSpace(EmailEntry.Text) && !IsValidEmail(EmailEntry.Text))
        {
            DisplayAlert("Error", "Please enter a valid email address.", "OK");
              return;
        }
        emailOptionSelected = ReceiveTicketsSwitch.IsToggled;
        Navigation.PushAsync(new TicketConfirmation(emailOptionSelected));
    }

    bool IsValidEmail(string email)
    {
        try
        {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == email;
        }
        catch
        {
            return false;
        }
    }
}

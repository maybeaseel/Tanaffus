namespace Tanaffus.Views;

public partial class CreateAccountPage : ContentPage
{
    public CreateAccountPage()
    {
        InitializeComponent();
    }

    private async void OnCreateClicked(object? sender, EventArgs e) => await Shell.Current.GoToAsync("//main/today");

    private async void OnSignInTapped(object? sender, TappedEventArgs e) => await Shell.Current.GoToAsync("//signin");
}

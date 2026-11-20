namespace Tanaffus.Views;

public partial class SignInPage : ContentPage
{
    public SignInPage()
    {
        InitializeComponent();
    }
    private async void OnSignInClicked(object? sender, EventArgs e) => await Shell.Current.GoToAsync("//main/today");

    private async void OnRegisterTapped(object? sender, TappedEventArgs e) => await Shell.Current.GoToAsync("//register");
}

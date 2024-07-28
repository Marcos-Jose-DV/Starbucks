using AppStarbucks.Pages;
using AppStarbucks.Services;

namespace AppStarbucks;

public partial class MainPage : ContentPage
{
    private readonly IAuthService _authService;
    public MainPage(IAuthService authService)
    {
        InitializeComponent();
        _authService = authService;
    }
    protected async override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        if (await _authService.IsUserAuthenticated())
        {
            await Shell.Current.GoToAsync($"//{nameof(HomePage)}");

            return;
        }

        await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
    }
}


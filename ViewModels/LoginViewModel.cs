using AppStarbucks.Pages;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppStarbucks.ViewModels;

public partial class LoginViewModel : ObservableObject
{
    [RelayCommand]
    async Task Login()
    {
        await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
    }
}

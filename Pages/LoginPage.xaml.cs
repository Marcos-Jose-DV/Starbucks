using AppStarbucks.ViewModels;

namespace AppStarbucks.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginViewModel loginViewModel)
	{
		InitializeComponent();

		BindingContext = loginViewModel;
	}
}
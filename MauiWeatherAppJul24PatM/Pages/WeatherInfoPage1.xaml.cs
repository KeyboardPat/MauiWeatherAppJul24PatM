namespace MauiWeatherAppJul24PatM.Pages;
using MauiWeatherAppJul24PatM.Models.ViewModels;

public partial class WeatherInfoPage1 : ContentPage
{
	public WeatherInfoPage1()
	{
		InitializeComponent();
		BindingContext = new WeatherInfoPageViewModel();
	}
}
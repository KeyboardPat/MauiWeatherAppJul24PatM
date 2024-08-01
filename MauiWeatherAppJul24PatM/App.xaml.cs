using MauiWeatherAppJul24PatM.Pages;
namespace MauiWeatherAppJul24PatM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new WeatherInfoPage1();
        }
    }
}

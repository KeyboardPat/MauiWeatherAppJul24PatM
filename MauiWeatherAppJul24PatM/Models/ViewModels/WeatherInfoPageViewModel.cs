using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiWeatherAppJul24PatM.Services;
using System;
using System.Threading.Tasks;

namespace MauiWeatherAppJul24PatM.Models.ViewModels
{
    internal partial class WeatherInfoPageViewModel : ObservableObject
    {
        private readonly WeatherApiService _weatherApiService;

        public WeatherInfoPageViewModel()
        {
            _weatherApiService = new WeatherApiService();
        }

        [ObservableProperty]
        private string latitude;

        [ObservableProperty]
        private string longitude;

        [ObservableProperty]
        private string weatherIcon;

        [ObservableProperty]
        private int temperature;

        [ObservableProperty]
        private string weatherDescr;

        [ObservableProperty]
        private string location;

        [ObservableProperty]
        private int humidity;

        [ObservableProperty]
        private string cloudcover;

        [ObservableProperty]
        private string daytime;

        [RelayCommand]
        private async Task FetchWeatherInfo()
        {
            Console.WriteLine("Fetching weather information for location...");
            try
            {
                var weatherApiResponse = await _weatherApiService.FetchWeatherInfo(Latitude, Longitude);

                if (weatherApiResponse != null && weatherApiResponse.Current != null)
                {
                    var currentWeather = weatherApiResponse.Current;
                    WeatherIcon = currentWeather.WeatherIcons;
                    Console.WriteLine(currentWeather.WeatherIcons);
                    Temperature = currentWeather.Temperature;
                    WeatherDescr = currentWeather.Weather_Descriptions;
                    Location = $"{weatherApiResponse.Location.Name}, {weatherApiResponse.Location.Country}";
                    Humidity = currentWeather.Humidity;
                    Cloudcover = currentWeather.CloudCover.ToString();
                    Daytime = currentWeather.IsDay;
                }
                else
                {
                    Console.WriteLine("Weather information is null or incomplete.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while fetching weather information: {ex.Message}");
            }
        }

    }
}


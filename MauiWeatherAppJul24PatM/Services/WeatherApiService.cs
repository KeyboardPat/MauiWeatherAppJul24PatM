using MauiWeatherAppJul24PatM.Models.ApiModels;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace MauiWeatherAppJul24PatM.Services
{
    class WeatherApiService
    {
        private readonly HttpClient _httpClient;

        public WeatherApiService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(Constants.API_BASE_URL);
        }

        public async Task<ApiResponse> FetchWeatherInfo(string latitude, string longitude)
        {
            if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
            {
                return null;
            }

            try
            {
                Console.WriteLine("Off to fetch the weather info");
                var jsonResponse = await _httpClient.GetStringAsync($"current?access_key={Constants.API_KEY}&query={latitude},{longitude}");
                Console.WriteLine($"API Response: {jsonResponse}");

                var response = JsonSerializer.Deserialize<ApiResponse>(jsonResponse);
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

    }
}

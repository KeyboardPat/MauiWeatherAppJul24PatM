using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MauiWeatherAppJul24PatM.Models.ApiModels
{
    class ApiResponse
    {
        [JsonPropertyName("request")]
        public ApiResponseRequest Request { get; set; }

        [JsonPropertyName("location")]
        public ApiResponseLocation Location { get; set; }

        [JsonPropertyName("current")]
        public ApiResponseCurrent Current { get; set; }
    }

    public class ApiResponseRequest
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("query")]
        public string Query { get; set; }

        [JsonPropertyName("language")]
        public string Language { get; set; }

        [JsonPropertyName("unit")]
        public string unit { get; set; }
    }

    public class ApiResponseLocation
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }

        [JsonPropertyName("latitude")]
        public string Lat { get; set; }

        [JsonPropertyName("longitude")]
        public string Lon { get; set; }

        [JsonPropertyName("timezone")]
        public string Timezone_id { get; set; }

        [JsonPropertyName("local time")]
        public string Localtime { get; set; }

        [JsonPropertyName("localtime_epoch")]
        public int localtime_epoch { get; set; }

        [JsonPropertyName("utc")]
        public string Utc_offset { get; set; }
    }

    public class ApiResponseCurrent
    {
        [JsonPropertyName("observation time")]
        public string ObservationTime { get; set; }

        [JsonPropertyName("temperature")]
        public int Temperature { get; set; }

        [JsonPropertyName("weather_icons")]
        public string WeatherIcons { get; set; }

        public string Weather_Descriptions { get; set; }
        public int WindSpeed { get; set; }
        public int WindDegree { get; set; }
        public string WindDir { get; set; }

        public int Humidity { get; set; }
        public int CloudCover { get; set; }
        public int FeelsLike { get; set; }
        public int UvIndex { get; set; }
        public int Visibility { get; set; }
        public string IsDay { get; set; }
        public int Weather_code { get; set; }
        public int Pressure { get; set; }
        public int Precip { get; set; }



    }




}

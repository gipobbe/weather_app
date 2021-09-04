using System.Collections.Generic;
using System.Text.Json.Serialization;
using weather_app.Modules.WeatherInfos.Dtos;

namespace weather_app.Modules.Forecasts.Dtos
{
    public class CurrentForecastReadDto
    {
        [JsonPropertyName("dt")]
        public long Dt { get; set; }

        [JsonPropertyName("sunrise")]
        public long Sunrise { get; set; }
      
        [JsonPropertyName("sunset")]
        public long Sunset { get; set; }
      
        [JsonPropertyName("temp")]
        public double Temperature { get; set; }
      
        [JsonPropertyName("feels_like")]
        public double FeelsLike { get; set; } // Human perception
      
        [JsonPropertyName("pressure")]
        public double Pressure { get; set; } // Atmosferic pressure on the sea level, hPa
      
        [JsonPropertyName("humidity")]
        public int Humidity { get; set; } // %
      
        [JsonPropertyName("dew_point")]
        public double DewPoint { get; set; }
      
        [JsonPropertyName("uvi")]
        public double Uvi { get; set; }
      
        [JsonPropertyName("clouds")]
        public int Clouds { get; set; } // cloudiness %
      
        [JsonPropertyName("visibility")]
        public int Visibility { get; set; }
      
        [JsonPropertyName("wind_speed")]
        public double WindSpeed { get; set; }
      
        [JsonPropertyName("wind_deg")]
        public int WindDeg { get; set; }  // Wind direction, degrees
      
        [JsonPropertyName("wind_gust")]
        public double? WindGust { get; set; }
      
        [JsonPropertyName("rain")]
        public double? Rain { get; set; } // rain volume on the last hour, mm
      
        [JsonPropertyName("snow")]
        public double? Snow { get; set; } // snow volume on the last hour, mm
      
        [JsonPropertyName("weather")]
        public ICollection<WeatherInfoReadDto> Weathers { get; set; }
    }
}
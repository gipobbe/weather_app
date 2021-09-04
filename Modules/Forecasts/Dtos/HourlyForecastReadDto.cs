using System.Collections.Generic;
using System.Text.Json.Serialization;
using weather_app.Modules.WeatherInfos.Dtos;

namespace weather_app.Modules.Forecasts.Dtos
{
    public class HourlyForecastReadDto
    {
        [JsonPropertyName("dt")]
        public long Dt { get; set; }

        [JsonPropertyName("temp")]
        public double Temperature { get; set; }
        
        [JsonPropertyName("feels_like")]
        public double FeelsLike { get; set; }

        [JsonPropertyName("pressure")]
        public double Pressure { get; set; }
        
        [JsonPropertyName("humidity")]
        public double Humidity { get; set; }
        
        [JsonPropertyName("dew_point")]
        public double DewPoint { get; set; }
        
        [JsonPropertyName("uvi")]
        public double Uvi { get; set; }
        
        [JsonPropertyName("clouds")]
        public double Clouds { get; set; }
        
        [JsonPropertyName("visibility")]
        public double Visibility { get; set; }
        
        [JsonPropertyName("wind_speed")]
        public double WindSpeed { get; set; }
        
        [JsonPropertyName("wind_deg")]
        public double WindDeg { get; set; }
        
        [JsonPropertyName("wind_gust")]
        public double WindGust { get; set; }
        
        [JsonPropertyName("weather")]
        public ICollection<WeatherInfoReadDto> Weathers { get; set; }
        
        [JsonPropertyName("pop")]
        public double Pop { get; set; }
    }
}
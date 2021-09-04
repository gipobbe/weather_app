using System.Collections.Generic;
using System.Text.Json.Serialization;
using weather_app.Modules.FeelsLikes.Dtos;
using weather_app.Modules.Temperatures.Dtos;
using weather_app.Modules.WeatherInfos.Dtos;

namespace weather_app.Modules.Forecasts.Dtos
{
    public class DailyForecastReadDto
    {
        [JsonPropertyName("dt")]
        public long Dt { get; set; }
        
        [JsonPropertyName("sunrise")]
        public long Sunrise { get; set; }
        
        [JsonPropertyName("sunset")]
        public long Sunset { get; set; }
        
        [JsonPropertyName("moonrise")]
        public long Moonrise { get; set; }
        
        [JsonPropertyName("moonset")]
        public long Moonset { get; set; }
        
        [JsonPropertyName("moon_phase")]
        public double MoonPhase { get; set; }
        
        [JsonPropertyName("temp")]
        public TemperatureReadDto Temperature { get; set; }
        
        [JsonPropertyName("feels_like")]
        public FeelsLikeReadDto FeelsLike { get; set; }

        [JsonPropertyName("pressure")]
        public double Pressure { get; set; }
        
        [JsonPropertyName("humidity")]
        public double Humidity { get; set; }
        
        [JsonPropertyName("dew_point")]
        public double DewPoint { get; set; }
        
        [JsonPropertyName("wind_speed")]
        public double WindSpeed { get; set; }
        
        [JsonPropertyName("wind_deg")]
        public double WindDeg { get; set; }
        
        [JsonPropertyName("wind_gust")]
        public double WindGust { get; set; }
        
        [JsonPropertyName("weather")]
        public ICollection<WeatherInfoReadDto> Weathers { get; set; }
        
        [JsonPropertyName("clouds")]
        public double Clouds { get; set; }
        
        [JsonPropertyName("pop")]
        public double Pop { get; set; }
        
        [JsonPropertyName("rain")]
        public double? Rain { get; set; }
        
        [JsonPropertyName("uvi")]
        public double Uvi { get; set; }
    }
}
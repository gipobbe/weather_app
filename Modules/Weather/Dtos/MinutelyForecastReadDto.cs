using System;
using System.Text.Json.Serialization;

namespace weather_app.Modules.Weather.Dtos
{
    public class MinutelyForecastReadDto
    {
        [JsonPropertyName("dt")]
        public  long Dt { get; set; }
        
        [JsonPropertyName("precipitation")]
        public double Precipitation { get; set; }
    }
}
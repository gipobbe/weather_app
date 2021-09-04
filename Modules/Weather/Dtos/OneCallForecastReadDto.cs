using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace weather_app.Modules.Weather.Dtos
{
    public class OneCallForecastReadDto
    {
        [JsonPropertyName("lat")]
        public double Latitude { get; set; }
        
        [JsonPropertyName("lon")]
        public double Longitude { get; set; }
        
        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }
        
        [JsonPropertyName("timezone_offset")]
        public double TimezoneOffset { get; set; }
        
        [JsonPropertyName("current")]
        public CurrentForecastReadDto CurrentForecastReadDto { get; set; }
        
        [JsonPropertyName("minutely")]
        public ICollection<MinutelyForecastReadDto> MinutelyForecastReadDtos { get; set; }
        
        [JsonPropertyName("hourly")]
        public ICollection<HourlyForecastReadDto> HourlyForecastReadDtos { get; set; }
        
        [JsonPropertyName("daily")]
        public ICollection<DailyForecastReadDto> DailyForecastReadDtos { get; set; }
        
        [JsonPropertyName("alerts")]
        public ICollection<MeteoAlertReadDto> MeteoAlertReadDtos { get; set; }
    }
}
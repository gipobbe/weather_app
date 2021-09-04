using System.Collections.Generic;
using System.Text.Json.Serialization;
using weather_app.Modules.Alerts.Dtos;

namespace weather_app.Modules.Forecasts.Dtos
{
    using Alert = Alerts.Entities.Alert;

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
        public ICollection<AlertReadDto>? MeteoAlertReadDtos { get; set; }
    }
}
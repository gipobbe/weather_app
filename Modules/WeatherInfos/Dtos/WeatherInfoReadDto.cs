using System.Text.Json.Serialization;

namespace weather_app.Modules.WeatherInfos.Dtos
{
    public class WeatherInfoReadDto
    {
        [JsonPropertyName("id")]
        public int ExternalId { get; set; }
        
        [JsonPropertyName("main")]
        public string Main { get; set; }
        
        [JsonPropertyName("description")]
        public string Description { get; set; }
        
        [JsonPropertyName("icon")]
        public string Icon { get; set; }
    }
}
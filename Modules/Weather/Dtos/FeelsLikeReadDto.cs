using System.Text.Json.Serialization;

namespace weather_app.Modules.Weather.Dtos
{
    public class FeelsLikeReadDto
    {
        [JsonPropertyName("day")]
        public double Day { get; set; }
        
        [JsonPropertyName("night")]
        public double Night { get; set; }
        
        [JsonPropertyName("eve")]
        public double Eve { get; set; }
        
        [JsonPropertyName("morn")]
        public double Morn { get; set; }
    }
}
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace weather_app.Modules.Alerts.Dtos
{
    public class AlertReadDto
    {
        [JsonPropertyName("sender_name")]
        public string SenderName { get; set; }
        
        [JsonPropertyName("event")]
        public string Event { get; set; }
        
        [JsonPropertyName("start")]
        public long StartAt { get; set; }
        
        [JsonPropertyName("end")]
        public long EndAt { get; set; }
        
        [JsonPropertyName("description")]
        public string Description { get; set; }
        
        [JsonPropertyName("tags")]
        public ICollection<string> Tags { get; set; }
    }
}
using System;
using System.Collections.Generic;

namespace weather_app.Modules.Weather.Entities
{
    public class MeteoAlert
    {
        public Guid Id { get; set; }
        
        public string SenderName { get; set; }
        
        public string Event { get; set; }
        
        public DateTime StartAt { get; set; }
        
        public DateTime EndAt { get; set; }
        
        public string Description { get; set; }
        
        public string Tags { get; set; }
    }
}
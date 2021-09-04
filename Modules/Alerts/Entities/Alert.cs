using System;

namespace weather_app.Modules.Alerts.Entities
{
    public class Alert
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
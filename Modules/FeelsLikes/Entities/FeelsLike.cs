using System;

namespace weather_app.Modules.FeelsLikes.Entities
{
    public class FeelsLike
    {
        public Guid Id { get; set; }
        
        public double Day { get; set; }
        public double Night { get; set; }
        public double Eve { get; set; }
        public double Morn { get; set; }
    }
}
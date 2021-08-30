using System;

namespace weather_app.Modules.Weather.Entities
{
    public class Temperature
    {
        public Guid Id { get; set; }
        
        public double Day { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }
        public double Nigh { get; set; }
        public double Eve { get; set; }
        public double Morn { get; set; }
    }
}
using System;

namespace weather_app.Modules.Temperatures.Entities
{
    public class Temperature
    {
        public Guid Id { get; set; }
        
        public double Day { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }
        public double Night { get; set; }
        public double Eve { get; set; }
        public double Morn { get; set; }
    }
}
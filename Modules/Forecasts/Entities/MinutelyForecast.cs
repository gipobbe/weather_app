using System;

namespace weather_app.Modules.Forecasts.Entities
{
    public class MinutelyForecast
    {
        public Guid Id { get; set; }
        
        public  DateTime Dt { get; set; }
        public double Precipitation { get; set; }
    }
}
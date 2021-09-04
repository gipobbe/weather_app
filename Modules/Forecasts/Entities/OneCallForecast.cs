using System;
using System.Collections.Generic;
using weather_app.Modules.Alerts.Entities;
using weather_app.Modules.Weather.Entities;

namespace weather_app.Modules.Forecasts.Entities
{
    public class OneCallForecast
    {
        public Guid Id { get; set; }
        
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        
        public string Timezone { get; set; }
        public double TimezoneOffset { get; set; }
        
        public CurrentForecast CurrentForecast { get; set; }
        
        public ICollection<MinutelyForecast> MinutelyForecasts { get; set; }
        
        public ICollection<HourlyForecast> HourlyForecasts { get; set; }
        
        public ICollection<DailyForecast> DailyForecasts { get; set; }
        
        public ICollection<Alert>? MeteoAlert { get; set; }
    }
}
using System;
using System.Collections.Generic;
using weather_app.Modules.Forecasts.Entities;
using weather_app.Modules.Weather.Entities;

namespace weather_app.Modules.WeatherInfos.Entities
{
    public class WeatherInfo
    {
        public Guid Id { get; set; }
        public int ExternalId { get; set; }
        
        public string Main { get; set; }
        
        public string Description { get; set; }
        
        public string Icon { get; set; }
        
        public ICollection<CurrentForecast> CurrentForecasts { get; set; }
        
        public ICollection<DailyForecast> DailyForecasts { get; set; }
        
        public ICollection<HourlyForecast> HourlyForecasts { get; set; }
    }
}
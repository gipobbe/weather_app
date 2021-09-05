using System;
using System.Collections.Generic;
using weather_app.Modules.FeelsLikes.Entities;
using weather_app.Modules.Temperatures.Entities;
using weather_app.Modules.WeatherInfos.Entities;

namespace weather_app.Modules.Forecasts.Entities
{
    public class DailyForecast
    {
        public Guid Id { get; set; }
        
        public DateTime Dt { get; set; }
        public DateTime Sunrise { get; set; }
        public DateTime Sunset { get; set; }
        public DateTime Moonrise { get; set; }
        public DateTime Moonset { get; set; }
        public double MoonPhase { get; set; }
        
        public Temperature Temperature { get; set; }
        
        public FeelsLike FeelsLike { get; set; }

        public double Pressure { get; set; }
        public double Humidity { get; set; }
        public double DewPoint { get; set; }
        public double WindSpeed { get; set; }
        public double WindDeg { get; set; }
        public double WindGust { get; set; }
        
        public ICollection<WeatherInfo> WeatherInfos { get; set; }
        
        public double Clouds { get; set; }
        public double Pop { get; set; }
        public double? Rain { get; set; }
        public double Uvi { get; set; }
    }
}
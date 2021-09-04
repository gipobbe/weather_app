using System;
using System.Collections.Generic;
using weather_app.Modules.WeatherInfos.Entities;

namespace weather_app.Modules.Weather.Entities
{
    public class HourlyForecast
    {
        public Guid Id { get; set; }

        public DateTime Dt { get; set; }

        public double Temperature { get; set; }
        public double FeelsLike { get; set; }

        public double Pressure { get; set; }
        public double Humidity { get; set; }
        public double DewPoint { get; set; }
        public double Uvi { get; set; }
        public double Clouds { get; set; }
        public double Visibility { get; set; }

        public double WindSpeed { get; set; }
        public double WindDeg { get; set; }
        public double WindGust { get; set; }

        public ICollection<WeatherInfo> Weathers { get; set; }

        public double Pop { get; set; }
    }
}
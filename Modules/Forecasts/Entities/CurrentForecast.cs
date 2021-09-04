using System;
using System.Collections.Generic;
using weather_app.Modules.WeatherInfos.Entities;

namespace weather_app.Modules.Forecasts.Entities
{
    public class CurrentForecast
    {
      public Guid Id { get; set; }
      
      public DateTime Dt { get; set; }

      public DateTime Sunrise { get; set; }
      
      public DateTime Sunset { get; set; }
      
      public double Temperature { get; set; }
      
      public double FeelsLike { get; set; } // Human perception
      
      public double Pressure { get; set; } // Atmosferic pressure on the sea level, hPa
      
      public int Humidity { get; set; } // %
      
      public double DewPoint { get; set; }
      
      public double Uvi { get; set; }
      
      public int Clouds { get; set; } // cloudiness %
      
      public int Visibility { get; set; }
      
      public double WindSpeed { get; set; }
      
      public int WindDeg { get; set; }  // Wind direction, degrees
      
      public double? WindGust { get; set; }
      
      public double? Rain { get; set; } // rain volume on the last hour, mm
      
      public double? Snow { get; set; } // snow volume on the last hour, mm
      
      public ICollection<WeatherInfo> Weathers { get; set; }
    }
}
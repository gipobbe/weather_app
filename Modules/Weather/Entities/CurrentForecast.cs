using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace weather_app.Modules.Weather.Entities
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
      
      public int Umidity { get; set; } // %
      
      public double DewPoint { get; set; }
      
      public double Uvi { get; set; }
      
      public int Clouds { get; set; } // cloudiness %
      
      public int Visibility { get; set; }
      
      public double WindSpeed { get; set; }
      
      public int WindDeg { get; set; }  // Wind direction, degrees
      
      public double? WindGust { get; set; }
      
      public double? Rain { get; set; } // rain volume on the last hour, mm
      
      public double? Snow { get; set; } // snow volume on the last hour, mm
      
      public ICollection<Weather> Weathers { get; set; }
    }
}
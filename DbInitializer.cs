using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace weather_app
{
    public class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.Migrate();

            context.Database.GetService<IDatabaseCreator>().EnsureCreated();

            if (context.WeatherForecasts.Any())
            {
                return;
            }

            var forecasts = new WeatherForecast[]
            {
                new WeatherForecast {TemperatureC = 10, Summary = "Prov1", Date = DateTime.Now},
                new WeatherForecast {TemperatureC = 10, Summary = "Prova2", Date = DateTime.Now},
                new WeatherForecast {TemperatureC = 10, Summary = "Prova3", Date = DateTime.Now},
                new WeatherForecast {TemperatureC = 10, Summary = "Prova4", Date = DateTime.Now},
                new WeatherForecast {TemperatureC = 10, Summary = "Prova5", Date = DateTime.Now},
            };

            foreach (var fore in forecasts)
            {
                context.WeatherForecasts.Add(fore);
            }

            context.SaveChanges();
        }
    }
}
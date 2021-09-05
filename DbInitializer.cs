using System.Linq;
using Microsoft.EntityFrameworkCore;
using weather_app.Modules.WeatherInfos.Entities;


namespace weather_app
{
    public class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.Migrate();

            if (context.WeatherInfos.Any())
            {
                return;
            }

            var weatherSeeds = new WeatherInfo[]
            {
                new WeatherInfo { ExternalId = 1, Description = "Test1", Icon = "0000", Main = "Test1"},
                new WeatherInfo { ExternalId = 2, Description = "Test2", Icon = "0000", Main = "Test2"},
                new WeatherInfo { ExternalId = 3, Description = "Test3", Icon = "0000", Main = "Test3"},
            };

            foreach (var seed in weatherSeeds)
            {
                context.WeatherInfos.Add(seed);
            }

            context.SaveChanges();
        }
    }
}
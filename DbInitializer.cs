using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using weather_app.Modules.Weather.Entities;

namespace weather_app
{
    public class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.Migrate();

            if (context.Weather.Any())
            {
                return;
            }

            var weatherSeeds = new Weather[]
            {
                new Weather { Id = 1, Description = "Test1", Icon = "0000", Main = "Test1"},
                new Weather { Id = 2, Description = "Test2", Icon = "0000", Main = "Test2"},
                new Weather { Id = 3, Description = "Test3", Icon = "0000", Main = "Test3"},
            };

            foreach (var seed in weatherSeeds)
            {
                context.Weather.Add(seed);
            }

            context.SaveChanges();
        }
    }
}
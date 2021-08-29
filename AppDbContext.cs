using Microsoft.EntityFrameworkCore;

namespace weather_app
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        
        public DbSet<WeatherForecast> WeatherForecasts { get; init; }
    }
}
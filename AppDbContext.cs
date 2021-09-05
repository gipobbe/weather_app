using Microsoft.EntityFrameworkCore;
using weather_app.Modules.Alerts.Entities;
using weather_app.Modules.FeelsLikes.Entities;
using weather_app.Modules.Forecasts.Entities;
using weather_app.Modules.Temperatures.Entities;
using weather_app.Modules.Weather.Entities;
using weather_app.Modules.WeatherInfos.Entities;

namespace weather_app
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<CurrentForecast> CurrentForecast { get; set; }
        
        public DbSet<DailyForecast> DailyForecasts { get; set; }
        public DbSet<FeelsLike> FeelsLikes { get; set; }
        public DbSet<HourlyForecast> HourlyForecasts { get; set; }
        
        public DbSet<Alert> MeteoAlerts { get; set; }
        public DbSet<MinutelyForecast> MinutelyForecasts { get; set; }
        public DbSet<OneCallForecast> OneCallForecasts { get; set; }
        public DbSet<Temperature> Temperatures { get; set; }
        public DbSet<WeatherInfo> WeatherInfos { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
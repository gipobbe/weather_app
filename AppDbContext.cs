using Microsoft.EntityFrameworkCore;
using weather_app.Modules.Weather.Entities;

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
        
        public DbSet<MeteoAlert> MeteoAlerts { get; set; }
        public DbSet<MinutelyForecast> MinutelyForecasts { get; set; }
        public DbSet<OneCallForecast> OneCallForecasts { get; set; }
        public DbSet<Temperature> Temperatures { get; set; }
        
        public DbSet<Weather> Weather { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<CurrentForecastWeather>().HasKey(sc => new { sc.CurrentForecastID, sc.WeatherId });
            //
            // modelBuilder.Entity<CurrentForecastWeather>()
            //     .HasOne<Weather>(p => p.Weather)
            //     .WithMany(p => p.CurrentForecastWeathers)
            //     .HasForeignKey(sc => sc.WeatherId);
            //
            // modelBuilder.Entity<CurrentForecastWeather>()
            //     .HasOne<CurrentForecast>(sc => sc.CurrentForecast)
            //     .WithMany(s => s.CurrentForecastWeathers)
            //     .HasForeignKey(sc => sc.CurrentForecastID);
            
        }
    }
}
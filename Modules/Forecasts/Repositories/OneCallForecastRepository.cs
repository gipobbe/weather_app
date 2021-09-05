using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using weather_app.Modules.Forecasts.Entities;
using weather_app.Modules.WeatherInfos.Entities;
using weather_app.Modules.WeatherInfos.Repositories;

namespace weather_app.Modules.Forecasts.Repositories
{
    public class OneCallForecastRepository
    {
        private AppDbContext _appDbContext;
        private WeatherInfoRepository _weatherInfoRepository;

        public OneCallForecastRepository(AppDbContext appDbContext, WeatherInfoRepository weatherInfoRepository)
        {
            _appDbContext = appDbContext;
            _weatherInfoRepository = weatherInfoRepository;
        }

        public ICollection<OneCallForecast> GetAll()
        {
            return _appDbContext.OneCallForecasts.ToList();
        }

        public OneCallForecast GetById(Guid id)
        {
            return _appDbContext.OneCallForecasts.Find(id);
        }

        public async Task<OneCallForecast> GetByIdWithRelations(Guid id)
        {
            var entities = await _appDbContext.OneCallForecasts
                .Include(i => i.DailyForecasts)
                .ThenInclude(i => i.WeatherInfos)
                .Include(i => i.HourlyForecasts)
                .ThenInclude(i => i.WeatherInfos)
                .Include(i => i.MinutelyForecasts)
                .Include(i => i.CurrentForecast)
                .ThenInclude(i => i.WeatherInfos)
                .Include(i => i.MeteoAlert)
                .AsNoTracking()
                .AsSplitQuery()
                .ToListAsync();

            return entities.First(i => i.Id == id);
        }

        public async Task Create(OneCallForecast oneCallForecast)
        {
            _appDbContext.OneCallForecasts.Add(oneCallForecast);
        }

        public OneCallForecast Delete(Guid id)
        {
            OneCallForecast oneCallForecast = _appDbContext.OneCallForecasts.Find(id);
            _appDbContext.OneCallForecasts.Remove(oneCallForecast);
            return oneCallForecast;
        }

        public OneCallForecast Update(OneCallForecast oneCallForecast)
        {
            _appDbContext.Entry(oneCallForecast).State = EntityState.Modified;
            return oneCallForecast;
        }
        
        public async Task Save()
        {
            await _appDbContext.SaveChangesAsync();
        }
    }
}
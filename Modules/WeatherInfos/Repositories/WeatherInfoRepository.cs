using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using weather_app.Modules.WeatherInfos.Entities;

namespace weather_app.Modules.WeatherInfos.Repositories
{
    public class WeatherInfoRepository
    {
        private AppDbContext _appDbContext;

        public WeatherInfoRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public ICollection<WeatherInfo> GetAll()
        {
            return _appDbContext.WeatherInfos.ToList();
        }

        public WeatherInfo GetById(int id)
        {
            return _appDbContext.WeatherInfos.Find(id);
        }

        public WeatherInfo Create(WeatherInfo weatherInfo)
        {
            return _appDbContext.WeatherInfos.Add(weatherInfo).Entity;
        }

        public WeatherInfo Delete(int id)
        {
            WeatherInfo weatherInfo = _appDbContext.WeatherInfos.Find(id);
            _appDbContext.WeatherInfos.Remove(weatherInfo);
            return weatherInfo;
        }

        public WeatherInfo Update(WeatherInfo weatherInfo)
        {
            _appDbContext.Entry(weatherInfo).State = EntityState.Modified;
            return weatherInfo;
        }

        public async Task Save()
        {
            await _appDbContext.SaveChangesAsync();
        }
    }
}
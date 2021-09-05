using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using weather_app.Core.AppHttpClient;
using weather_app.Modules.Forecasts.Dtos;
using weather_app.Modules.Forecasts.Mappings;
using weather_app.Modules.Forecasts.Repositories;
using weather_app.Modules.WeatherInfos.Entities;
using weather_app.Modules.WeatherInfos.Mappings;
using weather_app.Modules.WeatherInfos.Repositories;

namespace weather_app.Modules.Forecasts.Services
{
    public class WeatherService
    {
        private AppHttpClient _appHttpClient;
        private OneCallForecastRepository _oneCallForecastRepository;
        private WeatherInfoRepository _weatherInfoRepository;

        public WeatherService(AppHttpClient appHttpClient, OneCallForecastRepository oneCallForecastRepository, WeatherInfoRepository weatherInfoRepository)
        {
            _appHttpClient = appHttpClient;
            _oneCallForecastRepository = oneCallForecastRepository;
            _weatherInfoRepository = weatherInfoRepository;
        }
        
        public async Task GetData()
        {
            var url = "https://api.openweathermap.org/data/2.5/onecall?lat=45.4152&lon=11.8818&appid=7379d0b2527f78290d1532e34e1524b1&units=metric&=";
            
            var oneCallForecastReadDto = await _appHttpClient.Get<OneCallForecastReadDto>(url);

            var oneAndForAll = ForecastsMappings.Map(oneCallForecastReadDto);
            
            await _oneCallForecastRepository.Create(oneAndForAll);

            await _oneCallForecastRepository.Save();

            var cicio = "Ciao";
        }
    }
}
using System.Text.Json;
using System.Threading.Tasks;
using weather_app.Core.AppHttpClient;
using weather_app.Modules.Weather.Dtos;
using weather_app.Modules.Weather.Entities;

namespace weather_app.Modules.Weather.Services
{
    public class WeatherService
    {
        private AppHttpClient _appHttpClient;

        public WeatherService(AppHttpClient appHttpClient)
        {
            this._appHttpClient = appHttpClient;
        }
        
        public async Task GetData()
        {
            var url = "https://api.openweathermap.org/data/2.5/onecall?lat=45.4152&lon=11.8818&appid=7379d0b2527f78290d1532e34e1524b1&units=metric&=";
            
            var result = await _appHttpClient.Get<OneCallForecastReadDto>(url);

            var cicio = "Ciao";
        }
    }
}
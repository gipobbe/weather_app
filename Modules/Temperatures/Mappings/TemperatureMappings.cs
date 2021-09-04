using weather_app.Modules.Temperatures.Dtos;
using weather_app.Modules.Temperatures.Entities;

namespace weather_app.Modules.Temperatures.Mappings
{

    public class TemperatureMappings
    {
        public static Temperature Map(TemperatureReadDto readDto)
        {
            var entity = new Entities.Temperature()
            {
                Day = readDto.Day,
                Min = readDto.Min,
                Max = readDto.Max,
                Night = readDto.Night,
                Eve = readDto.Eve,
                Morn = readDto.Morn
            };
            return entity;
        }
    }
}
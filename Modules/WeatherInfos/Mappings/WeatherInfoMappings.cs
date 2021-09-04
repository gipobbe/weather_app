using System;
using System.Collections.Generic;
using System.Linq;
using weather_app.Modules.WeatherInfos.Entities;
using weather_app.Modules.WeatherInfos.Dtos;

namespace weather_app.Modules.WeatherInfos.Mappings
{
    public class WeatherInfoMappings
    {
        public static WeatherInfo Map(WeatherInfoReadDto readDto)
        {
            var entity = new WeatherInfo()
            {
                Id = readDto.Id,
                Main = readDto.Main,
                Description = readDto.Description,
                Icon = readDto.Icon
            };

            return entity;
        }

        public static ICollection<WeatherInfo> Map(ICollection<WeatherInfoReadDto> readDtos)
        {
            var entities = new List<WeatherInfo>();

            foreach (var readDto in readDtos)
            {
                entities.Add(Map(readDto));   
            }

            return entities;
        }
    }
}
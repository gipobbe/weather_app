using System;
using System.Collections.Generic;
using weather_app.Modules.Alerts.Mappings;
using weather_app.Modules.FeelsLikes.Mappings;
using weather_app.Modules.Forecasts.Dtos;
using weather_app.Modules.Forecasts.Entities;
using weather_app.Modules.Temperatures.Mappings;
using weather_app.Modules.Weather.Entities;
using weather_app.Modules.WeatherInfos.Entities;
using weather_app.Modules.WeatherInfos.Mappings;

namespace weather_app.Modules.Forecasts.Mappings
{
    public class ForecastsMappings
    {
        public static CurrentForecast Map(CurrentForecastReadDto readDto)
        {
            var entity = new CurrentForecast()
            {
                Dt = DateTimeOffset.FromUnixTimeSeconds(readDto.Dt).UtcDateTime,
                Sunrise = DateTimeOffset.FromUnixTimeSeconds(readDto.Sunrise).UtcDateTime,
                Sunset = DateTimeOffset.FromUnixTimeSeconds(readDto.Sunset).UtcDateTime,
                Temperature = readDto.Temperature,
                FeelsLike = readDto.FeelsLike,
                Pressure = readDto.Pressure,
                Humidity = readDto.Humidity,
                DewPoint = readDto.DewPoint,
                Uvi = readDto.Uvi,
                Clouds = readDto.Clouds,
                Visibility = readDto.Visibility,
                WindSpeed = readDto.WindSpeed,
                WindDeg = readDto.WindDeg,
                WindGust = readDto.WindGust,
                WeatherInfos = WeatherInfoMappings.Map(readDto.Weathers),
                Rain = readDto.Rain,
                Snow = readDto.Snow,
            };
            return entity;
        }

        public static ICollection<DailyForecast> Map(ICollection<DailyForecastReadDto> readDtos)
        {
            var entities = new List<DailyForecast>();

            foreach (var readDto in readDtos)
            {
                entities.Add(Map(readDto));
            }

            return entities;
        }
        
        public static DailyForecast Map(DailyForecastReadDto readDto)
        {
            var entity = new DailyForecast()
            {
                Dt = DateTimeOffset.FromUnixTimeSeconds(readDto.Dt).UtcDateTime,
                Sunrise = DateTimeOffset.FromUnixTimeSeconds(readDto.Sunrise).UtcDateTime,
                Sunset = DateTimeOffset.FromUnixTimeSeconds(readDto.Sunset).UtcDateTime,
                Moonrise = DateTimeOffset.FromUnixTimeSeconds(readDto.Moonrise).UtcDateTime,
                Moonset = DateTimeOffset.FromUnixTimeSeconds(readDto.Moonset).UtcDateTime,
                MoonPhase = readDto.MoonPhase,
                Temperature = TemperatureMappings.Map(readDto.Temperature),
                FeelsLike = FeelsLikeMappings.Map(readDto.FeelsLike),
                Pressure = readDto.Pressure,
                Humidity = readDto.Humidity,
                DewPoint = readDto.DewPoint,
                WindSpeed = readDto.WindSpeed,
                WindDeg = readDto.WindDeg,
                WindGust = readDto.WindGust,
                Clouds = readDto.Clouds,
                WeatherInfos = WeatherInfoMappings.Map(readDto.Weathers),
                Pop = readDto.Pop,
                Rain = readDto.Rain,
                Uvi = readDto.Uvi
            };
            return entity;
        }

        public static ICollection<HourlyForecast> Map(ICollection<HourlyForecastReadDto> readDtos)
        {
            var entities = new List<HourlyForecast>();

            foreach (var readDto in readDtos)
            {
                entities.Add(Map(readDto));
            }

            return entities;
        }
        
        public static HourlyForecast Map(HourlyForecastReadDto readDto)
        {
            var entity = new HourlyForecast()
            {
                Dt = DateTimeOffset.FromUnixTimeSeconds(readDto.Dt).UtcDateTime,
                Temperature = readDto.Temperature,
                FeelsLike = readDto.FeelsLike,
                Pressure = readDto.Pressure,
                Humidity = readDto.Humidity,
                DewPoint = readDto.DewPoint,
                Uvi = readDto.Uvi,
                Clouds = readDto.Clouds,
                Visibility = readDto.Visibility,
                WindSpeed = readDto.WindSpeed,
                WindDeg = readDto.WindDeg,
                WindGust = readDto.WindGust,
                WeatherInfos = WeatherInfoMappings.Map(readDto.Weathers),
                Pop = readDto.Pop
            };

            return entity;
        }

        public static ICollection<MinutelyForecast> Map(ICollection<MinutelyForecastReadDto> readDtos)
        {
            var entities = new List<MinutelyForecast>();

            foreach (var readDto in readDtos)
            {
                entities.Add(Map(readDto));
            }

            return entities;
        }

        public static MinutelyForecast Map(MinutelyForecastReadDto readDto)
        {
            var entity = new MinutelyForecast()
            {
                Dt = DateTimeOffset.FromUnixTimeSeconds(readDto.Dt).UtcDateTime,
                Precipitation = readDto.Precipitation
            };
            return entity;
        }

        public static OneCallForecast Map(OneCallForecastReadDto readDto)
        {
            var entity = new OneCallForecast()
            {
                Latitude = readDto.Latitude,
                Longitude = readDto.Longitude,
                Timezone = readDto.Timezone,
                TimezoneOffset = readDto.TimezoneOffset,
                CurrentForecast = Map(readDto.CurrentForecastReadDto),
                MinutelyForecasts = Map(readDto.MinutelyForecastReadDtos),
                HourlyForecasts = Map(readDto.HourlyForecastReadDtos),
                DailyForecasts = Map(readDto.DailyForecastReadDtos),
                MeteoAlert = AlertMappings.Map(readDto.MeteoAlertReadDtos)
            };

            return entity;
        }
    }
}
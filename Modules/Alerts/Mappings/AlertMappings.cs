using System;
using System.Collections.Generic;
using weather_app.Modules.Alerts.Entities;
using weather_app.Modules.Alerts.Dtos;

namespace weather_app.Modules.Alerts.Mappings
{

    public class AlertMappings
    {
        public static Alert Map(AlertReadDto readDto)
        {
            var entity = new Alert()
            {
                SenderName = readDto.SenderName,
                Event = readDto.Event,
                StartAt = DateTimeOffset.FromUnixTimeSeconds(readDto.StartAt).UtcDateTime,
                EndAt = DateTimeOffset.FromUnixTimeSeconds(readDto.EndAt).UtcDateTime,
                Description = readDto.Description,
                Tags = readDto.Tags.ToString()
            };
            return entity;
        }

        public static ICollection<Alert> Map(ICollection<AlertReadDto>? readDtos)
        {
            var entities = new List<Alert>();

            if (readDtos != null)
            {
                foreach (var readDto in readDtos)
                {
                    entities.Add(Map(readDto));
                }
            }

            return entities;
        }
    }
}
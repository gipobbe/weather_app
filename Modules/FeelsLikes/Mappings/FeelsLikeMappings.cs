using weather_app.Modules.FeelsLikes.Dtos;
using weather_app.Modules.FeelsLikes.Entities;

namespace weather_app.Modules.FeelsLikes.Mappings
{
    public class FeelsLikeMappings
    {
        public static FeelsLike Map(FeelsLikeReadDto readDto)
        {
            var entity = new FeelsLike()
            {
                Day = readDto.Day,
                Night = readDto.Night,
                Eve = readDto.Eve,
                Morn = readDto.Morn
            };
            return entity;
        }
    }
}
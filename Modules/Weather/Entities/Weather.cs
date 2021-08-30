using System;
using System.Collections.Generic;

namespace weather_app.Modules.Weather.Entities
{
    public class Weather
    {
        public int Id { get; set; }
        
        public string Main { get; set; }
        
        public string Description { get; set; }
        
        public string Icon { get; set; }
    }
}
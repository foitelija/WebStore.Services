using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorShop.Shared
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }
        public string Username { get; set; } // for JWT test.

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}

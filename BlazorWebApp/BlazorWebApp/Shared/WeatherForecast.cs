﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorWebApp.Shared
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public bool Precipitation { get; set; }

        public string CloudCover { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}

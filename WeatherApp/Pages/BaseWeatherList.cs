using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEManagement.Models;

namespace WeatherApp.Pages
{
    public class BaseWeatherList : ComponentBase
    {
        public IEnumerable<Weather> WeatherForcasts { get; private set; }

        //calling method a razor component life cycle method which gets called during component initialization
        protected override Task OnInitializedAsync()
        {
            LoadWeather();
            return base.OnInitializedAsync();
        }

        //Hard coded date, trying out the output list
        public void LoadWeather()
        {
            Weather w1 = new Weather
            {
                WeatherID = 1,
                Date = new DateTime(2016,01,01),
                Location = "Ute",
                Temperature = 23.3M,
                Humidity = 41,

            };
            Weather w2 = new Weather
            {
                WeatherID = 1,
                Date = new DateTime(2016, 01, 02),
                Location = "Ute",
                Temperature = 24.3M,
                Humidity = 42,

            };
            Weather w3 = new Weather
            {
                WeatherID = 1,
                Date = new DateTime(2016, 01, 03),
                Location = "Ute",
                Temperature = 25.3M,
                Humidity = 44,

            };

            WeatherForcasts = new List<Weather> { w1, w2, w3 };
        }
    }
}

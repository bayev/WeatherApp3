using EmployeeManagement.Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEManagement.Models;

namespace ApiManagement.Api.Models
{
    public class WeatherRepository : IWeatherRepository
    {
        private readonly AppDbContext appDbContext;

        public WeatherRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public Task<Weather> AddWeatherDay(Weather weather)
        {
            throw new NotImplementedException();
        }

        public void DeleteWeather(int WeatherID)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Weather>> GetWeatherData()
        {
            return await appDbContext.Weather.ToListAsync();
  
        }

        public async Task<Weather> GetWeatherDay(int WeatherID)
        {
            return await appDbContext.Weather.FirstOrDefaultAsync(e => e.WeatherID == WeatherID);
        }

        public Task<Weather> UpdateWeatherDay(Weather weather)
        {
            throw new NotImplementedException();
        }
    }
}

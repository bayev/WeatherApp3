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
        public async Task<IEnumerable<Weather>> GetWeatherData()
        {
            return await appDbContext.Weather.ToListAsync();
  
        }
    }
}

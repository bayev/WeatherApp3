using EmployeeManagement.Api.Models;
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
        public Task<IEnumerable<Weather>> GetWeatherData()
        {
            throw new NotImplementedException();
        }
    }
}

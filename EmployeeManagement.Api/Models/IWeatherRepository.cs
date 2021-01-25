using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEManagement.Models;

namespace ApiManagement.Api.Models
{
    public interface IWeatherRepository
    {
        Task<IEnumerable<Weather>> GetWeatherData();
    }
}

using ApiManagement.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEManagement.Models;

namespace ApiManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        

        public readonly IWeatherRepository weatherRepository;

        public WeatherController(IWeatherRepository weatherRepository)
        {
            this.weatherRepository = weatherRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetWeatherData()
        {
            try
            {
                return Ok(await weatherRepository.GetWeatherData());
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the databse.");
            }

        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Weather>> GetWeatherData(int id)
        {
            try
            {
                var result = await weatherRepository.GetWeatherDay(id);
                if (result == null)
                {
                    return NotFound();
                }
                else
                {
                    return result;
                }
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the databse.");
            }
        }
    }
}

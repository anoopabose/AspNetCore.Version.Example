using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dell.Elements.Globalization;
using Globalization.Extensions.Versions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace  Study.Core.Api.Version.Controllers
{
    [ApiController]
    [V1]
    [Route("api/[controller]")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IGlobalization _globalization;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            // _globalization = globalization;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        //[HttpGet("Countries")]
        //public Task<IList<Country>> GetCountries()
        //{
        //   return _globalization.GetAllCountries();
        //}
    }
}

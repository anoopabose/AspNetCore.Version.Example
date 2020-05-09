using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dell.Elements.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Globalization.Extensions.Versions;

namespace  Study.Core.Api.Version.V3.Controllers
{

    [ApiController]
    // [ApiVersion("3.0")]
    [V2]
    [Produces("application/json")]
    [Route("api/{version:apiVersion}/[controller]")]
    public class WeatherForecast3Controller : ControllerBase
    {
        const string ByIdRouteName = "Get" + nameof(V3);

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecast3Controller> _logger;
        private readonly IGlobalization _globalization;

        public WeatherForecast3Controller(ILogger<WeatherForecast3Controller> logger)
        {
            _logger = logger;
            // _globalization = globalization;
        }

        [HttpGet(Name = ByIdRouteName)]
        [ProducesResponseType(typeof(IEnumerable<WeatherForecast>), 200)]
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

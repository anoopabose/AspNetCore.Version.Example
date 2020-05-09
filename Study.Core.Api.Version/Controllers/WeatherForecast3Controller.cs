using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Study.Core.Api.Version.Extensions.Versions;

namespace Study.Core.Api.Version.V3.Controllers
{

    [ApiController]
    // [ApiVersion("3.0")]
    [V3]
    [Produces("application/json")]
    [Route("api/v{version:apiVersion}/WeatherForecast")]
    public class WeatherForecast3Controller : ControllerBase
    {
        const string ByIdRouteName = "Get" + nameof(V3);

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecast3Controller> _logger;

        public WeatherForecast3Controller(ILogger<WeatherForecast3Controller> logger)
        {
            _logger = logger;
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

    }
}

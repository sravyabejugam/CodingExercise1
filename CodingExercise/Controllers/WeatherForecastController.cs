using CodingExercise.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace CodingExercise.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly FizzBuzz _fizzBuzz;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, FizzBuzz fizzbuzz)
        {
            _logger = logger;
            _fizzBuzz = fizzbuzz;
        }

        [HttpPost(Name = "GetWeatherForecast")]
        public ArrayList Get([FromBody]ArrayList arr)
        {
            var arrlist3 = _fizzBuzz.GetandPost(arr);
            /* return Enumerable.Range(1, 5).Select(index => new WeatherForecast
             {
                 Date = DateTime.Now.AddDays(index),
                 TemperatureC = Random.Shared.Next(-20, 55),
                 Summary = Summaries[Random.Shared.Next(Summaries.Length)]
             })
             .ToArray();*/
            return arrlist3;
        }

    }
}

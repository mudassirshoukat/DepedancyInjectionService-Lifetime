using DepInjServiceLifetime.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DepInjServiceLifetime.Controllers
{
   [ApiController]
   [Route("[controller]")]
   public class WeatherForecastController : ControllerBase
   {
      private static readonly string[] Summaries = new[]
      {
           "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
       };
      private readonly IScopedService scopedService;
      private readonly ISingletonService singletonService;
      private readonly ITransientService transientService;

      public WeatherForecastController(IScopedService scopedService,ISingletonService singletonService,ITransientService transientService)
        {
         this.scopedService = scopedService;
         this.singletonService = singletonService;
         this.transientService = transientService;
      }



        [HttpGet(Name = "GetWeatherForecast")]
      public IEnumerable<WeatherForecast> Get()
      {
         Debug.WriteLine("*********** \n");

         return Enumerable.Range(1, 5).Select(index => new WeatherForecast
         {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
         })
         .ToArray();
      }
   }
}

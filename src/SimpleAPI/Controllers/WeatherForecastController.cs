using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
       return new string[] {"Changed","Values" };
    }

    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
       return "Joey";
    }



 //   private static readonly string[] Summaries = new[]
 //   {
 //       "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
  //  };

  //  private readonly ILogger<WeatherForecastController> _logger;

  //  public WeatherForecastController(ILogger<WeatherForecastController> logger)
  //  {
 //       _logger = logger;
  //  }

   // [HttpGet(Name = "GetWeatherForecast")]
  //  public IEnumerable<WeatherForecast> Get()
   // {
   //     return Enumerable.Range(1, 5).Select(index => new WeatherForecast
   //     {
   //         Date = DateTime.Now.AddDays(index),
   //         TemperatureC = Random.Shared.Next(-20, 55),
   //         Summary = Summaries[Random.Shared.Next(Summaries.Length)]
   //     })
   //     .ToArray();
  //  }
}

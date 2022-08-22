using Microsoft.AspNetCore.Mvc;
using Services;

namespace Freebob.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    readonly StudentServices _studentServices;
    public WeatherForecastController(ILogger<WeatherForecastController> logger, 
     StudentServices studentServices)
    {
        _studentServices = studentServices;
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public void Get()
    {
        _studentServices.Default();
    }
}

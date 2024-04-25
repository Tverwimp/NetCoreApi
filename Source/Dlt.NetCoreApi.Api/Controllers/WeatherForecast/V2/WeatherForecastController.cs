using Microsoft.AspNetCore.Mvc;

namespace Dlt.NetCoreApi.Api.Controllers.WeatherForecast.V2;

using Asp.Versioning;
using Dto;

[ApiController]
[ApiVersion(2)]
[ApiExplorerSettings(GroupName = "v2")]
[Route("api/v{v:apiVersion}/[controller]")]
[Route("api/v{v:apiVersion}/weather-forecasts")]

public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
   // [Route("weather-forecasts")]
    public IEnumerable<WeatherForecastResponseModel> GetWeatherForecasts()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecastResponseModel
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)],
            Version = 2
        })
        .ToArray();
    }

    
    [HttpGet]
    [Route("v2")]
    public IEnumerable<WeatherForecastResponseModel> GetWeatherForecastsV21()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecastResponseModel
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)],
            Version = 2
        })
        .ToArray();
    }
}

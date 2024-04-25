using Microsoft.AspNetCore.Mvc;

namespace Dlt.NetCoreApi.Api.Controllers.WeatherForecast.V1;

using Asp.Versioning;
using Dto;

[ApiController]
[ApiVersion(1)]
[ApiExplorerSettings(GroupName = "v1")]
//[Route("api/v{v:apiVersion}/[controller]/[action]")]
[Route("api/v{v:apiVersion}/[controller]")]
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

    //[HttpGet(Name = "weather-forecasts")]
    [HttpGet]
    [Route("weather-forecasts")]
    public IEnumerable<WeatherForecastResponseModel> GetWeatherForecasts()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecastResponseModel
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }

    [HttpGet]
    [Route("tests")]
    public IEnumerable<WeatherForecastResponseModel> GetTest()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecastResponseModel
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
    //[HttpGet(Name = "WeatherForecastsV11")]
    //[ApiExplorerSettings(GroupName = "Second")]
    //[Route("weather-forecasts-v11")]
    //public IEnumerable<WeatherForecastResponseModel> GetWeatherForecastsV11()
    //{
    //    return Enumerable.Range(1, 5).Select(index => new WeatherForecastResponseModel
    //    {
    //        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
    //        TemperatureC = Random.Shared.Next(-20, 55),
    //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
    //    })
    //    .ToArray();
    //}
}

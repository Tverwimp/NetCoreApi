namespace Dlt.NetCoreApi.Api.Controllers.WeatherForecast.V1.Dto;

public class WeatherForecastResponseModel
{
    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
}

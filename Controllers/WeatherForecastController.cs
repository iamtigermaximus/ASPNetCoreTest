using Microsoft.AspNetCore.Mvc;
using ASPNetCoreTest.Services;
using ASPNetCoreTest.Models;

namespace ASPNetCoreTest.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IWeatherForecastService _service;

    public WeatherForecastController(ILogger<WeatherForecastController> logger,IWeatherForecastService service)
    {
        _logger = logger;
        _service= service;
        _logger.LogInformation("Hello Siegfred");
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return _service.Forecast(3);
    }

    [HttpGet("{days}")]
    public IEnumerable<WeatherForecast> GetByDays(int days)
    {
        return _service.Forecast(days);
    }
}

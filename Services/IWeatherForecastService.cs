namespace ASPNetCoreTest.Services;

using ASPNetCoreTest.Models;

public interface IWeatherForecastService
{
  IEnumerable<WeatherForecast> Forecast(int days);
}
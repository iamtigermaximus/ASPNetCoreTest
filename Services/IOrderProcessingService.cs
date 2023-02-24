namespace ASPNetCoreTest.Services;

using ASPNetCoreTest.Models;

public interface IOrderProcessingService
{
  IEnumerable<OrderItem> Forecast(int days);
}
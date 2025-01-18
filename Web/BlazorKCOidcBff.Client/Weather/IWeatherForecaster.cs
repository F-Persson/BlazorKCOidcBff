
namespace BlazorKCOidcBff.Client.Weather;

public interface IWeatherForecaster
{
    Task<IEnumerable<WeatherForecast>> GetWeatherForecastAsync();
    Task<string> GetUserRoleStringFromServer();
}

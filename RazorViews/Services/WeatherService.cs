using RazorViews.Interfaces;
using RazorViews.Models;

namespace RazorViews.Services;

public class WeatherService : IWeatherService
{
    readonly List<CityWeather> cityWeatherReport = [
        new("NYC", "New York", DateTime.Now.AddMinutes(-1), 25),
        new("LDN", "London", DateTime.Now.AddMinutes(-2), 40),
        new("PAR", "Paris", DateTime.Now.AddSeconds(-30), 15),
        new("TRT", "Toronto", DateTime.Now.AddSeconds(-45), -15)
    ];

    public async Task<IEnumerable<CityWeather>> GetCityWeatherListAsync()
    {
        return await Task.FromResult(cityWeatherReport);
    }

    public async Task<CityWeather?> GetWeatherByCityCodeAsync(string cityCode)
    {
        var cityWeather = cityWeatherReport.FirstOrDefault(c => string.Equals(c.CityCode, cityCode, StringComparison.CurrentCultureIgnoreCase));
        return await Task.FromResult(cityWeather);
    }
}
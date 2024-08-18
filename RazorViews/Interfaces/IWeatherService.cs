using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RazorViews.Models;

namespace RazorViews.Interfaces
{
    public interface IWeatherService
    {
        Task<IEnumerable<CityWeather>> GetCityWeatherListAsync();

        Task<CityWeather?> GetWeatherByCityCodeAsync(string cityCode);
    }
}
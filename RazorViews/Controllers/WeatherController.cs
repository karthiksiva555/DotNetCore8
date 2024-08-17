using Microsoft.AspNetCore.Mvc;
using RazorViews.Models;

namespace RazorViews.Controllers;

[Route("[controller]")]
public class WeatherController : Controller
{
    readonly List<CityWeather> cityWeatherReport = [
        new("NYC", "New York", DateTime.Now.AddMinutes(-1), 25),
        new("LDN", "London", DateTime.Now.AddMinutes(-2), 40),
        new("PAR", "Paris", DateTime.Now.AddSeconds(-30), 15),
        new("TRT", "Toronto", DateTime.Now.AddSeconds(-45), -15)
    ];

    [HttpGet("")]
    public IActionResult GetAllCities()
    {
        return View(cityWeatherReport);
    }

    [HttpGet("bycity/{cityCode?}")]
    public IActionResult GetCityByCode(string cityCode)
    {
        var cityWeather = string.IsNullOrEmpty(cityCode) ? null : cityWeatherReport.FirstOrDefault(c => string.Equals(c.CityCode, cityCode, StringComparison.CurrentCultureIgnoreCase));
        if(cityWeather == null)
        {
            return View("Error");
        }

        return View("GetCityWeather", cityWeather);
    }
    
    [HttpGet("city/{cityCode?}")]
    public IActionResult CityByCode(string cityCode)
    {
        var cityWeather = string.IsNullOrEmpty(cityCode) ? null : cityWeatherReport.FirstOrDefault(c => c.CityCode == cityCode);

        return PartialView("_CityDetail", cityWeather);
    }
}
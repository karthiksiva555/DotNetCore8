using Microsoft.AspNetCore.Mvc;
using RazorViews.Interfaces;

namespace RazorViews.Controllers;

[Route("[controller]")]
public class WeatherController : Controller
{
    private readonly IWeatherService _weatherService;
    public WeatherController(IWeatherService weatherService)
    {
        _weatherService = weatherService;
    }
    [HttpGet("")]
    public async Task<IActionResult> GetAllCitiesAsync()
    {
        var cities = await _weatherService.GetCityWeatherListAsync();
        return View(cities);
    }

    [HttpGet("bycity/{cityCode?}")]
    public async Task<IActionResult> GetCityByCodeAsync(string cityCode)
    {
        var cityWeather = await _weatherService.GetWeatherByCityCodeAsync(cityCode);
        if(cityWeather == null)
        {
            return View("Error");
        }

        return View("GetCityWeather", cityWeather);
    }
    
    [HttpGet("city/{cityCode?}")]
    public async Task<IActionResult> CityByCode(string cityCode)
    {
        var cityWeather = await _weatherService.GetWeatherByCityCodeAsync(cityCode);

        return PartialView("_CityDetail", cityWeather);
    }

    [HttpGet("city-list")]
    public async Task<IActionResult> GetCityListAsync()
    {
        var allCities = await _weatherService.GetCityWeatherListAsync();
        return View("GetCityList", allCities);
    }
}
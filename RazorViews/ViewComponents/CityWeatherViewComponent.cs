using Microsoft.AspNetCore.Mvc;
using RazorViews.Interfaces;

namespace RazorViews.ViewComponents;

public class CityWeatherViewComponent(IWeatherService weatherService) : ViewComponent
{
    private readonly IWeatherService _weatherService = weatherService;

    public async Task<IViewComponentResult> InvokeAsync(string cityCode)
    {
        var cityWeather = await _weatherService.GetWeatherByCityCodeAsync(cityCode);
        return View(cityWeather);
    }
}
using ConfigurationExample.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ConfigurationExample.Controllers;

[Route("[controller]")]
public class WeatherController : Controller
{
    private readonly WeatherApiOptions _weatherApiOptions;
    
    public WeatherController(IOptions<WeatherApiOptions> options)
    {
        _weatherApiOptions = options.Value;
    }

    [HttpGet]
    public IActionResult Index()
    {
        ViewBag.WeatherApiId = _weatherApiOptions.ClientId;
        ViewBag.WeatherApiSecret = _weatherApiOptions.ClientSecret;
        return View();
    }
}
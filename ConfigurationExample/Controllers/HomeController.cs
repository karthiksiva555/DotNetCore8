using Microsoft.AspNetCore.Mvc;

namespace ConfigurationExample.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.MyKey1 = _configuration["MyKey1"]!;
            ViewBag.MyKey2 = _configuration.GetValue<string>("MyKey2", "Default Key2")!;
            
            // ViewBag.ClientId = _configuration["WeatherApi:ClientId"]!;
            // ViewBag.ClientSecret = _configuration.GetValue<string>("WeatherApi:ClientSecret", "Default Client Secret")!;
            
            var section = _configuration.GetSection("WeatherApi");
            ViewBag.ClientId = section["ClientId"]!;
            ViewBag.ClientSecret = section.GetValue<string>("ClientSecret", "Default Client Secret")!;
            
            return View();
        }

        [HttpGet("Error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
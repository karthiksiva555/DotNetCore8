using ConfigurationExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ConfigurationExample.Controllers;

[Route("[controller]")]
public class SocialMediaController(IOptions<SocialMediaLinkOptions> socialMediaLinkOptions) : Controller
{
    private readonly IOptions<SocialMediaLinkOptions> _socialMediaLinkOptions = socialMediaLinkOptions;

    [Route("")]
    public IActionResult Index()
    {
        SocialMediaLinkOptions options = _socialMediaLinkOptions.Value;
        return View(options);
    }

    [HttpGet("error")]
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View("Error!");
    }
}
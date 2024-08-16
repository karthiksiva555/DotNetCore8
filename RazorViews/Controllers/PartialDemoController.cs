using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RazorViews.Controllers
{
    [Route("[controller]")]
    public class PartialDemoController : Controller
    {
        private readonly ILogger<PartialDemoController> _logger;

        public PartialDemoController(ILogger<PartialDemoController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewData["Title"] = "Title From Controller";
            return View();
        }

        [HttpGet("about")]
        public IActionResult About()
        {
            return View();
        }

        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RazorViews.Controllers;

[Route("[controller]")]
public class ArticlesController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
}
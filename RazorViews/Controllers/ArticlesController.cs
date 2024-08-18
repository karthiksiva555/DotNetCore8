using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RazorViews.Interfaces;


namespace RazorViews.Controllers;

[Route("[controller]")]
public class ArticlesController : Controller
{
    private readonly IArticlesService _articlesService;

    public ArticlesController(IArticlesService articlesService)
    {
        _articlesService = articlesService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("load-articles")]
    public async Task<IActionResult> LoadArticlesAsync()
    {
        var articles = await _articlesService.GetTopArticles(2);
        return ViewComponent("TopArticles", articles);
    }
}
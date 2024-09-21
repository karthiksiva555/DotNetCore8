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
    private readonly IServiceScopeFactory _serviceScopeFactory;

    public ArticlesController(IArticlesService articlesService, IServiceScopeFactory serviceScopeFactory)
    {
        _articlesService = articlesService;
        _serviceScopeFactory = serviceScopeFactory;
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

    /// <summary>
    /// Action method injection example
    /// </summary>
    /// <param name="articlesService"></param>
    /// <returns></returns>
    [HttpGet("load-articles-new")]
    public async Task<IActionResult> LoadArticlesNewAsync(
        [FromServices] IArticlesService articlesService)
    {
        var articles = await articlesService.GetTopArticles(2);
        return ViewComponent("TopArticles", articles);
    }

    /// <summary>
    /// Child scope example
    /// </summary>
    /// <param name="articlesService"></param>
    /// <returns></returns>
    [HttpGet("load-articles-child-scope")]
    public async Task<IActionResult> LoadArticlesChildScopeAsync()
    {
        var articles = await _articlesService.GetTopArticles(2);

        // Create a child scope to dispose ArticlesService immediately after use
        using(var scope = _serviceScopeFactory.CreateScope())
        {
            var articlesService = scope.ServiceProvider.GetRequiredService<IArticlesService>();
            var newArticles = await articlesService.GetTopArticles(3);
        } // articlesService.Dispose() is called here automatically

        return ViewComponent("TopArticles", articles);
    }

}
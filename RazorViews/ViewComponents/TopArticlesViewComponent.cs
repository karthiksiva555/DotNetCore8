using Microsoft.AspNetCore.Mvc;
using RazorViews.Interfaces;

namespace RazorViews.ViewComponents;

public class TopArticlesViewComponent : ViewComponent
{
    private readonly IArticlesService _articlesService;

    public TopArticlesViewComponent(IArticlesService articlesService)
    {
        _articlesService = articlesService;
    }

    public async Task<IViewComponentResult> InvokeAsync(int count)
    {
        var topArticles = await _articlesService.GetTopArticles(count);
        return View(topArticles);
    }
}
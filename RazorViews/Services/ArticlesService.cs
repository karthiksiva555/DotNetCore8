using RazorViews.Interfaces;
using RazorViews.Models;

namespace RazorViews.Services;

public class ArticlesService : IArticlesService, IDisposable
{
    private readonly List<Article> _articles = [
        new Article("Electric Cars", "Are electric cars reliable"),
        new Article("Local Elections", "Who is strong in upcoming local elections"),
        new Article("Latest Tech News", "All the trends and updates in tech industry")
    ];

    public void Dispose()
    {
        // For testing service lifetimes and child scopes;
    }

    public async Task<List<Article>> GetTopArticles(int count)
    {
        return await Task.FromResult(_articles.Take(count).ToList());
    }
}
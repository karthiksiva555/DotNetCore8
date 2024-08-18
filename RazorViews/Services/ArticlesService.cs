using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RazorViews.Interfaces;
using RazorViews.Models;

namespace RazorViews.Services;

public class ArticlesService : IArticlesService
{
    private readonly List<Article> _articles = [
        new Article("Electric Cars", "Are electric cars reliable"),
        new Article("Local Elections", "Who is strong in upcoming local elections"),
        new Article("Latest Tech News", "All the trends and updates in tech industry")
    ];
    public async Task<List<Article>> GetTopArticles()
    {
        return await Task.FromResult(_articles);
    }
}
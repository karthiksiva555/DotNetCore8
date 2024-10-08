using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RazorViews.Models;

namespace RazorViews.Interfaces;

public interface IArticlesService
{
    Task<List<Article>> GetTopArticles(int count);
}
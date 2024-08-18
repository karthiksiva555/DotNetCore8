namespace RazorViews.Models;

public class Article(string name, string description)
{
    public string Name { get; set; } = name;

    public string Description { get; set; } = description;
}
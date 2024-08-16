using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorViews.Models;

public class ListModel(string title, List<string> items)
{
    public string? Title { get; set; } = title;

    public List<string> ListItems { get; set; } = items;
}
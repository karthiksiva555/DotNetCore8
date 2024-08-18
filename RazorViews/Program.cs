using RazorViews.Interfaces;
using RazorViews.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IArticlesService, ArticlesService>();
var app = builder.Build();

app.UseStaticFiles();
app.MapControllers();
app.Run();

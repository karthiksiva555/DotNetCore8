using Autofac;
using Autofac.Extensions.DependencyInjection;
using RazorViews.Interfaces;
using RazorViews.Services;

var builder = WebApplication.CreateBuilder(args);

// Autofac as DI container
// builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
// builder.Host.ConfigureContainer<ContainerBuilder>(cb => {
//     // ArticlesService as Transient
//     cb.RegisterType<ArticlesService>().As<IArticlesService>().InstancePerDependency();
//     // ArticlesService as Scoped
//     cb.RegisterType<ArticlesService>().As<IArticlesService>().InstancePerLifetimeScope();
//     // ArticlesService as Singleton
//     cb.RegisterType<ArticlesService>().As<IArticlesService>().SingleInstance();
// });

builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IArticlesService, ArticlesService>();
builder.Services.AddTransient<IWeatherService, WeatherService>();
var app = builder.Build();

app.UseStaticFiles();
app.MapControllers();
app.Run();

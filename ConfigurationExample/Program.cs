using ConfigurationExample.Options;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.Configure<WeatherApiOptions>
    (builder.Configuration.GetSection("WeatherApi"));

builder.Configuration.AddJsonFile("WeatherApiConfig.json");

var app = builder.Build();

app.UseStaticFiles();
app.MapControllers();

app.Map("/", async (context) => {
    // var myKey = app.Configuration["MyKey"];
    var myKey = app.Configuration.GetValue<string>("NoKey", "Default");
    await context.Response.WriteAsync(myKey!);
});

app.Run();

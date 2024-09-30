var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

app.Map("/", async (context) => {
    // var myKey = app.Configuration["MyKey"];
    var myKey = app.Configuration.GetValue<string>("NoKey", "Default");
    await context.Response.WriteAsync(myKey!);
});

app.Run();

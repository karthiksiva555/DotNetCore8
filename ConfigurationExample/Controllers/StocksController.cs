using ConfigurationExample.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ConfigurationExample.Controllers;

[Route("[controller]")]
public class StocksController(IStocksService stocksService) : Controller
{
    private readonly IStocksService _stocksService = stocksService;

    [Route("")]
    public async Task<IActionResult> Index()
    {
        var stock = await _stocksService.GetQuoteByStockNameAsync("AAPL");
        return View(stock);
    }

    [Route("Error")]
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View("Error!");
    }
}
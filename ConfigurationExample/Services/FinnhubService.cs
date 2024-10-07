using System.Text.Json;
using ConfigurationExample.Interfaces;
using ConfigurationExample.Models;

namespace ConfigurationExample.Services;

public class FinnhubService(IHttpClientFactory httpClientFactory, IConfiguration configuration) : IStocksService
{
    private readonly IHttpClientFactory _httpClientFactory = httpClientFactory;

    private readonly IConfiguration _configuration = configuration;

    public async Task<Stock> GetQuoteByStockNameAsync(string stockName)
    {
        using var client = _httpClientFactory.CreateClient();
        string tokenFromUserSecrets = _configuration["FinhubToken"];
        // Prepare http request with uri and method
        HttpRequestMessage httpRequestMessage = new(HttpMethod.Get, $"https://finnhub.io/api/v1/quote?symbol={stockName}&token={tokenFromUserSecrets}");
        
        // Send the request and get the resopnse
        HttpResponseMessage httpResponseMessage= await client.SendAsync(httpRequestMessage);
        Stream stream = await httpResponseMessage.Content.ReadAsStreamAsync() ?? throw new Exception($"Could not get quote for the symbol {stockName}");
        
        // Convert the response to an object
        Stock stock = JsonSerializer.Deserialize<Stock>(stream);
        stock!.StockName = stockName;
        return stock;
    }
}
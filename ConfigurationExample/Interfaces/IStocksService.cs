using ConfigurationExample.Models;

namespace ConfigurationExample.Interfaces;

public interface IStocksService
{
    Task<Stock> GetQuoteByStockNameAsync(string stockName);
}
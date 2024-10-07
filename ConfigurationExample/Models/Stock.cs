using System.Text.Json.Serialization;

namespace ConfigurationExample.Models;

public class Stock
{
    [JsonIgnore]
    public string StockName { get; set; } = string.Empty;

    [JsonPropertyName("h")]
    public decimal HighPrice { get; set; }

    [JsonPropertyName("l")]
    public decimal LowPrice { get; set; }

    [JsonPropertyName("c")]
    public decimal CurrenPrice { get; set; }

    [JsonPropertyName("o")]
    public decimal OpenPrice { get; set; }
}
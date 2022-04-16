using System.Text.Json.Serialization;

namespace CryptAPI.Responses;

public class ConvertResponse
{
    /// <summary>
    /// The converted value
    /// </summary>
    [JsonPropertyName("value_coin")]
    public string ValueCoin { get; set; }

    /// <summary>
    /// The exchange rate between the 2 currencies
    /// </summary>
    [JsonPropertyName("exchange_rate")]
    public string ExchangeRate { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }
}
using System.Text.Json.Serialization;

namespace CryptAPI.Responses;

public class EstimateResponse
{
    /// <summary>
    /// Status
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>
    /// Estimated cost in the coin
    /// </summary>
    [JsonPropertyName("estimated_cost")]
    public string EstimatedCost { get; set; }

    /// <summary>
    /// Object with the estimated cost in various FIAT currencies.
    /// Keys are the names of the currencies, values are the estimated costs.
    /// </summary>
    [JsonPropertyName("estimated_cost_currency")]
    public EstimatedCostCurrency EstimatedCostCurrency { get; set; }
}

/// <summary>
/// Object with the estimated cost in various FIAT currencies.
/// Keys are the names of the currencies, values are the estimated costs.
/// </summary>
public class EstimatedCostCurrency
{
    [JsonPropertyName("USD")]
    public string USD { get; set; }

    [JsonPropertyName("EUR")]
    public string EUR { get; set; }

    [JsonPropertyName("GBP")]
    public string GBP { get; set; }

    [JsonPropertyName("CAD")]
    public string CAD { get; set; }

    [JsonPropertyName("JPY")]
    public string JPY { get; set; }

    [JsonPropertyName("AED")]
    public string AED { get; set; }

    [JsonPropertyName("DKK")]
    public string DKK { get; set; }

    [JsonPropertyName("BRL")]
    public string BRL { get; set; }

    [JsonPropertyName("CNY")]
    public string CNY { get; set; }

    [JsonPropertyName("HKD")]
    public string HKD { get; set; }

    [JsonPropertyName("INR")]
    public string INR { get; set; }

    [JsonPropertyName("MXN")]
    public string MXN { get; set; }

    [JsonPropertyName("UGX")]
    public string UGX { get; set; }

    [JsonPropertyName("PLN")]
    public string PLN { get; set; }

    [JsonPropertyName("PHP")]
    public string PHP { get; set; }

    [JsonPropertyName("CZK")]
    public string CZK { get; set; }

    [JsonPropertyName("HUF")]
    public string HUF { get; set; }

    [JsonPropertyName("BGN")]
    public string BGN { get; set; }

    [JsonPropertyName("RON")]
    public string RON { get; set; }

    [JsonPropertyName("LKR")]
    public string LKR { get; set; }
}
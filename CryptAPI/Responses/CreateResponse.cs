using System.Text.Json.Serialization;

namespace CryptAPI.Responses;

public class CreateResponse
{
    /// <summary>
    /// Generated Address, give this to your client
    /// </summary>
    [JsonPropertyName("address_in")]
    public string AddressIn { get; set; }

    /// <summary>
    /// Your address(es), where the payment will be forwarded to, should be the same address(es) you provided.
    /// </summary>
    [JsonPropertyName("address_out")]
    public string AddressOut { get; set; }

    /// <summary>
    /// The callback URL you provided
    /// </summary>
    [JsonPropertyName("callback_url")]
    public string CallbackUrl { get; set; }

    /// <summary>
    /// The confirmation priority you requested
    /// </summary>
    [JsonPropertyName("priority")]
    public string Priority { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }
}
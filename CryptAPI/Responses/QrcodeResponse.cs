using System.Text.Json.Serialization;

namespace CryptAPI.Responses;

public class QrcodeResponse
{
    /// <summary>
    /// Status
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>
    /// Base64-encoded image of the QR Code.
    /// Use it like this: <img src='data:image/png;base64,{qr_code}' alt='Payment QR Code'/>
    /// </summary>
    [JsonPropertyName("qr_code")]
    public string QrCode { get; set; }

    /// <summary>
    /// Payment URI, useful if you want to make a clickable payment button.
    /// </summary>
    [JsonPropertyName("payment_uri")]
    public string PaymentUri { get; set; }
}
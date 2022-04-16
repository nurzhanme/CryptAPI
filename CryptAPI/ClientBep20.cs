using System.Text.Json;
using CryptAPI.Responses;

namespace CryptAPI;

public class ClientBep20 : BaseClient
{
    public ClientBep20(HttpClient client) : base(client)
    {
    }
    
    /// <summary>
    /// Check Token (Coin) information
    /// This endpoint is used to check the information for the various tokens
    /// </summary>
    /// <param name="tokenTicker">The token ticker. Currently supported tokens can be checked on the pricing page.</param>
    public async Task Info(string tokenTicker)
    {
        var request = await _client.GetAsync($"bep20/{tokenTicker}/info");
        var response = await request.Content.ReadAsStringAsync();

        Console.WriteLine(response);
    }

    /// <summary>
    /// Create new address
    /// This method is used to generate a new address to give your clients, where they can send payments.
    /// </summary>
    /// <param name="tokenTicker">The token ticker. Currently supported tokens can be checked on the pricing page.</param>
    /// <param name="callbackUrl">The URL the callbacks will be sent to. Must be a valid URL.</param>
    /// <param name="address"></param>
    /// <param name="pending"></param>
    /// <param name="confirmations"></param>
    /// <param name="email"></param>
    /// <param name="post"></param>
    /// <param name="multiChain"></param>
    /// <param name="multiToken"></param>
    /// <returns>CreateResponse</returns>
    public async Task<CreateResponse> Create(string tokenTicker, string callbackUrl, string address, int pending, 
        int confirmations, string email, int post, int multiChain, int multiToken)
    {
        var url = $@"bep20/{tokenTicker}/create?
                callback={callbackUrl}&
                address={address}&
                pending={pending}&
                confirmations={confirmations}&
                email={email}&
                post={post}&
                multi_chain={multiChain}&
                multi_token={multiToken}";
        
        var request = await _client.GetAsync(url);
        var response = await request.Content.ReadAsStringAsync();

        return JsonSerializer.Deserialize<CreateResponse>(response);
    }
    
    /// <summary>
    /// Generate QR Code
    /// This method generates a Base64-encoded image for payments
    /// </summary>
    /// <param name="tokenTicker">The token ticker. Currently supported tokens can be checked on the pricing page.</param>
    /// <param name="address">The payment address (address_in from our system)</param>
    /// <param name="value">Value to request the user, in the main coin (BTC, ETH, etc). Optional.
    /// Note: Some user wallets don't support this, only the address. Use at your own discretion.</param>
    /// <param name="size">Size of the QR Code image in pixels. Min: 64 Max: 1024 Default: 512</param>
    /// <returns>QrcodeResponse</returns>
    public async Task<QrcodeResponse> Qrcode(string tokenTicker, string address, int value, int size)
    {
        var url = $@"bep20/{tokenTicker}/qrcode?
            address={address}&
            value={value}&
            size={size}";
        
        var request = await _client.GetAsync(url);
        var response = await request.Content.ReadAsStringAsync();

        return JsonSerializer.Deserialize<QrcodeResponse>(response);
    }
    
    /// <summary>
    /// Estimate Blockchain Fees
    /// This method allows you to estimate blockchain fees to process a transaction.
    ///
    /// Attention: This is an estimation only, and might change significantly when the transaction is processed.
    /// CryptAPI is not responsible if blockchain fees when forwarding the funds differ from this estimation.
    ///
    /// Note: These not include CryptAPI's fees.
    /// </summary>
    /// <param name="tokenTicker">The token ticker. Currently supported tokens can be checked on the pricing page.</param>
    /// <param name="addresses">The number of addresses to forward the funds to. Default: 1</param>
    /// <returns>EstimateResponse</returns>
    public async Task<EstimateResponse> Estimate(string tokenTicker, int addresses)
    {
        var url = $"bep20/{tokenTicker}/estimate?addresses={addresses}";
        
        var request = await _client.GetAsync(url);
        var response = await request.Content.ReadAsStringAsync();

        return JsonSerializer.Deserialize<EstimateResponse>(response);
    }
    
    /// <summary>
    /// Convert prices
    /// This method allows you to easily convert prices from FIAT to Crypto or even between cryptocurrencies
    /// </summary>
    /// <param name="tokenTicker">The token ticker. Currently supported tokens can be checked on the pricing page.</param>
    /// <param name="value">Value to convert</param>
    /// <param name="from">Currency to convert from, FIAT or crypto</param>
    /// <returns>ConvertResponse</returns>
    public async Task<ConvertResponse> Convert(string[] tokenTicker, int value, string from)
    {
        var url = $"bep20/{tokenTicker}/convert?value={value}&from={from}";
        
        var request = await _client.GetAsync(url);
        var response = await request.Content.ReadAsStringAsync();

        return JsonSerializer.Deserialize<ConvertResponse>(response);
    }
}
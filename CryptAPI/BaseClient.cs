namespace CryptAPI;

public class BaseClient
{
    protected readonly HttpClient _client;

    public BaseClient(HttpClient client)
    {
        _client = client ?? throw new ArgumentNullException(nameof(client));

        _client.BaseAddress = new Uri("https://api.cryptapi.io/");
    }
}
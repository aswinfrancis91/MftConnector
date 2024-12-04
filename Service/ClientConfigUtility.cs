using System.Net.Http.Headers;
using System.Text;
using MftConnector.Models.Service;
using MftConnector.Repo;

namespace MftConnector.Service;

public static class ClientConfigUtility
{
    /// <summary>
    /// Retrieves the client configuration from the database for the specified MFT client type.
    /// </summary>
    /// <param name="clientType">The type of MFT client for which to retrieve the configuration.</param>
    /// <returns>A <see cref="MftConfig"/> object containing the configuration details for the specified client type.</returns>
    private static MftConfig GetClientConfig(MftClient clientType)
    {
        MftConfig config;
        using var db = new MftConfigDbContext();
        config = db.MftConfig.Where(x => x.Client == clientType).FirstOrDefault();
        return config;
    }

    /// <summary>
    /// Configures an HttpClient instance with the necessary settings for the specified MFT client type.
    /// </summary>
    /// <param name="httpClient">The HttpClient instance to be configured.</param>
    /// <param name="clientType">The type of MFT client for which to configure the HttpClient.</param>
    public static void ConfigureClient(HttpClient httpClient, MftClient clientType)
    {
        var config = GetClientConfig(clientType);
        httpClient.BaseAddress = new Uri(config.BaseUrl);
        var base64EncodedAuthenticationString = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{config.Username}:{config.Password}"));
        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString);
    }
}
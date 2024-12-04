using System.Net.Http.Headers;
using System.Text;
using ApiConnector.Repo;

namespace ApiConnector;

public static class ClientConfigUtility
{
    private static MftConfig GetClientConfig(MftClient clientType)
    {
        MftConfig config;
        using var db = new MftConfigDbContext();
        config = db.MftConfig.Where(x => x.Client == clientType).FirstOrDefault();
        return config;
    }

    public static void ConfigureClient(HttpClient httpClient)
    {
        var config = GetClientConfig(MftClient.GoAnywhere);
        httpClient.BaseAddress = new Uri(config.BaseUrl);
        var base64EncodedAuthenticationString = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{config.Username}:{config.Password}"));
        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString);
    }
}
using System.Net.Http.Headers;
using MftConnector.Interfaces;

namespace MftConnector.Models;

public class GoAnywhereMftClient : IMftClient
{
    private readonly HttpClient _httpClient;

    public GoAnywhereMftClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString);
    }

    public void AddUser()
    {
        throw new NotImplementedException();
    }

    public void AddWorkflow()
    {
        throw new NotImplementedException();
    }
}
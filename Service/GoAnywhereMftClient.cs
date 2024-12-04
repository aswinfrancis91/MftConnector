using MftConnector.Interfaces;
using MftConnector.Models.Service;

namespace MftConnector.Service;

public class GoAnywhereMftClient : IMftClient
{
    private readonly HttpClient _httpClient;

    public GoAnywhereMftClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<bool> AddUserAsync(AddUser user)
    {
        var response = await _httpClient.PostAsync("/api/users", null);
        return response.IsSuccessStatusCode;
    }

    public Task<bool> AddWorkflowAsync()
    {
        throw new NotImplementedException();
    }
}
using MftConnector.Interfaces;

namespace MftConnector.Models;

public class GoAnywhereMftClient : IMftClient
{
    private readonly HttpClient _httpClient;

    public GoAnywhereMftClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<bool> AddUserAsync()
    {
        var response = await _httpClient.PostAsync("/api/users", null); // Adjust path and content as needed
        return response.IsSuccessStatusCode;
    }

    public Task<bool> AddWorkflowAsync()
    {
        throw new NotImplementedException();
    }
}
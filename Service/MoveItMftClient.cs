using MftConnector.Interfaces;
using MftConnector.Models.Service;

namespace MftConnector.Service;

public class MoveItMftClient : IMftClient
{
    private readonly HttpClient _httpClient;

    public MoveItMftClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public async Task<bool> AddUserAsync(AddUser user)
    {
        var response = await _httpClient.PostAsync("/api/users", null); // Adjust path and content as needed
        return response.IsSuccessStatusCode;
    }

    public async Task<bool> AddWorkflowAsync()
    {
        throw new NotImplementedException();
    }
}
using MftConnector.Interfaces;

namespace MftConnector.Models;

public class MoveItMftClient : IMftClient
{
    private readonly HttpClient _httpClient;

    public MoveItMftClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public async Task<bool> AddUserAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<bool> AddWorkflowAsync()
    {
        throw new NotImplementedException();
    }
}
using MftConnector.Interfaces;

namespace MftConnector.Models;

public class MoveItMftClient : IMftClient
{
    private readonly HttpClient _httpClient;

    public MoveItMftClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
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
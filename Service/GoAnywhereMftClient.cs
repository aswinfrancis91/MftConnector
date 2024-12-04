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

    /// <summary>
    /// Adds a new user asynchronously using the GoAnywhere MFT service.
    /// </summary>
    /// <param name="user">The user details encapsulated in an <see cref="AddUser"/> object to be added.</param>
    /// <returns>A task representing the asynchronous operation, with a boolean result that indicates success or failure.</returns>
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
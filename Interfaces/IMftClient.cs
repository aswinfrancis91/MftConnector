using MftConnector.Models.Service;

namespace MftConnector.Interfaces;

/// <summary>
/// Defines methods for interacting with an MFT (Managed File Transfer) system,
/// including capabilities to manage users and workflows.
/// </summary>
public interface IMftClient
{
    /// <summary>
    /// Adds a new user asynchronously using one of the MFT service.
    /// </summary>
    /// <param name="user">The user details encapsulated in an <see cref="AddUser"/> object to be added.</param>
    /// <returns>A task representing the asynchronous operation, with a boolean result that indicates success or failure.</returns>
    Task<bool> AddUserAsync(AddUser user);

    /// <summary>
    /// Adds a new workflow asynchronously using the MFT service.
    /// </summary>
    /// <returns>A task representing the asynchronous operation, with a boolean result that indicates success or failure.</returns>
    Task<bool> AddWorkflowAsync();
}
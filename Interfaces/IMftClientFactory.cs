using MftConnector.Models.Service;
using MftConnector.Models.Web;

namespace MftConnector.Interfaces;

public interface IMftClientFactory
{
    /// <summary>
    /// Creates an instance of an <see cref="IMftClient"/> based on the specified client type.
    /// </summary>
    /// <param name="clientType">The type of MFT client to create.</param>
    /// <returns>An instance of <see cref="IMftClient"/> corresponding to the specified client type.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when an unsupported client type is specified.</exception>
    IMftClient Create(MftClient clientType);

    /// <summary>
    /// Creates an instance of <see cref="AddUser"/> based on the AddUserRequest provided.
    /// </summary>
    /// <param name="request">The request object containing the details needed to create a new user, including username, password, and client type.</param>
    /// <returns>An instance of <see cref="AddUser"/> populated with user details from the request.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the specified client type is not supported.</exception>
    AddUser CreateAddUser(AddUserRequest request);
}
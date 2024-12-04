using MftConnector.Interfaces;
using MftConnector.Models.Service;
using MftConnector.Models.Web;

namespace MftConnector.Service;

public class MftClientFactory : IMftClientFactory
{
    private readonly IServiceProvider _serviceProvider;

    public MftClientFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public IMftClient Create(MftClient clientType)
    {
        return clientType switch
        {
            MftClient.GoAnywhere => _serviceProvider.GetRequiredService<GoAnywhereMftClient>(),
            MftClient.MoveIt => _serviceProvider.GetRequiredService<MoveItMftClient>(),
            _ => throw new ArgumentOutOfRangeException(nameof(clientType), clientType, null)
        };
    }

    public AddUser CreateAddUser(AddUserRequest request)
    {
        AddUser user = request.ClientType switch
        {
            MftClient.MoveIt => new MoveItAddUser
            {
                Username = request.Username,
                Password = request.Password,
                CloneFrom = request.CopyFrom
            },
            MftClient.GoAnywhere => new GoAnywhereAddUser
            {
                Username = request.Username,
                Password = request.Password,
                Template = request.CopyFrom,
                FullName = $"{request.FirstName} {request.LastName}",
            },
            _ => throw new ArgumentOutOfRangeException()
        };
        return user;
    }
}
using MftConnector.Interfaces;
using MftConnector.Models;

namespace ApiConnector;

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
}
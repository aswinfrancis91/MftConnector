using MftConnector.Models.Service;

namespace MftConnector.Interfaces;

public interface IMftClientFactory
{
    IMftClient Create(MftClient clientType);
}
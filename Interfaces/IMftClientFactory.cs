using ApiConnector;

namespace MftConnector.Interfaces;

public interface IMftClientFactory
{
    IMftClient Create(MftClient clientType);
}
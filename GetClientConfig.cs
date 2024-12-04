using ApiConnector.Repo;

namespace ApiConnector;

public static class ClientConfig
{
    public static MftConfig GetClientConfig(MftClient clientType)
    {
        MftConfig config;
        using var db = new MftConfigDbContext();
        config = db.MftConfigs.Where(x => x.Client == clientType).FirstOrDefault();

        return config;
    }
}
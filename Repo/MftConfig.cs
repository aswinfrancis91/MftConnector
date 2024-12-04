using System.ComponentModel.DataAnnotations;

namespace ApiConnector.Repo;

public class MftConfig
{
    public string BaseUrl { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    [Key]
    public MftClient Client { get; set; }
}
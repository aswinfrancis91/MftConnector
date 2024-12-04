using MftConnector.Models.Service;

namespace MftConnector.Models.Web;

public class AddUserRequest
{
    public MftClient ClientType { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string CopyFrom { get; set; }
}
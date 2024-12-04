using MftConnector.Interfaces;
using MftConnector.Models.Service;
using MftConnector.Models.Web;
using Microsoft.AspNetCore.Mvc;

namespace MftConnector.Controllers;

[ApiController]
[Route("[controller]")]
public class MftController : ControllerBase
{
    private readonly IMftClientFactory _mftClientFactory;

    public MftController(IMftClientFactory mftClientFactory)
    {
        _mftClientFactory = mftClientFactory;
    }

    [HttpPost("AddUser")]
    public async Task<IActionResult> AddUser([FromBody] AddUserRequest request)
    {
        var client = _mftClientFactory.Create(request.ClientType);
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
        var result = await client.AddUserAsync(user);
        return result ? Ok() : StatusCode(500, "Error creating user");
    }
}
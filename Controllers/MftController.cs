using ApiConnector;
using MftConnector.Interfaces;
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

    [HttpGet]
    public void TestClient(MftClient clientType)
    {
        IMftClient client = _mftClientFactory.Create(clientType);
        client.AddUser();
    }
}
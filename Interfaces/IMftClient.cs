using MftConnector.Models.Service;

namespace MftConnector.Interfaces;

/// <summary>
/// 
/// </summary>
public interface IMftClient
{
    Task<bool> AddUserAsync(AddUser user);
    Task<bool> AddWorkflowAsync();
}
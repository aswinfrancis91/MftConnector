namespace MftConnector.Interfaces;

/// <summary>
/// 
/// </summary>
public interface IMftClient
{
    Task<bool> AddUserAsync();
    Task<bool> AddWorkflowAsync();
}
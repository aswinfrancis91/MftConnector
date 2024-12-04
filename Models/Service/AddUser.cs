namespace MftConnector.Models.Service;

/// <summary>
/// Represents a user to be added, including essential properties such as Username and Password.
/// </summary>
public class AddUser
{
    /// <summary>
    /// Gets or sets the username of the user to be added. This property is required and represents the unique identifier for the user in the system.
    /// </summary>
    public string Username { get; set; }

    /// <summary>
    /// Gets or sets the password for the user to be added. This property is required for authentication purposes and must adhere to the security policies defined by the system.
    /// </summary>
    public string Password { get; set; }
}

/// <summary>
/// Represents a specialized user for the MoveIt system, inheriting basic properties from AddUser and adding specific attributes.
/// </summary>
public class MoveItAddUser : AddUser
{
    public string CloneFrom { get; set; }
}

/// <summary>
/// Represents a user to be added to the GoAnywhere system, inheriting basic properties from AddUser and supplementing with GoAnywhere-specific attributes such as Template and FullName.
/// </summary>
public class GoAnywhereAddUser : AddUser
{
    public string FullName { get; set; }
    public string Template { get; set; }
}
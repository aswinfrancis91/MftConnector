namespace MftConnector.Models.Service;

public class AddUser
{
    public string Username { get; set; }
    public string Password { get; set; }
}

public class MoveItAddUser : AddUser
{
    public string CloneFrom { get; set; }
}

public class GoAnywhereAddUser : AddUser
{
    public string FullName { get; set; }
    public string Template { get; set; }
}
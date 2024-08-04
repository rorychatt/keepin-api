namespace Business.DataStructure;

public class User(UserName name) : IUser
{
    public string Id { get; init; } = $"user_{Guid.NewGuid().ToString()}";
    public UserName Name { get; init; } = name;
    public Inventory Inventory { get; init; } = new();
}
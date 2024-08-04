namespace Business.DataStructure;

public class User : IUser
{
    public string Id { get; init; }
    public UserName Name { get; init; }
    public Inventory Inventory { get; init; }
    
    public User(string id, UserName name, Inventory inventory)
    {
        Id = id;
        Name = name;
        Inventory = inventory;
    }
}
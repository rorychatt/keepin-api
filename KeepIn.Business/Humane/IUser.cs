namespace Business.DataStructure;

public interface IUser
{
    string Id { get; init; }
    UserName Name { get; init; }
    Inventory Inventory { get; init; }
    
}
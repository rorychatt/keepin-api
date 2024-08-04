namespace Business.DataStructure;

public interface UserDetails
{
    string Name { get; init; }
    string Password { get; init; }
    string PhoneNumber { get; init; }
    string Address { get; init; }
    string Role { get; init; }
    Inventory Inventory { get; init; }
}
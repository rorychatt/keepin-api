namespace Business.DataStructure;

public class Item(string name, string description) : IItem
{
    public string Name { get; set; } = name;
    public string Id { get; init; } = $"item_{Guid.NewGuid().ToString()}";
    public string Description { get; set; } = description;
}
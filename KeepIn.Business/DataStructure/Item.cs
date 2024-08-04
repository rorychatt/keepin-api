namespace Business.DataStructure;

public class Item(string name, string id, string description) : IItem
{
    public string Name { get; set; } = name;
    public string Id { get; set; } = id;
    public string Description { get; set; } = description;
}
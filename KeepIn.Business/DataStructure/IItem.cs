namespace Business.DataStructure;

public interface IItem
{
    string Name { get; set; }
    string Id { get; init; }
    string Description { get; set; }
}
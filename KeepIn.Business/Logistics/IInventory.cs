namespace Business.DataStructure;

public interface IInventory
{
    Dictionary<string, Item> Items { get; init; }
    void AddItem(Item item);
    void RemoveItem(string id);
    Item GetItem(string id);
    void Clear();
}
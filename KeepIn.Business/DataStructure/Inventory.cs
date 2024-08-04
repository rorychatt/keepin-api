namespace Business.DataStructure;

public class Inventory : IInventory
{
    public Dictionary<string, Item> Items { get; init; } = new();
    public void AddItem(Item item)
    {
        throw new NotImplementedException();
    }

    public void RemoveItem(string id)
    {
        throw new NotImplementedException();
    }

    public Item GetItem(string id)
    {
        throw new NotImplementedException();
    }

    public void UpdateItem(string id, Item item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }
}
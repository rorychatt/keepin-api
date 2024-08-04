namespace Business.DataStructure;

public class Inventory : IInventory
{
    public Dictionary<string, Item> Items { get; init; } = new();
    public void AddItem(Item item)
    {
        Items.Add(item.Id, item);
    }

    public void RemoveItem(string id)
    {
        Items.Remove(id);
    }

    public Item GetItem(string id)
    {
        return Items[id];
    }

    public void Clear()
    {
        Items.Clear();
    }
}
using Business.DataStructure;

namespace KeepIn.Tests;

public class InventoryTests
{
    [Fact]
    public void InventoryShould_HaveItems()
    {
        var inventory = new Inventory();
        Assert.NotNull(inventory.Items);
    }
    
    [Fact]
    public void InventoryShould_AddItem()
    {
        var inventory = new Inventory();
        var item = new Item("testItem", "a funny item");
        inventory.AddItem(item);
        Assert.Single(inventory.Items);
    }
    
    [Fact]
    public void InventoryShould_RemoveItem()
    {
        var inventory = new Inventory();
        var item = new Item("testItem", "a funny item");
        inventory.AddItem(item);
        inventory.RemoveItem(item.Id);
        Assert.Empty(inventory.Items);
    }
    
    [Fact]
    public void InventoryShould_GetItem()
    {
        var inventory = new Inventory();
        var item = new Item("testItem", "a funny item");
        inventory.AddItem(item);
        var result = inventory.GetItem(item.Id);
        Assert.Equal(item, result);
    }
}
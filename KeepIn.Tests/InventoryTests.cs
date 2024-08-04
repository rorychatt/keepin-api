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
        var item = new Item("1", "Item 1", "Description 1");
        inventory.AddItem(item);
        Assert.Single(inventory.Items);
    }
    
    [Fact]
    public void InventoryShould_RemoveItem()
    {
        var inventory = new Inventory();
        var item = new Item("1", "Item 1", "Description 1");
        inventory.AddItem(item);
        inventory.RemoveItem("1");
        Assert.Empty(inventory.Items);
    }
    
    [Fact]
    public void InventoryShould_GetItem()
    {
        var inventory = new Inventory();
        var item = new Item("1", "Item 1", "Description 1");
        inventory.AddItem(item);
        var result = inventory.GetItem("1");
        Assert.Equal(item, result);
    }
}
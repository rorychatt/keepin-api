using Business.DataStructure;

namespace KeepIn.Tests;

public class UserTests
{
    [Fact]
    public void UserShould_HaveInventory()
    {
        var user = new User(new UserName("Dimas", "Kuznetsov"));
        Assert.NotNull(user.Inventory);
    }
    
    [Fact]
    public void UserShould_HaveId()
    {
        var user = new User(new UserName("Dimas", "Kuznetsov"));
        Assert.NotNull(user.Id);
    }
    
    [Fact]
    public void UserShould_HaveName()
    {
        var user = new User(new UserName("Dimas", "Kuznetsov"));
        Assert.NotNull(user.Name);
    }
    
    [Fact]
    public void UserShould_HaveInventoryItems()
    {
        var user = new User(new UserName("Dimas", "Kuznetsov"));
        var item = new Item("testItem", "a funny item");
        user.Inventory.AddItem(item);
        Assert.Single(user.Inventory.Items);
    }
    
    [Fact]
    public void UserShould_HaveInventoryItems_AfterRemove()
    {
        var user = new User(new UserName("Dimas", "Kuznetsov"));
        var item = new Item("testItem", "a funny item");
        user.Inventory.AddItem(item);
        user.Inventory.RemoveItem(item.Id);
        Assert.Empty(user.Inventory.Items);
    }
    
}
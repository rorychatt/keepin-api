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
}
namespace Business.DataStructure;

public class UserName(string first, string last)
{
    private string First { get; init; } = first;
    private string Last { get; init; } = last;
}
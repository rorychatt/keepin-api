using Business.DataStructure;

namespace KeepIn.Api.Models;

public class UserRepository : IUserRepository
{
    private readonly Dictionary<string, User> _users = new();
    public Task<IEnumerable<User>> GetUsersAsync()
    {
        return Task.FromResult(_users.Values.AsEnumerable());
    }

    public Task<User?> GetUserByIdAsync(string id)
    {
        return Task.FromResult(_users.Values.FirstOrDefault(u => u.Id == id));
    }

    public Task<User?> CreateUserAsync(User user)
    {
        var added = _users.TryAdd(user.Id, user);
        return Task.FromResult(added ? user : null);
    }

    public Task<User?> UpdateUserAsync(User user)
    {
        throw new NotImplementedException();
    }

    public Task DeleteUserAsync(string id)
    {
        throw new NotImplementedException();
    }
}
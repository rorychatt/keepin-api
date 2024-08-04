using Business.DataStructure;

namespace KeepIn.Api.Models;

public interface IUsersRepository
{
    Task<IEnumerable<User>> GetUsersAsync();
    Task<User?> GetUserByIdAsync(string id);
    Task<User?> CreateUserAsync(User user);
    Task<User?> UpdateUserAsync(User user);
    Task DeleteUserAsync(string id);
}
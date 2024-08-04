using Business.DataStructure;
using KeepIn.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace KeepIn.Api.Controllers;

[ApiController]
[Route("api/v1/Inventory")]
public class UserController(IUserRepository userRepository) : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<User>> GetUsers()
    {
        var users = userRepository.GetUsersAsync();
        return Ok(users);
    }

    [HttpGet("{id}")]
    public ActionResult<User?> GetUserById(string id)
    {
        var user = userRepository.GetUserByIdAsync(id);
        return Ok(user);
    }

    [HttpPost]
    public ActionResult<User?> CreateUser(User user)
    {
        var createdUser = userRepository.CreateUserAsync(user);
        return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, createdUser);
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteUser(string id)
    {
        userRepository.DeleteUserAsync(id);
        return Ok();
    }
}
using Business.DataStructure;
using KeepIn.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace KeepIn.Api.Controllers;

[ApiController]
[Route("api/v1/Users")]
public class UsersController(IUsersRepository usersRepository) : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<User>> GetUsers()
    {
        var users = usersRepository.GetUsersAsync();
        return Ok(users);
    }

    [HttpGet("{id}")]
    public ActionResult<User?> GetUserById(string id)
    {
        var user = usersRepository.GetUserByIdAsync(id);
        return Ok(user);
    }

    [HttpPost]
    public ActionResult<User?> CreateUser(User user)
    {
        var createdUser = usersRepository.CreateUserAsync(user);
        return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, createdUser);
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteUser(string id)
    {
        usersRepository.DeleteUserAsync(id);
        return Ok();
    }
}
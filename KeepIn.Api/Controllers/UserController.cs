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
}

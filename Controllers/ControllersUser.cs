using Microsoft.AspNetCore.Mvc;
using Models;
using Services;

namespace ControllersUser;

[ApiController]
[Route("api/[controller]/[action]")]
public class UserController : ControllerBase
{
    UserServices _userService;
    public UserController(UserServices userService)
    {
        _userService = userService;
    }
    [HttpGet("User")]

    public List<User> GetAll()
    {

        return _userService.GetUser();
    }

    [HttpGet("GetCarById")]
    public User GetCarById(int id)
    {
        return _userService.GetUserById(id);
    }

    [HttpPost("Add")]
    public void Add([FromBody] User newUser)
    {
        _userService.AddUser(newUser);
    }

    [HttpGet("Default")]
    public void Default(int id)
    {
        _userService.Default();

    }
    [HttpGet("RemoveUser")]
    public void RemoveUsers(int id)
    {
        _userService.RemoveUser(id);

    }

}
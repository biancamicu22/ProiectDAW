using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProiectDAW.DTO;
using ProiectDAW.Models;
using ProiectDAW.Services;
using ProiectDAW.Utilities;

namespace ProiectDAW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate(UserRequestDTO user)
        {
            var response = _userService.Authenticate(user);

            if (response==null)
            {
                return BadRequest(new { Message = "Username or Password Invalid"});
            }

            return Ok(response);
        }

        [HttpPost("create")]
        public IActionResult Create(UserDTO user)
        {
            user.Role = Role.User;
            _userService.Create(user);
            return Ok();
        }

        [Authorization(Role.Admin)]
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            return null;
        }
    }
}

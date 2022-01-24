using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProiectDAW.DTO;
using ProiectDAW.Models;
using ProiectDAW.Services;

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
        public IActionResult Create(UserRequestDTO user)
        {
            /*var userToCreate = new Utilizator
            {
                Prenume = user.FirstName,
                Nume = user.LastName,
                Username = user.UserName,
                Parola = BCrypt.Net.BCrypt.HashPassword(user.Password),
                Role = Role.User
            };*/
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            return null;
        }
    }
}

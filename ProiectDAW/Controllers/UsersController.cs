using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProiectDAW.DTO;
using ProiectDAW.Models;
using ProiectDAW.Services;
using ProiectDAW.Utilities;
using System;
namespace ProiectDAW.Controllers
{
    [Authorize]
    [Route("utilizator")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [Microsoft.AspNetCore.Authorization.AllowAnonymous]
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
        [Microsoft.AspNetCore.Authorization.AllowAnonymous]
        [HttpPost("create")]
        public IActionResult Create(UserDTO user)
        {
            user.Role = Role.User;
            return Ok(_userService.Create(user));
        }

        [Authorization(Role.Admin)]
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var utilizatori = _userService.GetAll();
            return Ok(utilizatori);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromHeader ]Guid id)
        {
            var currentUser = (Utilizator)HttpContext.Items["User"];
            if (id != currentUser.ID && currentUser.Role != Role.Admin)
            {
                return Unauthorized(new { Message = "Unauthorized" });
            }

            var utilizator = _userService.GetById(id);
            return Ok(utilizator);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using AuthServer.Core;
using BCrypt.Net;
using AuthServer.Services;
using System;

namespace AuthServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IAuthService _authService;

        public AuthController(IUserService userService, IAuthService authService)
        {
            _userService = userService;
            _authService = authService;
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] UserRegistrationDto registrationDto)
        {
            if (_userService.GetUserByUsername(registrationDto.Username) != null)
            {
                return BadRequest("Username is already taken");
            }

            var user = new User
            {
                Username = registrationDto.Username,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(registrationDto.Password) // Using BCrypt for password hashing
            };

            _userService.CreateUser(user);
            return Ok("User registered successfully");
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] UserLoginDto loginDto)
        {
            if (!_userService.ValidateUserCredentials(loginDto.Username, loginDto.Password))
            {
                return Unauthorized("Invalid credentials");
            }

            var user = _userService.GetUserByUsername(loginDto.Username);
            var token = _authService.GenerateJwtToken(user);
            return Ok(new { Token = token });
        }
    }

    public class UserRegistrationDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class UserLoginDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}

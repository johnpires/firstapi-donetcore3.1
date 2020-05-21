using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using ApiCore_JWTAuthentication.Services;
using ApiCore_JWTAuthentication.Models;
using System.Linq;

namespace ApiCore_JWTAuthentication.controller
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase 
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]AuthenticateModel model)
        {
            var user = _userService.Authenticate(model.UserName, model.Password);

            if (user == null)
            {
                return BadRequest(new {message = "Username or password is incorrect"});
            }
            return Ok(user);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();

            return Ok(users);
        }

    }
}
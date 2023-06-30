using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using _3DModels.Models;
using _3DModels.Services;

namespace _3DModels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserService _userService;

        public UsersController(UserService userService)
        {
            _userService = userService;
        }

        // GET: api/Users
        [HttpGet]
        public ActionResult<List<User>> GetUsers()
        {
            var users = _userService.GetAllUser();
            return Ok(users);
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            var user = _userService.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        // GET: api/Users/GetUserByEmail
        [HttpGet("GetUserByEmail")]
        public ActionResult<User> GetUserByEmail([FromQuery] string email)
        {
            var user = _userService.GetIdByEmail(email);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        // POST: api/Users
        [HttpPost]
        public ActionResult<string> PostUser(User user)
        {
            var result = _userService.CreateUser(user);
            return Ok(result);
        }

        // PUT: api/Users/5
        [HttpPut("{id}")]
        public ActionResult<string> PutUser(int id, User user)
        {
            if (id != user.UserId)
            {
                return BadRequest();
            }

            var result = _userService.UpdateUser(user);
            return Ok(result);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public ActionResult<string> DeleteUser(int id)
        {
            var result = _userService.DeleteUserById(id);
            return Ok(result);
        }
    }
}





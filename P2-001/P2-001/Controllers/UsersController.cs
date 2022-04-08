using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace P2_001.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private UsersController _usermanager;
        public UsersController(UsersManager usersManager)
        {
            _usermanager = usersManager;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(_usermanager.GetUsers());
        }
        [HttpPost]
        public IActionResult PostUsers(User user)
        {
            _usermanager.PostUsers(user);
            return Ok();
        }
        [HttpPut]
        public IActionResult PutUsers(User user)
        {
            if (user.CI <= 0 || user.Name == null || user.Name.Trim() == "")
            {

            }
            User updated = _usermanager.PutUsers(user);
            if(updated != null)
            {
                return Ok(updated);
            }
            else
            {
                return BadRequest("El usuario no se encuentra");
            }
        }
        [HttpDelete]
        public IActionResult DeleteUsers()
        {
            return Ok();
        }

        public static implicit operator UsersController(UsersManager v)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EF_Example.Repository;
using EF_Example.Models;

namespace EF_Example.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        UserContext db = new UserContext();

        [HttpGet]
        public IActionResult Get()
        {
            User req = new User() { ID = 20 };
            User getUser = GetUser("GET", req);
            return Ok(getUser);
        }

        [HttpPost]
        public IActionResult Post([FromBody] User newUser)
        {
            User postUser = GetUser("POST", newUser);
            return Ok(postUser);
        }

        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] User userRequest)
        {
            User putUser = GetUser("POST", userRequest);
            return Ok(putUser);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete()
        {
            User putUser = GetUser("DELETE", null);
            return Ok(putUser);
        }


        private User GetUser(string actionType, User user=null)
        {
            User retunUser = new User();

            switch (actionType)
            {
                case "GET":
                    retunUser.ID = 1;
                    retunUser.FirstName = "User First";
                    retunUser.LastName = "User Last Name";
                    retunUser.Age = 10;
                    break;
                case "POST":
                    retunUser.ID = user.ID;
                    retunUser.FirstName = user.FirstName;
                    retunUser.LastName = user.LastName;
                    retunUser.Age = user.Age;
                    break;
                case "PUT":
                    retunUser.FirstName = user.FirstName;
                    retunUser.LastName = user.LastName;
                    retunUser.Age = user.Age;
                    break;
                case "DELETE":
                    retunUser = new User();
                    break;
            }
            return retunUser;
        }
    }
}

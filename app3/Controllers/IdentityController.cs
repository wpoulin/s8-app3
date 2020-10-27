using System;
using System.Collections.Generic;

using app3.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace app3.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        List<string> code = new List<string>()
        {
            "98030f3a-8c43-4137-939b-4d6520af7011",
            "296b8046-9c1b-47d2-b4dd-7e06ea405091",
            "70f46836-faa9-46d6-b51f-cdf3e317f4a6"
        };


        // POST /login
        [HttpPost]
        public IActionResult Login([FromBody] User user)
        {
            if (user.username == "joe" && user.password == "rogan")
            {

            }
            else
            {
                return BadRequest(new { message = "Username or password is incorrect" });
            }
            return Ok(user);
        }

        //[Authorize]
        [HttpGet("{nuclear}")]
        public IActionResult Nuclear()
        {
            return Ok(code);
        }

    }
}

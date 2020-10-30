using System;
using System.Collections.Generic;
using System.Linq;
using app3.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace app3.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        private readonly app3Context _context;

        private readonly ILogger<IdentityController> _logger;

        public IdentityController(app3Context context, ILogger<IdentityController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // POST /login
        [HttpPost("login")]
        public IActionResult Login([FromBody] User user)
        {
            var userAccount = _context.Users.FromSqlRaw("SELECT * FROM Users WHERE Username = '" + user.username + "' && Password = '" + user.password + "'");
            if (userAccount.Count() == 0 )
            {
                return BadRequest(new { message = "Username or password is incorrect" });
            }
            var allUsers = _context.Users.FromSqlRaw("SELECT * FROM Users");
            return Ok(allUsers);
        }

        //[Authorize]
        [HttpGet("nuclear")]
        public IActionResult Nuclear()
        {
            var code = _context.Nuclear_codes.FromSqlRaw("SELECT * FROM Nuclear_codes").ToList();
            return Ok(code);
        }

    }
}
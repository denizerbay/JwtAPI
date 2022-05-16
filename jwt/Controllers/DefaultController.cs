using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jwt.DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace jwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : Controller
    {
        [HttpGet("[action]")]
        public IActionResult Login()
        {
            return Created("", new BuildToken().CreateToken());
        }

        [HttpGet("[action]")]
        [Authorize]
        public IActionResult TestPage()
        {
            return Ok("Test Başarılı");
        }
    }
}

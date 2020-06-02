using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UserData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet("{number}")]
        public async Task<IActionResult> Get([FromRoute] int number)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] User user)
        {
            return Ok();
        }

        [HttpDelete]
        public async  Task<IActionResult> Delete([FromBody] User user)
        {
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Modify([FromBody] User user)
        {
            return Ok();
        }
    }
}
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserData.Core.Interfaces.Services;
using UserData.Core.Models;

namespace UserData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{number}")]
        public async Task<IActionResult> Get([FromRoute] int number)
        {
            if (number <= 0) return BadRequest();

            var user = await _userService.GetAsync(number);
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] User user)
        {
            if (!ModelState.IsValid) return BadRequest();

            await _userService.AddAsync(user);

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] User user)
        {
            if (!ModelState.IsValid) return BadRequest();

            await _userService.DeleteAsync(user);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Modify([FromBody] User user)
        {
            if (!ModelState.IsValid) return BadRequest();

            await _userService.ModifyAsync(user);

            return Ok();
        }
    }
}
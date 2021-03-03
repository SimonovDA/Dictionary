using Dictionary.Data;
using System.Threading.Tasks;
using Dictionary.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dictionary.Web.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserRepository _repository;

        public UserController(UserRepository repository)
        {
            _repository = repository;
        }
        [HttpPost("create")]
        public async Task<ActionResult> CreateUserAsync([FromBody] User newUser)
        {
            var user = await _repository.Create(newUser);
            if (user.Id == null)
                return Conflict("User exists");
            return Ok(user);
        }

        [HttpGet("get")]
        public async Task<ActionResult> GetUserAsync(string id)
        {
            var user = await _repository.Get(id);

            if (user != null)
                return Ok(user);
            return NotFound("User not found");
        }
    }
}

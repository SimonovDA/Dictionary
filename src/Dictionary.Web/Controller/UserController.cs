using System;
using System.Linq;
using System.Threading.Tasks;
using Dictionary.Data;
using Dictionary.Data.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace Dictionary.Web.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly MongoDbContext _context;

        public UserController(MongoDbContext context)
        {
            _context = context;
        }
        [HttpPost("create")]
        public async Task<ActionResult> CreateUserAsync([FromBody] User newUser)
        {
            var collection = _context._mongoDb.GetCollection<User>(nameof(User));
            var user = collection.AsQueryable().Where(x => x.Age == newUser.Age && x.Name == newUser.Name).ToList();
            if (user.Count > 0)
                return BadRequest("User exist");

            await collection.InsertOneAsync(newUser);
            return Ok(newUser);
        }

        [HttpGet("get")]
        public async Task<ActionResult> GetUserAsync(string id)
        {
            var collection = _context._mongoDb.GetCollection<User>(nameof(User));
            try
            {
                var user = collection.AsQueryable().Where(x => x.Id.Equals(id)).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine();
            }

            return Ok();
        }
    }
}

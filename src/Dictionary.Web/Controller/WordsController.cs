﻿using System.Linq;
using System.Threading.Tasks;
using Dictionary.Data;
using Dictionary.Data.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace Dictionary.Web.Controller
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class WordsController : ControllerBase
    {
        private readonly MongoDbContext _context;

        public WordsController(MongoDbContext context)
        {
            _context = context;
        }
        [HttpPost("newUser")]
        private async Task<ActionResult> GetReport([FromBody] User newUser)
        {
            var collection = _context.MongoDb.GetCollection<User>(nameof(User));
            var user = collection.AsQueryable().Where(x => x.Age == newUser.Age && x.Name == newUser.Name).ToList();
            if (user.Count > 0)
                return BadRequest("This user");
            
            await collection.InsertOneAsync(newUser);
            return Ok(newUser);
        }

        [HttpGet("getOk")]
        private async Task<ActionResult> Get()
        {
            return Ok();
        }
    }
}

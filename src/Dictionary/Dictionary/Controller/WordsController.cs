using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Dictionary.Controller
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class WordsController : ControllerBase
    {
        [HttpGet("get")]
        public async Task<ActionResult> GetReport()
        {
            return await Task.Run(Ok) ;
        }
    }
}

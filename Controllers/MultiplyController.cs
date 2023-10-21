using Microsoft.AspNetCore.Mvc;

namespace MyWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MultiplyController : ControllerBase
    {
       [HttpGet("{id}")]
        public ActionResult<int> Multiply(int id)
        {
            // Multiply the id parameter
            int result = id * 10; // Multiplying by 10 as per the original request

            return Ok(result);
        }
    }
}


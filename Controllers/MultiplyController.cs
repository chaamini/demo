using Microsoft.AspNetCore.Mvc;

namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MultiplyController : ControllerBase
    {
        [HttpPost]
        public ActionResult<int> MultiplyByTen([FromBody] int number)
        {
            int result = number * 10;
            return Ok(result);
        }
    }
}


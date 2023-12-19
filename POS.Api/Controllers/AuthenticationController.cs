using Microsoft.AspNetCore.Mvc;

namespace POSApi.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthenticationController : Controller
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok();    
            }
            catch
            {
                return BadRequest(string.Empty);
            }
        }
    }
}

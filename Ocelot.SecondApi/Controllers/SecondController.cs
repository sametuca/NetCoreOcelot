using Microsoft.AspNetCore.Mvc;

namespace Ocelot.SecondApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SecondController : Controller
    {

        [HttpGet("Get")]
        public string Get()
        {
            return "Second Api Work";
        }
    }
}

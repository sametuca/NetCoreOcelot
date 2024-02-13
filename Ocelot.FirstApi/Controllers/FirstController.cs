using Microsoft.AspNetCore.Mvc;

namespace Ocelot.FirstApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FirstController : Controller
    {

        [HttpGet("Get")]

        public string Get()
        {
            return "First Api Work";
        }

    }
}

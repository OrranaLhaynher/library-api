using Microsoft.AspNetCore.Mvc;

namespace MyFirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyFirstAPIController : ControllerBase
    {
        public string Author { get; set; } = "Orrana";
    }
}

using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ramen_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        public ActionResult<IEnumerable<string>> GetString()
        {
            return new string[]{"this", "is", "string"};
        }
    }
}
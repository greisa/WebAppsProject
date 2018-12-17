using System;

namespace Project1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {

        public UsersController()
        {
        }
    }
}

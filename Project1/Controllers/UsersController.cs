using System;

namespace Project1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        [HttpPost("GetUser")]
        public async Task<IActionResult> GetUser(LoginVM user)
        {
            var userDetails = _mapper.Map<UserDetailsDTO>(user);
        }
            public UsersController()
        {
        }
    }
}

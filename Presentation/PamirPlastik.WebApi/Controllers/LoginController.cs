using Microsoft.AspNetCore.Mvc;
using PamirPlastik.Persistence.Context;
using System.Linq;

namespace PamirPlastik.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly PamirPlastikContext _context;

        public LoginController(PamirPlastikContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Login(LoginDto loginDto)
        {
            var user = _context.AppUsers.FirstOrDefault(x => x.Username == loginDto.Username && x.Password == loginDto.Password);
            if (user != null)
            {
                return Ok(new { isSuccess = true, userId = user.AppUserID, name = user.Name + " " + user.Surname });
            }
            return Unauthorized(new { isSuccess = false, message = "Hatalı kullanıcı adı veya şifre!" });
        }
    }

    public class LoginDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}

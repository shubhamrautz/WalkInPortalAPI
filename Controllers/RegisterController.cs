using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using WalkInPortalAPI.Models;
using WalkInPortalAPI.Register;

namespace WalkInPortalAPI.Controllers
{
    [Route("api/[controller]")]
    public class RegisterController : Controller
    {
        private IRegisterData _rd;
        public RegisterController(IRegisterData rd)
        {
            _rd = rd;
        }

        [HttpPost(Name = "register")]
        public async Task<IActionResult> CreateUser([FromBody][Required] CreateUser user)
        {
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                try
                {
                    dynamic createUser = await _rd.Register(user);
                    return Ok(createUser);
                }

                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }

            }
        }
    }
}
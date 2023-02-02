using Microsoft.AspNetCore.Mvc;
using WalkInPortalAPI.DataAccess;

namespace WalkInPortalAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PrefetchController : ControllerBase
    {
        private readonly IPrefetchData _pd;
        public PrefetchController(IPrefetchData pd){
            _pd = pd;
        }

        [HttpGet]
        public async Task<IActionResult> Get(){
            try{
            var results = await _pd.Prefetch();
            return Ok(results);
            }
            catch(Exception e){
                return BadRequest(e.Message);
            }
        }
    }
}
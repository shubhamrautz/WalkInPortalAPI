using Microsoft.AspNetCore.Mvc;
using WalkInPortalAPI.DataAccess;

namespace WalkInPortalAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FetchJobDataController : ControllerBase
    {
        private readonly IFetchJobData _fjd;
        public FetchJobDataController(IFetchJobData fjd)
        {
            _fjd = fjd;
        }

        [HttpGet(Name = "GetData")]
        public async Task<IActionResult> Get()
        {
            try
            {
                dynamic results = await _fjd.FetchJob();
                return Ok(results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetMoreData(int id)
        {
            try
            {
                dynamic results = await _fjd.FetchJob(id);
                return Ok(results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }



}

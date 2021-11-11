using BL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private ILocationService _locationService;

        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        [HttpGet("getLocations")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _locationService.GetLocationsAsync());
        }
    }
}

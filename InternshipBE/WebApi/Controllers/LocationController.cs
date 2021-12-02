using BL.DTOs;
using BL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationService _locationService;

        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        [HttpGet("getLocations")]
        public async Task<IActionResult> GetLocations()
        {
            return Ok(await _locationService.GetLocationsAsync());
        }

        [HttpGet("getLocationNames")]
        public async Task<IActionResult> GetLocationNames()
        {
            return Ok(await _locationService.GetLocationNamesAsync());
        }

        [HttpPost("createLocation")]
        public async Task<IActionResult> CreateLocation(CountryDTO NameLocation)
        {
            return Ok(await _locationService.CreateLocationAsync(NameLocation));
        }
    }
}

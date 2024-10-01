using Common.Models;
using Microsoft.AspNetCore.Mvc;
using Services.WineServices;

namespace WineAppBackEnd.Controllers.WineController
{
    [Route("api/wine")]
    [ApiController]
    public class WineController : ControllerBase
    {
        public readonly IWineServices _wineServices;
        public WineController(IWineServices wineServices)
        {
            _wineServices = wineServices;
        }

        [HttpPost]
        public IActionResult AddWine([FromBody] WineForCreateDTO wineDTO)
        {
            if (wineDTO == null)
                return BadRequest("The body request is null");

            try
            {
                _wineServices.AddWine(wineDTO);
            }
            catch (InvalidOperationException)
            {
                return BadRequest("This wine already exists");
            }
            return Created("Location", "Resource");
        }

        [HttpGet]
        public IActionResult GetAllWinesStock()
        {
            return Ok(_wineServices.GetAllWinesStock());
        }
    }
}

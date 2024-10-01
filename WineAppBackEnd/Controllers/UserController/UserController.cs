using Common.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.UserServices;

namespace WineInventory.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly IUserServices _userServices;
        public UserController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        [HttpPost]
        public IActionResult AddUser([FromBody] UserForCreateDTO userDTO)
        {
            if (userDTO == null)
                return BadRequest("The body cant be null");
            try
            {
                _userServices.AddUser(userDTO);
            }
            catch (InvalidOperationException)
            {
                return BadRequest("This username alredy exists...");
            }
            return Created("Location", "Resource");
        }
    }
}
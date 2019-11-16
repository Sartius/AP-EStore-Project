using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ES_DTO;
using ES_DAL;

namespace API_IndividualAp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        IUserManager _userManager;
        public UserController(IUserManager userManager)
        {
            _userManager = userManager;
        }

        [HttpGet("{userId}")]
        public IActionResult Get(int userId, [FromHeader(Name = "MyAuthentication")] string myAuth)
        {

            UserDtoModel user = _userManager.GetUser(userId);
            
            if(user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

    }
}

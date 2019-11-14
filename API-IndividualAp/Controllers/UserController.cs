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
        [HttpGet("{userId}")]
        public IActionResult Get(int userId, [FromHeader(Name = "MyAuthentication")] string myAuth)
        {
            //return Ok($"USER userId={userId}, a={a}, b={b}" +
            //    Environment.NewLine + $"myAuth={myAuth}");

            UserDtoModel user = UserManager.GetUser(userId);
            return Ok(user);
        }

    }
}

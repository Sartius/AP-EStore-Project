using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API_IndividualAp.Models;

namespace API_IndividualAp.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly DBContext _dBContext;
        public UserController(DBContext context)
        {
            _dBContext = context;
        }

        //GET:      api/user
        [HttpGet]
        public ActionResult<IEnumerable<UserDtoModel>> GetUsers()
        {
            return _dBContext.UserList;
        }

        //GET:     api/user/n
        [HttpGet("{id}")]
        public ActionResult<UserDtoModel> GetSingleUser(int id)
        {
            var singleUser = _dBContext.UserList.Find(id);
            if (singleUser == null)
            {
                return NotFound();
            }
            else
                return singleUser;
        }

        //POST:    api/user
        [HttpPost]
        public ActionResult<UserDtoModel> PostSingleUser(UserDtoModel user)
        {
            Console.WriteLine(user);
            _dBContext.UserList.Add(user);
            _dBContext.SaveChanges();

            return CreatedAtAction("GetSingleUser", new UserDtoModel { Id = user.Id }, user);
        }

        
    }
}

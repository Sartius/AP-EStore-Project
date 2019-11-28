using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ES_DTO;
using ES_DAL;
using ES_BLL.Interfaces;

namespace API_IndividualAp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserManager _userManager;
        private readonly ICartLogic _cartLogic;
        private readonly IUserLogic _userLogic;
        private readonly IEncription _encription;
        
        public UserController(IUserManager userManager,IUserLogic userLogic,ICartLogic cartLogic,IEncription encription)
        {
            _userManager = userManager;
            _cartLogic = cartLogic;
            _userLogic = userLogic;
            _encription = encription;
        }

        [HttpGet("{userId}")]
        public IActionResult GetUserById(int userId, [FromHeader(Name = "MyAuthentication")] string myAuth)
        {

            UserDtoModel user = _userManager.GetUser(userId);
            
            if(user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpGet]
        public IActionResult LoginUser(string username, string password)
        {
            UserDtoModel user;
            try
            {
                user = _userManager.UserLogin(username, _encription.RecreateHash(username, password));
            }
            catch (Exception nouser)
            {
                return BadRequest(nouser.Message);
            }
            //catch (Exception ex)
            //{
            //    return BadRequest(ex.Message);
            //}
            return Ok(user.Id);
        }

        [HttpPost]
        public IActionResult Register([FromBody] UserDtoModel user)
        {
            if (_userLogic.CheckIfUserExists(user.Username))
            {
                return BadRequest("That username already exists");
            }
            var passData = _encription.DBHashProvider(user.Password);
            user.Password = passData.Item1;
            user.Pepper = passData.Item2;
            int id = _userManager.RegisterUser(user, _cartLogic.CurrentUTCTime());
            return Ok(id);
        }

        [HttpGet("{id}/cart")]
        public IActionResult GetCart(int id)
        {
            CartDtoModel cart;
            try
            {
                cart = _userManager.GetUserCart(id);
            }
            catch (ArgumentNullException ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(cart);
        }


        [HttpGet("{id}/cart/cartitem")]
        public IActionResult GetCartItems(int id)
        {
            List<Tuple<CartItemsDtoModel, ItemVersionDtoModel>> cartContent;
            try
            {
                cartContent = _userManager.GetCartItemsWIthItems(id);
            }
            catch (ArgumentNullException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(cartContent);
        }
    }
}

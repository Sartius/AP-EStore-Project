using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API_IndividualAp.Models;


namespace API_IndividualAp.Controllers
{
    [Route("api/[Controller]")]
    public class ItemController : Controller
    { 

         private readonly DBContext _dBContext;
    public ItemController(DBContext context)
    {
        _dBContext = context;
    }
        [HttpGet]
        public ActionResult<IEnumerable<ItemDtoModel>> GetItemSmall()
        {
            return _dBContext.SmallItemInstance;
        }
        [HttpGet("{id}")]
        public ActionResult<ItemDtoModel> GetSingleSmallItem(int id)
        {
            var singleItem = _dBContext.SmallItemInstance.Find(id);
            if (singleItem == null)
            {
                return NotFound();
            }
            else
                return singleItem;
        }
        [HttpPost]
        public ActionResult<ItemDtoModel> PostSingleItem(ItemDtoModel item)
        {
            _dBContext.SmallItemInstance.Add(item);
            _dBContext.SaveChanges();

            return CreatedAtAction("GetItemSmall", new ItemDtoModel { Id = item.Id }, item);
        }

        
        


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PracticeCheckCloud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        List<MenuItem> _context;
        public MenuItemController()
        {
            _context = new List<MenuItem>()
            {
            new MenuItem{ Menucode=1,ItemName="Sandwich",Price=99,active=true,date_of_launch=DateTime.Parse("15-03-2017 00:00:00"),CategoryId=2,freeDelivery=true
           },
            new MenuItem{ Menucode=2,ItemName="Burger",Price=129,active=true,date_of_launch=DateTime.Parse("23-12-2017 00:00:00"),CategoryId=2,freeDelivery=false     }
          

            };
        }

        // GET: api/Truyum
        [HttpGet]
        public IEnumerable<MenuItem> GetMenuItems()
        {
            return _context.ToList();
        }

        // GET: api/Customer/5
        [HttpGet("{id}")]
        public MenuItem GetItems(int id)
        {
            var item = _context[id];



            return item;
        }


    }
}

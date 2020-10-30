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
    public class AnonymousController : ControllerBase
    {
        public static List<MenuItem> _menuList = new List<MenuItem>()
            {
            new MenuItem()
            {
                Menucode=1,ItemName="Sandwich",Price=99,active=true,date_of_launch=DateTime.Parse("15-03-2017 00:00:00"),CategoryId=2,freeDelivery=true
            },
            new MenuItem()
            {
                Menucode=2,ItemName="Burger",Price=129,active=true,date_of_launch=DateTime.Parse("23-12-2017 00:00:00"),CategoryId=2,freeDelivery=false
            }

            };

        public static List<Categories> _categoryList = new List<Categories>()
            {
            new Categories(){CategoryId=1,CategoryName="Starter"},
            new Categories(){CategoryId=2,CategoryName="MainCourse"}

           };
        // GET: api/Anonymous
        [HttpGet]
        public ActionResult<IEnumerable<MenuItem>> GetMenuItems()
        {
            return _menuList;
        }

    }
}

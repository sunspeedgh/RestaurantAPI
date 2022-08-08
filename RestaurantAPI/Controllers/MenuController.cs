using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantAPI.Utils;
using Newtonsoft.Json;
using RestaurantAPI.Models;
using RestaurantAPI.Services;

namespace RestaurantAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class MenuController : Controller
    {
        //Get AllMenu

        [HttpGet]
        public async Task<ActionResult> GetAllMenus()
        {
            MenuService _service = new MenuService();
            return Json(await _service.GetAllMenusAsync());                
        }

        [HttpGet]        
        public ActionResult GetMenuItemsByCategory(string categoryId)
        {
            MenuService _service = new MenuService();
            return Json(_service.GetItemByCategory(categoryId));
        }

        [HttpGet]
        public ActionResult GetMenuItemsByDish(string dishid)
        {
            MenuService _service=new MenuService();
            return Json(_service.GetItemByDish(dishid));
        }


        //Get MenubyStoreId

        //Get MenubyCategory

        //Get MenubyOptions


    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestaurantAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class StoreController : Controller
    {
        [HttpGet]
        public async Task<ActionResult> GetAllStores()
        {
            //TODO - Get all stores
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> GetStoreById()
        {
            //TODO - Get store by id
            return View();
        }
    }
}

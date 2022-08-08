using Microsoft.AspNetCore.Mvc;

namespace RestaurantAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class OrderController : Controller
    {
        [HttpGet]
        public async Task<ActionResult> GetOrder()
        {
            //TODO - Get Order
            return View();
        }
        [HttpGet]
        public async Task<ActionResult> GetOrderbyId()
        {
            //TODO - Get Order
            return View();
        }
    }
}

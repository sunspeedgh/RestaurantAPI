using Microsoft.AspNetCore.Mvc;

namespace RestaurantAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class DeliveryController : Controller
    {
        [HttpGet]
        public async Task<ActionResult> GetDeliveryNotification()
        {
            return View();
        }
        [HttpGet]
        public async Task<ActionResult> PostDeliveryNotification()
        {
            return View();
        }
    }
}

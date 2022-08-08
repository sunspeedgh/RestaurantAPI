using Microsoft.AspNetCore.Mvc;

namespace RestaurantAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class AuthorizationController : Controller
    {
        [HttpGet]
        public async Task<ActionResult> GetAuthorizationToken(string userid,string password)
        {
            //TODO - Get token
            return View();
        }
    }
}

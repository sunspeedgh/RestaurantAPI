using Microsoft.AspNetCore.Mvc;

namespace RestaurantAPI.Controllers
{
    public class ReportingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

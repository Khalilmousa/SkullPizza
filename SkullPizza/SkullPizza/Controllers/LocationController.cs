using Microsoft.AspNetCore.Mvc;

namespace SkullPizza.Controllers
{
    public class LocationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

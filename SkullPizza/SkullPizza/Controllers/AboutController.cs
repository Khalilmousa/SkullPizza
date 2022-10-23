using Microsoft.AspNetCore.Mvc;

namespace SkullPizza.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace SkullPizza.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

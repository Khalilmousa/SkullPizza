using Microsoft.AspNetCore.Mvc;

namespace SkullPizza.Controllers
{
    public class ShoppingCartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

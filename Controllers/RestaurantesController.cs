using Microsoft.AspNetCore.Mvc;

namespace Trabajo.Controllers
{
    public class RestaurantesController : Controller
    {
        public IActionResult Restaurantes()
        {
            return View();
        }
    }
}
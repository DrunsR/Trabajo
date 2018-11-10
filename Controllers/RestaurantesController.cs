using Microsoft.AspNetCore.Mvc;

namespace Trabajo.Controllers
{
    public class RestaurantesController : SecretController
    {
        public IActionResult Restaurantes()
        {
            return View();
        }
        public IActionResult menus()
        {
            return View();
        }
    }
}
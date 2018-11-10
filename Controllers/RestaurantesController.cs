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
        public IActionResult agregarmenu()
        {
            return View();
        }
        public IActionResult principalrestaurantes()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trabajo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace Trabajo.Controllers
{
    public class RestaurantesController : SecretController
    {
        private readonly ReadyToEatContext _context;

        public RestaurantesController(ReadyToEatContext context)
        {
            this._context = context;
        }

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
        public IActionResult Principal()
        {

            var UsuarioName = HttpContext.Session.GetString("NombreUsuario");
            var user = _context.Restaurante.FirstOrDefault(x => x.nombre == UsuarioName);

            return View(user);
        }
    }
}
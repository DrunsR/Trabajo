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
            var Lista = _context.Restaurante.ToList();

            return View(Lista);
            
        }
        public IActionResult menus(int id)
        {

            var res = _context.Restaurante.Include(x=>x.Menu).FirstOrDefault(x => x.Id == id);
            return View(res);
        }
        public IActionResult agregarmenu()
        {
            return View();
        }
        [HttpPost]
        public IActionResult agregarmenu(Platillo p)
        {
            if(ModelState.IsValid){

                var UsuarioName = HttpContext.Session.GetString("NombreUsuario");

                var user = _context.Restaurante.FirstOrDefault(x => x.ini.Usuario == UsuarioName);
                
                p.regId = user.Id;         

                _context.Add(p);
                _context.SaveChanges();

                   
                return RedirectToAction("Principal","Restaurantes");
                

            }

            return View(p);
        }
        public IActionResult Principal()
        {

            var UsuarioName = HttpContext.Session.GetString("NombreUsuario");

            var user = _context.Restaurante.Include(x=>x.Recomendaciones).FirstOrDefault(x => x.ini.Usuario == UsuarioName);

            return View(user);
        }
    }
}
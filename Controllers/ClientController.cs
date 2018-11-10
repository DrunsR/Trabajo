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
    public class ClientController : Controller
    {

        private readonly ReadyToEatContext _context;
        public ClientController(ReadyToEatContext context)
        {
            this._context = context;
        }

        public IActionResult InicioSesion()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult InicioSesion(InicioR c)
        {
            if(ModelState.IsValid){
                
                return RedirectToAction("Nosotros","Home");

            }
            return View(c);
        }
        public IActionResult RegistroRestaurante()
        {
            ViewBag.Usuario= HttpContext.Session.GetString("NombreUsuario");
            return View();  
        }
        

        
        [HttpPost]
        public IActionResult RegistroRestaurante(Restaurante r)
        {
            if(ModelState.IsValid){

                _context.Add(r);
                _context.SaveChanges();
                HttpContext.Session.SetString("NombreUsuario", r.Ini.NombreUsuario);
                    
                
                return RedirectToAction("Nosotros","Home");

            }
            return View(r);
        }

        public IActionResult Salir()
        {
            return View("About","Home");
        }       

    }
}
